/* Generated By:JavaCC: Do not edit this line. SemgrexParser.java */
using System;
using System.Collections.Generic;
using Edu.Stanford.Nlp.Util;
using Java.IO;
using Sharpen;

namespace Edu.Stanford.Nlp.Semgraph.Semgrex
{
	internal class SemgrexParser : ISemgrexParserConstants
	{
		private bool underNegation = false;

		private bool underNodeNegation = false;

		private ICollection<string> knownVariables = Generics.NewHashSet();

		// all generated classes are in this package
		//imports
		// this is so we can tell, at any point during the parse
		// whether we are under a negation, which we need to know
		// because labeling nodes under negation is illegal
		// keep track of which variables we've already seen
		// lets us make sure we don't name new nodes under a negation
		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern Root()
		{
			SemgrexPattern node;
			Token reverse = null;
			IList<SemgrexPattern> children = new List<SemgrexPattern>();
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case SemgrexParserConstantsConstants.Alignreln:
				{
					reverse = Jj_consume_token(SemgrexParserConstantsConstants.Alignreln);
					node = SubNode(GraphRelation.AlignedRoot);
					Jj_consume_token(11);
					break;
				}

				case 13:
				case 17:
				case 19:
				case 23:
				{
					node = SubNode(GraphRelation.Root);
					children.Add(node);
					while (true)
					{
						switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
						{
							case 12:
							{
								break;
							}

							default:
							{
								jj_la1[0] = jj_gen;
								goto label_1_break;
							}
						}
						Jj_consume_token(12);
						node = SubNode(GraphRelation.Iterator);
						children.Add(node);
label_1_continue: ;
					}
label_1_break: ;
					Jj_consume_token(11);
					break;
				}

				default:
				{
					jj_la1[1] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			if (children.Count <= 1)
			{
				if (true)
				{
					return node;
				}
			}
			{
				if (true)
				{
					return new CoordinationPattern(true, children, true);
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern SubNode(GraphRelation r)
		{
			SemgrexPattern result = null;
			SemgrexPattern child = null;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 13:
				{
					Jj_consume_token(13);
					result = SubNode(r);
					Jj_consume_token(14);
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case SemgrexParserConstantsConstants.Relation:
						case SemgrexParserConstantsConstants.Alignreln:
						case SemgrexParserConstantsConstants.Identifier:
						case 17:
						case 18:
						case 19:
						{
							child = RelationDisj();
							break;
						}

						default:
						{
							jj_la1[2] = jj_gen;
							break;
						}
					}
					if (child != null)
					{
						IList<SemgrexPattern> newChildren = new List<SemgrexPattern>();
						Sharpen.Collections.AddAll(newChildren, result.GetChildren());
						newChildren.Add(child);
						result.SetChild(new CoordinationPattern(false, newChildren, true));
					}
					if (true)
					{
						return result;
					}
					break;
				}

				case 17:
				case 19:
				case 23:
				{
					result = ModNode(r);
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case SemgrexParserConstantsConstants.Relation:
						case SemgrexParserConstantsConstants.Alignreln:
						case SemgrexParserConstantsConstants.Identifier:
						case 17:
						case 18:
						case 19:
						{
							child = RelationDisj();
							break;
						}

						default:
						{
							jj_la1[3] = jj_gen;
							break;
						}
					}
					if (child != null)
					{
						result.SetChild(child);
					}
					if (true)
					{
						return result;
					}
					break;
				}

				default:
				{
					jj_la1[4] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern RelationDisj()
		{
			SemgrexPattern child;
			IList<SemgrexPattern> children = new List<SemgrexPattern>();
			child = RelationConj();
			children.Add(child);
			while (true)
			{
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case 15:
					{
						break;
					}

					default:
					{
						jj_la1[5] = jj_gen;
						goto label_2_break;
					}
				}
				Jj_consume_token(15);
				child = RelationConj();
				children.Add(child);
label_2_continue: ;
			}
label_2_break: ;
			if (children.Count == 1)
			{
				{
					if (true)
					{
						return child;
					}
				}
			}
			else
			{
				{
					if (true)
					{
						return new CoordinationPattern(false, children, false);
					}
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern RelationConj()
		{
			SemgrexPattern child;
			IList<SemgrexPattern> children = new List<SemgrexPattern>();
			child = ModRelation();
			children.Add(child);
			while (true)
			{
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case SemgrexParserConstantsConstants.Relation:
					case SemgrexParserConstantsConstants.Alignreln:
					case SemgrexParserConstantsConstants.Identifier:
					case 16:
					case 17:
					case 18:
					case 19:
					{
						break;
					}

					default:
					{
						jj_la1[6] = jj_gen;
						goto label_3_break;
					}
				}
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case 16:
					{
						Jj_consume_token(16);
						break;
					}

					default:
					{
						jj_la1[7] = jj_gen;
						break;
					}
				}
				child = ModRelation();
				children.Add(child);
label_3_continue: ;
			}
label_3_break: ;
			if (children.Count == 1)
			{
				{
					if (true)
					{
						return child;
					}
				}
			}
			else
			{
				{
					if (true)
					{
						return new CoordinationPattern(false, children, true);
					}
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern ModRelation()
		{
			SemgrexPattern child;
			bool startUnderNeg;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case SemgrexParserConstantsConstants.Relation:
				case SemgrexParserConstantsConstants.Alignreln:
				case SemgrexParserConstantsConstants.Identifier:
				case 19:
				{
					child = RelChild();
					break;
				}

				case 17:
				{
					Jj_consume_token(17);
					startUnderNeg = underNegation;
					underNegation = true;
					child = RelChild();
					underNegation = startUnderNeg;
					child.Negate();
					break;
				}

				case 18:
				{
					Jj_consume_token(18);
					child = RelChild();
					child.MakeOptional();
					break;
				}

				default:
				{
					jj_la1[8] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			{
				if (true)
				{
					return child;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern RelChild()
		{
			SemgrexPattern child;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 19:
				{
					Jj_consume_token(19);
					child = RelationDisj();
					Jj_consume_token(20);
					break;
				}

				case SemgrexParserConstantsConstants.Relation:
				case SemgrexParserConstantsConstants.Alignreln:
				case SemgrexParserConstantsConstants.Identifier:
				{
					child = Relation();
					break;
				}

				default:
				{
					jj_la1[9] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			{
				if (true)
				{
					return child;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern Relation()
		{
			GraphRelation reln;
			Token rel = null;
			Token relnType = null;
			Token numArg = null;
			Token numArg2 = null;
			Token name = null;
			SemgrexPattern node;
			bool pC = false;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case SemgrexParserConstantsConstants.Relation:
				case SemgrexParserConstantsConstants.Identifier:
				{
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case SemgrexParserConstantsConstants.Identifier:
						{
							numArg = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
							switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
							{
								case 21:
								{
									Jj_consume_token(21);
									numArg2 = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
									break;
								}

								default:
								{
									jj_la1[10] = jj_gen;
									break;
								}
							}
							break;
						}

						default:
						{
							jj_la1[11] = jj_gen;
							break;
						}
					}
					rel = Jj_consume_token(SemgrexParserConstantsConstants.Relation);
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case SemgrexParserConstantsConstants.Identifier:
						case SemgrexParserConstantsConstants.Regex:
						{
							switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
							{
								case SemgrexParserConstantsConstants.Identifier:
								{
									relnType = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
									break;
								}

								case SemgrexParserConstantsConstants.Regex:
								{
									relnType = Jj_consume_token(SemgrexParserConstantsConstants.Regex);
									break;
								}

								default:
								{
									jj_la1[12] = jj_gen;
									Jj_consume_token(-1);
									throw new ParseException();
								}
							}
							break;
						}

						default:
						{
							jj_la1[13] = jj_gen;
							break;
						}
					}
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case 22:
						{
							Jj_consume_token(22);
							name = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
							break;
						}

						default:
						{
							jj_la1[14] = jj_gen;
							break;
						}
					}
					break;
				}

				case SemgrexParserConstantsConstants.Alignreln:
				{
					rel = Jj_consume_token(SemgrexParserConstantsConstants.Alignreln);
					break;
				}

				default:
				{
					jj_la1[15] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			if (numArg == null && numArg2 == null)
			{
				reln = GraphRelation.GetRelation(rel != null ? rel.image : null, relnType != null ? relnType.image : null, name != null ? name.image : null);
			}
			else
			{
				if (numArg2 == null)
				{
					reln = GraphRelation.GetRelation(rel != null ? rel.image : null, relnType != null ? relnType.image : null, System.Convert.ToInt32(numArg.image), name != null ? name.image : null);
				}
				else
				{
					reln = GraphRelation.GetRelation(rel != null ? rel.image : null, relnType != null ? relnType.image : null, System.Convert.ToInt32(numArg.image), System.Convert.ToInt32(numArg2.image), name != null ? name.image : null);
				}
			}
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 17:
				case 19:
				case 23:
				{
					node = ModNode(reln);
					break;
				}

				case 13:
				{
					Jj_consume_token(13);
					node = SubNode(reln);
					Jj_consume_token(14);
					break;
				}

				default:
				{
					jj_la1[16] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			{
				if (true)
				{
					return node;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern NodeDisj(GraphRelation r)
		{
			SemgrexPattern child;
			IList<SemgrexPattern> children = new List<SemgrexPattern>();
			Jj_consume_token(19);
			child = NodeConj(r);
			children.Add(child);
			while (true)
			{
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case 15:
					{
						break;
					}

					default:
					{
						jj_la1[17] = jj_gen;
						goto label_4_break;
					}
				}
				Jj_consume_token(15);
				child = NodeConj(r);
				children.Add(child);
label_4_continue: ;
			}
label_4_break: ;
			Jj_consume_token(20);
			if (children.Count == 1)
			{
				if (true)
				{
					return child;
				}
			}
			else
			{
				if (true)
				{
					return new CoordinationPattern(true, children, false);
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern NodeConj(GraphRelation r)
		{
			SemgrexPattern child;
			IList<SemgrexPattern> children = new List<SemgrexPattern>();
			child = ModNode(r);
			children.Add(child);
			while (true)
			{
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case 16:
					case 17:
					case 19:
					case 23:
					{
						break;
					}

					default:
					{
						jj_la1[18] = jj_gen;
						goto label_5_break;
					}
				}
				switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
				{
					case 16:
					{
						Jj_consume_token(16);
						break;
					}

					default:
					{
						jj_la1[19] = jj_gen;
						break;
					}
				}
				child = ModNode(r);
				children.Add(child);
label_5_continue: ;
			}
label_5_break: ;
			if (children.Count == 1)
			{
				if (true)
				{
					return child;
				}
			}
			else
			{
				if (true)
				{
					return new CoordinationPattern(true, children, true);
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern ModNode(GraphRelation r)
		{
			SemgrexPattern child;
			bool startUnderNeg;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 19:
				case 23:
				{
					child = Child(r);
					break;
				}

				case 17:
				{
					Jj_consume_token(17);
					startUnderNeg = underNodeNegation;
					underNodeNegation = true;
					child = Child(r);
					underNodeNegation = startUnderNeg;
					break;
				}

				default:
				{
					jj_la1[20] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			{
				if (true)
				{
					return child;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public SemgrexPattern Child(GraphRelation r)
		{
			SemgrexPattern child;
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 19:
				{
					child = NodeDisj(r);
					break;
				}

				case 23:
				{
					child = Description(r);
					break;
				}

				default:
				{
					jj_la1[21] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			{
				if (true)
				{
					return child;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		public NodePattern Description(GraphRelation r)
		{
			Token name = null;
			bool link = false;
			bool isRoot = false;
			bool isEmpty = false;
			Token attr = null;
			Token value = null;
			IDictionary<string, string> attributes = Generics.NewHashMap();
			NodePattern pat;
			Jj_consume_token(23);
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case SemgrexParserConstantsConstants.Identifier:
				{
					attr = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
					Jj_consume_token(12);
					switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
					{
						case SemgrexParserConstantsConstants.Identifier:
						{
							value = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
							break;
						}

						case SemgrexParserConstantsConstants.Regex:
						{
							value = Jj_consume_token(SemgrexParserConstantsConstants.Regex);
							break;
						}

						default:
						{
							jj_la1[22] = jj_gen;
							Jj_consume_token(-1);
							throw new ParseException();
						}
					}
					if (attr != null && value != null)
					{
						attributes[attr.image] = value.image;
					}
					while (true)
					{
						switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
						{
							case 24:
							{
								break;
							}

							default:
							{
								jj_la1[23] = jj_gen;
								goto label_6_break;
							}
						}
						Jj_consume_token(24);
						attr = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
						Jj_consume_token(12);
						switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
						{
							case SemgrexParserConstantsConstants.Identifier:
							{
								value = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
								break;
							}

							case SemgrexParserConstantsConstants.Regex:
							{
								value = Jj_consume_token(SemgrexParserConstantsConstants.Regex);
								break;
							}

							default:
							{
								jj_la1[24] = jj_gen;
								Jj_consume_token(-1);
								throw new ParseException();
							}
						}
						if (attr != null && value != null)
						{
							attributes[attr.image] = value.image;
						}
label_6_continue: ;
					}
label_6_break: ;
					Jj_consume_token(25);
					break;
				}

				case SemgrexParserConstantsConstants.Root:
				{
					attr = Jj_consume_token(SemgrexParserConstantsConstants.Root);
					Jj_consume_token(25);
					isRoot = true;
					break;
				}

				case SemgrexParserConstantsConstants.Empty:
				{
					attr = Jj_consume_token(SemgrexParserConstantsConstants.Empty);
					Jj_consume_token(25);
					isEmpty = true;
					break;
				}

				case 25:
				{
					Jj_consume_token(25);
					break;
				}

				default:
				{
					jj_la1[25] = jj_gen;
					Jj_consume_token(-1);
					throw new ParseException();
				}
			}
			switch ((jj_ntk == -1) ? Jj_ntk() : jj_ntk)
			{
				case 22:
				{
					Jj_consume_token(22);
					link = true;
					name = Jj_consume_token(SemgrexParserConstantsConstants.Identifier);
					string nodeName = name.image;
					if (underNegation)
					{
						if (!knownVariables.Contains(nodeName))
						{
							{
								if (true)
								{
									throw new ParseException("Cannot add new variable names under negation.  Node '" + nodeName + "' not seen before");
								}
							}
						}
					}
					else
					{
						knownVariables.Add(nodeName);
					}
					break;
				}

				default:
				{
					jj_la1[26] = jj_gen;
					break;
				}
			}
			pat = new NodePattern(r, underNodeNegation, attributes, isRoot, isEmpty, name != null ? name.image : null);
			if (link)
			{
				pat.MakeLink();
			}
			{
				if (true)
				{
					return pat;
				}
			}
			throw new Exception("Missing return statement in function");
		}

		/// <summary>Generated Token Manager.</summary>
		public SemgrexParserTokenManager token_source;

		internal SimpleCharStream jj_input_stream;

		/// <summary>Current token.</summary>
		public Token token;

		/// <summary>Next token.</summary>
		public Token jj_nt;

		private int jj_ntk;

		private int jj_gen;

		private readonly int[] jj_la1 = new int[27];

		private static int[] jj_la1_0;

		static SemgrexParser()
		{
			Jj_la1_init_0();
		}

		private static void Jj_la1_init_0()
		{
			jj_la1_0 = new int[] { unchecked((int)(0x1000)), unchecked((int)(0x8a2020)), unchecked((int)(0xe0070)), unchecked((int)(0xe0070)), unchecked((int)(0x8a2000)), unchecked((int)(0x8000)), unchecked((int)(0xf0070)), unchecked((int)(0x10000)), unchecked(
				(int)(0xe0070)), unchecked((int)(0x80070)), unchecked((int)(0x200000)), unchecked((int)(0x40)), unchecked((int)(0x440)), unchecked((int)(0x440)), unchecked((int)(0x400000)), unchecked((int)(0x70)), unchecked((int)(0x8a2000)), unchecked((int
				)(0x8000)), unchecked((int)(0x8b0000)), unchecked((int)(0x10000)), unchecked((int)(0x8a0000)), unchecked((int)(0x880000)), unchecked((int)(0x440)), unchecked((int)(0x1000000)), unchecked((int)(0x440)), unchecked((int)(0x2000340)), unchecked(
				(int)(0x400000)) };
		}

		/// <summary>Constructor with InputStream.</summary>
		public SemgrexParser(InputStream stream)
			: this(stream, null)
		{
		}

		/// <summary>Constructor with InputStream and supplied encoding</summary>
		public SemgrexParser(InputStream stream, string encoding)
		{
			try
			{
				jj_input_stream = new SimpleCharStream(stream, encoding, 1, 1);
			}
			catch (UnsupportedEncodingException e)
			{
				throw new Exception(e);
			}
			token_source = new SemgrexParserTokenManager(jj_input_stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <summary>Reinitialise.</summary>
		public virtual void ReInit(InputStream stream)
		{
			ReInit(stream, null);
		}

		/// <summary>Reinitialise.</summary>
		public virtual void ReInit(InputStream stream, string encoding)
		{
			try
			{
				jj_input_stream.ReInit(stream, encoding, 1, 1);
			}
			catch (UnsupportedEncodingException e)
			{
				throw new Exception(e);
			}
			token_source.ReInit(jj_input_stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <summary>Constructor.</summary>
		public SemgrexParser(Reader stream)
		{
			jj_input_stream = new SimpleCharStream(stream, 1, 1);
			token_source = new SemgrexParserTokenManager(jj_input_stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <summary>Reinitialise.</summary>
		public virtual void ReInit(Reader stream)
		{
			jj_input_stream.ReInit(stream, 1, 1);
			token_source.ReInit(jj_input_stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <summary>Constructor with generated Token Manager.</summary>
		public SemgrexParser(SemgrexParserTokenManager tm)
		{
			token_source = tm;
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <summary>Reinitialise.</summary>
		public virtual void ReInit(SemgrexParserTokenManager tm)
		{
			token_source = tm;
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 27; i++)
			{
				jj_la1[i] = -1;
			}
		}

		/// <exception cref="Edu.Stanford.Nlp.Semgraph.Semgrex.ParseException"/>
		private Token Jj_consume_token(int kind)
		{
			Token oldToken;
			if ((oldToken = token).next != null)
			{
				token = token.next;
			}
			else
			{
				token = token.next = token_source.GetNextToken();
			}
			jj_ntk = -1;
			if (token.kind == kind)
			{
				jj_gen++;
				return token;
			}
			token = oldToken;
			jj_kind = kind;
			throw GenerateParseException();
		}

		/// <summary>Get the next Token.</summary>
		public Token GetNextToken()
		{
			if (token.next != null)
			{
				token = token.next;
			}
			else
			{
				token = token.next = token_source.GetNextToken();
			}
			jj_ntk = -1;
			jj_gen++;
			return token;
		}

		/// <summary>Get the specific Token.</summary>
		public Token GetToken(int index)
		{
			Token t = token;
			for (int i = 0; i < index; i++)
			{
				if (t.next != null)
				{
					t = t.next;
				}
				else
				{
					t = t.next = token_source.GetNextToken();
				}
			}
			return t;
		}

		private int Jj_ntk()
		{
			if ((jj_nt = token.next) == null)
			{
				return (jj_ntk = (token.next = token_source.GetNextToken()).kind);
			}
			else
			{
				return (jj_ntk = jj_nt.kind);
			}
		}

		private IList<int[]> jj_expentries = new List<int[]>();

		private int[] jj_expentry;

		private int jj_kind = -1;

		/// <summary>Generate ParseException.</summary>
		public virtual ParseException GenerateParseException()
		{
			jj_expentries.Clear();
			bool[] la1tokens = new bool[26];
			if (jj_kind >= 0)
			{
				la1tokens[jj_kind] = true;
				jj_kind = -1;
			}
			for (int i = 0; i < 27; i++)
			{
				if (jj_la1[i] == jj_gen)
				{
					for (int j = 0; j < 32; j++)
					{
						if ((jj_la1_0[i] & (1 << j)) != 0)
						{
							la1tokens[j] = true;
						}
					}
				}
			}
			for (int i_1 = 0; i_1 < 26; i_1++)
			{
				if (la1tokens[i_1])
				{
					jj_expentry = new int[1];
					jj_expentry[0] = i_1;
					jj_expentries.Add(jj_expentry);
				}
			}
			int[][] exptokseq = new int[jj_expentries.Count][];
			for (int i_2 = 0; i_2 < jj_expentries.Count; i_2++)
			{
				exptokseq[i_2] = jj_expentries[i_2];
			}
			return new ParseException(token, exptokseq, SemgrexParserConstantsConstants.tokenImage);
		}

		/// <summary>Enable tracing.</summary>
		public void Enable_tracing()
		{
		}

		/// <summary>Disable tracing.</summary>
		public void Disable_tracing()
		{
		}
	}
}
