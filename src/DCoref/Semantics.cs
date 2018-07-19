using System;
using Java.Lang.Reflect;
using Sharpen;

namespace Edu.Stanford.Nlp.Dcoref
{
	/// <summary>Semantic knowledge: currently WordNet is available</summary>
	public class Semantics
	{
		public object wordnet;

		public Semantics()
		{
		}

		/// <exception cref="System.Exception"/>
		public Semantics(Dictionaries dict)
		{
			Constructor<object> wordnetConstructor = (Sharpen.Runtime.GetType("edu.stanford.nlp.dcoref.WordNet")).GetConstructor();
			wordnet = wordnetConstructor.NewInstance();
		}
	}
}
