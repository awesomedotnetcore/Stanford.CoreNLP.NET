using System;
using System.Collections.Generic;
using Edu.Stanford.Nlp.IE;
using Edu.Stanford.Nlp.IE.Regexp;
using Edu.Stanford.Nlp.Ling;
using Edu.Stanford.Nlp.Util;
using Edu.Stanford.Nlp.Util.Logging;
using Java.Util;
using Sharpen;

namespace Edu.Stanford.Nlp.Pipeline
{
	/// <summary>
	/// This calls NumberSequenceClassifier, which is a rule based classifier, which
	/// adds a NUMBER entity tag to numbers not already given another entity tag, and
	/// also has additional rules for marking MONEY, TIME, and DATE.
	/// </summary>
	/// <remarks>
	/// This calls NumberSequenceClassifier, which is a rule based classifier, which
	/// adds a NUMBER entity tag to numbers not already given another entity tag, and
	/// also has additional rules for marking MONEY, TIME, and DATE. It assumes that
	/// tokens already have a (POS) TagAnnotation, and an original round of NER that
	/// covers MONEY and American DATE/TIME formats, such as MUC NER in
	/// AnswerAnnotation, to which we add.
	/// </remarks>
	/// <author>Jenny Finkel</author>
	public class NumberAnnotator : IAnnotator
	{
		/// <summary>A logger for this class</summary>
		private static Redwood.RedwoodChannels log = Redwood.Channels(typeof(Edu.Stanford.Nlp.Pipeline.NumberAnnotator));

		private readonly AbstractSequenceClassifier<CoreLabel> nsc;

		private bool Verbose = true;

		private const string DefaultBackgroundSymbol = "O";

		private readonly string BackgroundSymbol;

		public const string BackgroundSymbolProperty = "background";

		public NumberAnnotator()
			: this(DefaultBackgroundSymbol, true, NumberSequenceClassifier.UseSutimeDefault)
		{
		}

		public NumberAnnotator(bool verbose)
			: this(DefaultBackgroundSymbol, verbose, NumberSequenceClassifier.UseSutimeDefault)
		{
		}

		public NumberAnnotator(bool verbose, bool useSUTime)
			: this(DefaultBackgroundSymbol, verbose, useSUTime)
		{
		}

		public NumberAnnotator(string backgroundSymbol, bool verbose, bool useSUTime)
		{
			BackgroundSymbol = backgroundSymbol;
			Verbose = verbose;
			nsc = new NumberSequenceClassifier(useSUTime);
		}

		public NumberAnnotator(string name, Properties props)
		{
			string property = name + "." + BackgroundSymbolProperty;
			BackgroundSymbol = props.GetProperty(property, DefaultBackgroundSymbol);
			bool useSUTime = PropertiesUtils.GetBool(props, NumberSequenceClassifier.UseSutimeProperty, NumberSequenceClassifier.UseSutimeDefault);
			Verbose = false;
			nsc = new NumberSequenceClassifier(useSUTime);
		}

		public virtual void Annotate(Annotation annotation)
		{
			if (Verbose)
			{
				log.Info("Adding number annotation ... ");
			}
			if (annotation.ContainsKey(typeof(CoreAnnotations.SentencesAnnotation)))
			{
				// classify tokens for each sentence
				foreach (ICoreMap sentence in annotation.Get(typeof(CoreAnnotations.SentencesAnnotation)))
				{
					IList<CoreLabel> tokens = sentence.Get(typeof(CoreAnnotations.TokensAnnotation));
					DoOneSentenceNew(tokens, annotation, sentence);
				}
				if (Verbose)
				{
					log.Info("done. Output: " + annotation.Get(typeof(CoreAnnotations.SentencesAnnotation)));
				}
			}
			else
			{
				if (annotation.ContainsKey(typeof(CoreAnnotations.TokensAnnotation)))
				{
					IList<CoreLabel> tokens = annotation.Get(typeof(CoreAnnotations.TokensAnnotation));
					DoOneSentenceNew(tokens, annotation, null);
				}
				else
				{
					throw new Exception("unable to find sentences in: " + annotation);
				}
			}
		}

		private void DoOneSentenceNew(IList<CoreLabel> words, Annotation doc, ICoreMap sentence)
		{
			IList<CoreLabel> newWords = NumberSequenceClassifier.CopyTokens(words, sentence);
			nsc.ClassifyWithGlobalInformation(newWords, doc, sentence);
			IEnumerator<CoreLabel> newFLIter = newWords.GetEnumerator();
			foreach (CoreLabel origWord in words)
			{
				CoreLabel newWord = newFLIter.Current;
				string before = origWord.Ner();
				string newGuess = newWord.Get(typeof(CoreAnnotations.AnswerAnnotation));
				// log.info(origWord.word());
				// log.info(origWord.ner());
				if (Verbose)
				{
					log.Info(newWord);
				}
				// log.info("-------------------------------------");
				if ((before == null || before.Equals(BackgroundSymbol) || before.Equals("MISC")) && !newGuess.Equals(BackgroundSymbol))
				{
					origWord.SetNER(newGuess);
				}
				// transfer other annotations generated by SUTime or NumberNormalizer
				NumberSequenceClassifier.TransferAnnotations(newWord, origWord);
			}
		}

		public virtual ICollection<Type> Requires()
		{
			return Java.Util.Collections.UnmodifiableSet(new ArraySet<Type>(Arrays.AsList(typeof(CoreAnnotations.TokensAnnotation), typeof(CoreAnnotations.SentencesAnnotation))));
		}

		public virtual ICollection<Type> RequirementsSatisfied()
		{
			// technically it adds some NER, but someone who wants full NER
			// labels will be very disappointed, so we do not claim to produce NER
			return Java.Util.Collections.Singleton(typeof(CoreAnnotations.NumerizedTokensAnnotation));
		}
	}
}
