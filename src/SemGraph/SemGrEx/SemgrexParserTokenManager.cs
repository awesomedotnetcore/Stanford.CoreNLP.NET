/* Generated By:JavaCC: Do not edit this line. SemgrexParserTokenManager.java */
using System.IO;
using Sharpen;

namespace Edu.Stanford.Nlp.Semgraph.Semgrex
{
	/// <summary>Token Manager.</summary>
	internal class SemgrexParserTokenManager : ISemgrexParserConstants
	{
		/// <summary>Debug output.</summary>
		public TextWriter debugStream = System.Console.Out;

		// all generated classes are in this package
		//imports
		/// <summary>Set debug output.</summary>
		public virtual void SetDebugStream(TextWriter ds)
		{
			debugStream = ds;
		}

		private int JjStopStringLiteralDfa_0(int pos, long active0)
		{
			switch (pos)
			{
				default:
				{
					return -1;
				}
			}
		}

		private int JjStartNfa_0(int pos, long active0)
		{
			return JjMoveNfa_0(JjStopStringLiteralDfa_0(pos, active0), pos + 1);
		}

		private int JjStopAtPos(int pos, int kind)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			return pos + 1;
		}

		private int JjMoveStringLiteralDfa0_0()
		{
			switch (curChar)
			{
				case 9:
				{
					return JjStartNfaWithStates_0(0, 3, 7);
				}

				case 10:
				{
					return JjStopAtPos(0, 11);
				}

				case 33:
				{
					return JjStopAtPos(0, 17);
				}

				case 35:
				{
					return JjStopAtPos(0, 8);
				}

				case 36:
				{
					return JjStartNfaWithStates_0(0, 9, 17);
				}

				case 38:
				{
					return JjStopAtPos(0, 16);
				}

				case 40:
				{
					return JjStopAtPos(0, 13);
				}

				case 41:
				{
					return JjStopAtPos(0, 14);
				}

				case 44:
				{
					return JjStopAtPos(0, 21);
				}

				case 58:
				{
					return JjStopAtPos(0, 12);
				}

				case 59:
				{
					return JjStopAtPos(0, 24);
				}

				case 61:
				{
					return JjStartNfaWithStates_0(0, 22, 5);
				}

				case 63:
				{
					return JjStopAtPos(0, 18);
				}

				case 64:
				{
					return JjStopAtPos(0, 5);
				}

				case 91:
				{
					return JjStopAtPos(0, 19);
				}

				case 93:
				{
					return JjStopAtPos(0, 20);
				}

				case 123:
				{
					return JjStopAtPos(0, 23);
				}

				case 124:
				{
					return JjStopAtPos(0, 15);
				}

				case 125:
				{
					return JjStopAtPos(0, 25);
				}

				default:
				{
					return JjMoveNfa_0(0, 0);
				}
			}
		}

		private int JjStartNfaWithStates_0(int pos, int kind, int state)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (IOException)
			{
				return pos + 1;
			}
			return JjMoveNfa_0(state, pos + 1);
		}

		internal static readonly long[] jjbitVec0 = new long[] { unchecked((long)(0xfffffffffffffffeL)), unchecked((long)(0xffffffffffffffffL)), unchecked((long)(0xffffffffffffffffL)), unchecked((long)(0xffffffffffffffffL)) };

		internal static readonly long[] jjbitVec2 = new long[] { unchecked((long)(0x0L)), unchecked((long)(0x0L)), unchecked((long)(0xffffffffffffffffL)), unchecked((long)(0xffffffffffffffffL)) };

		private int JjMoveNfa_0(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 19;
			int i = 1;
			jjstateSet[0] = startState;
			int kind = unchecked((int)(0x7fffffff));
			for (; ; )
			{
				if (++jjround == unchecked((int)(0x7fffffff)))
				{
					ReInitRounds();
				}
				if (curChar < 64)
				{
					long l = 1L << curChar;
					do
					{
						switch (jjstateSet[--i])
						{
							case 0:
							{
								if ((unchecked((long)(0x3ff0484ffffdbffL)) & l) != 0L)
								{
									if (kind > 6)
									{
										kind = 6;
									}
									JjCheckNAdd(7);
								}
								else
								{
									if ((unchecked((long)(0x5000400000000000L)) & l) != 0L)
									{
										if (kind > 4)
										{
											kind = 4;
										}
									}
									else
									{
										if (curChar == 36)
										{
											JjCheckNAddStates(0, 3);
										}
										else
										{
											if (curChar == 47)
											{
												JjCheckNAddStates(4, 6);
											}
											else
											{
												if (curChar == 61)
												{
													jjstateSet[jjnewStateCnt++] = 5;
												}
											}
										}
									}
								}
								if ((unchecked((long)(0x3ff000000000000L)) & l) != 0L)
								{
									if (kind > 7)
									{
										kind = 7;
									}
									JjCheckNAdd(8);
								}
								else
								{
									if (curChar == 60)
									{
										jjstateSet[jjnewStateCnt++] = 3;
									}
									else
									{
										if (curChar == 62)
										{
											jjstateSet[jjnewStateCnt++] = 1;
										}
									}
								}
								break;
							}

							case 17:
							{
								if (curChar == 45)
								{
									JjCheckNAdd(16);
								}
								else
								{
									if (curChar == 43)
									{
										JjCheckNAdd(15);
									}
								}
								if (curChar == 45)
								{
									if (kind > 4)
									{
										kind = 4;
									}
								}
								else
								{
									if (curChar == 43)
									{
										if (kind > 4)
										{
											kind = 4;
										}
									}
								}
								break;
							}

							case 1:
							{
								if (curChar == 62 && kind > 4)
								{
									kind = 4;
								}
								break;
							}

							case 2:
							{
								if (curChar == 62)
								{
									jjstateSet[jjnewStateCnt++] = 1;
								}
								break;
							}

							case 3:
							{
								if (curChar == 60 && kind > 4)
								{
									kind = 4;
								}
								break;
							}

							case 4:
							{
								if (curChar == 60)
								{
									jjstateSet[jjnewStateCnt++] = 3;
								}
								break;
							}

							case 5:
							{
								if (curChar == 61 && kind > 4)
								{
									kind = 4;
								}
								break;
							}

							case 6:
							{
								if (curChar == 61)
								{
									jjstateSet[jjnewStateCnt++] = 5;
								}
								break;
							}

							case 7:
							{
								if ((unchecked((long)(0x3ff0484ffffdbffL)) & l) == 0L)
								{
									break;
								}
								if (kind > 6)
								{
									kind = 6;
								}
								JjCheckNAdd(7);
								break;
							}

							case 8:
							{
								if ((unchecked((long)(0x3ff000000000000L)) & l) == 0L)
								{
									break;
								}
								if (kind > 7)
								{
									kind = 7;
								}
								JjCheckNAdd(8);
								break;
							}

							case 9:
							case 10:
							{
								if (curChar == 47)
								{
									JjCheckNAddStates(4, 6);
								}
								break;
							}

							case 12:
							{
								if ((unchecked((long)(0xffff7fffffffdbffL)) & l) != 0L)
								{
									JjCheckNAddStates(4, 6);
								}
								break;
							}

							case 13:
							{
								if (curChar == 47 && kind > 10)
								{
									kind = 10;
								}
								break;
							}

							case 14:
							{
								if (curChar == 36)
								{
									JjCheckNAddStates(0, 3);
								}
								break;
							}

							case 15:
							{
								if (curChar == 43 && kind > 4)
								{
									kind = 4;
								}
								break;
							}

							case 16:
							{
								if (curChar == 45 && kind > 4)
								{
									kind = 4;
								}
								break;
							}

							case 18:
							{
								if (curChar == 45)
								{
									JjCheckNAdd(16);
								}
								break;
							}

							default:
							{
								break;
							}
						}
					}
					while (i != startsAt);
				}
				else
				{
					if (curChar < 128)
					{
						long l = 1L << (curChar & 0x3f);
						do
						{
							switch (jjstateSet[--i])
							{
								case 0:
								case 7:
								{
									if ((unchecked((long)(0x87ffffffd7fffffeL)) & l) == 0L)
									{
										break;
									}
									if (kind > 6)
									{
										kind = 6;
									}
									JjCheckNAdd(7);
									break;
								}

								case 11:
								{
									if (curChar == 92)
									{
										jjstateSet[jjnewStateCnt++] = 10;
									}
									break;
								}

								case 12:
								{
									JjAddStates(4, 6);
									break;
								}

								default:
								{
									break;
								}
							}
						}
						while (i != startsAt);
					}
					else
					{
						int hiByte = (int)(curChar >> 8);
						int i1 = hiByte >> 6;
						long l1 = 1L << (hiByte & 0x3f);
						int i2 = (curChar & unchecked((int)(0xff))) >> 6;
						long l2 = 1L << (curChar & 0x3f);
						do
						{
							switch (jjstateSet[--i])
							{
								case 0:
								case 7:
								{
									if (!JjCanMove_0(hiByte, i1, i2, l1, l2))
									{
										break;
									}
									if (kind > 6)
									{
										kind = 6;
									}
									JjCheckNAdd(7);
									break;
								}

								case 12:
								{
									if (JjCanMove_0(hiByte, i1, i2, l1, l2))
									{
										JjAddStates(4, 6);
									}
									break;
								}

								default:
								{
									break;
								}
							}
						}
						while (i != startsAt);
					}
				}
				if (kind != unchecked((int)(0x7fffffff)))
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = unchecked((int)(0x7fffffff));
				}
				++curPos;
				if ((i = jjnewStateCnt) == (startsAt = 19 - (jjnewStateCnt = startsAt)))
				{
					return curPos;
				}
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (IOException)
				{
					return curPos;
				}
			}
		}

		internal static readonly int[] jjnextStates = new int[] { 15, 16, 17, 18, 11, 12, 13 };

		private static bool JjCanMove_0(int hiByte, int i1, int i2, long l1, long l2)
		{
			switch (hiByte)
			{
				case 0:
				{
					return ((jjbitVec2[i2] & l2) != 0L);
				}

				default:
				{
					if ((jjbitVec0[i1] & l1) != 0L)
					{
						return true;
					}
					return false;
				}
			}
		}

		/// <summary>Token literal values.</summary>
		public static readonly string[] jjstrLiteralImages = new string[] { string.Empty, null, null, null, null, "\x64", null, null, "\x2b", "\x2c", null, "\xc", "\x48", "\x32", "\x33", "\xae", "\x2e", "\x29", "\x4d", "\x85", "\x87", "\x36", "\x4b"
			, "\xad", "\x49", "\xaf" };

		/// <summary>Lexer state names.</summary>
		public static readonly string[] lexStateNames = new string[] { "DEFAULT" };

		internal static readonly long[] jjtoToken = new long[] { unchecked((long)(0x3fffff1L)) };

		internal static readonly long[] jjtoSkip = new long[] { unchecked((long)(0xeL)) };

		protected internal SimpleCharStream input_stream;

		private readonly int[] jjrounds = new int[19];

		private readonly int[] jjstateSet = new int[38];

		protected internal char curChar;

		/// <summary>Constructor.</summary>
		public SemgrexParserTokenManager(SimpleCharStream stream)
		{
			input_stream = stream;
		}

		/// <summary>Constructor.</summary>
		public SemgrexParserTokenManager(SimpleCharStream stream, int lexState)
			: this(stream)
		{
			SwitchTo(lexState);
		}

		/// <summary>Reinitialise parser.</summary>
		public virtual void ReInit(SimpleCharStream stream)
		{
			jjmatchedPos = jjnewStateCnt = 0;
			curLexState = defaultLexState;
			input_stream = stream;
			ReInitRounds();
		}

		private void ReInitRounds()
		{
			int i;
			jjround = unchecked((int)(0x80000001));
			for (i = 19; i-- > 0; )
			{
				jjrounds[i] = unchecked((int)(0x80000000));
			}
		}

		/// <summary>Reinitialise parser.</summary>
		public virtual void ReInit(SimpleCharStream stream, int lexState)
		{
			ReInit(stream);
			SwitchTo(lexState);
		}

		/// <summary>Switch to specified lex state.</summary>
		public virtual void SwitchTo(int lexState)
		{
			if (lexState >= 1 || lexState < 0)
			{
				throw new TokenMgrError("Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.", TokenMgrError.InvalidLexicalState);
			}
			else
			{
				curLexState = lexState;
			}
		}

		protected internal virtual Token JjFillToken()
		{
			Token t;
			string curTokenImage;
			int beginLine;
			int endLine;
			int beginColumn;
			int endColumn;
			string im = jjstrLiteralImages[jjmatchedKind];
			curTokenImage = (im == null) ? input_stream.GetImage() : im;
			beginLine = input_stream.GetBeginLine();
			beginColumn = input_stream.GetBeginColumn();
			endLine = input_stream.GetEndLine();
			endColumn = input_stream.GetEndColumn();
			t = Token.NewToken(jjmatchedKind, curTokenImage);
			t.beginLine = beginLine;
			t.endLine = endLine;
			t.beginColumn = beginColumn;
			t.endColumn = endColumn;
			return t;
		}

		internal int curLexState = 0;

		internal int defaultLexState = 0;

		internal int jjnewStateCnt;

		internal int jjround;

		internal int jjmatchedPos;

		internal int jjmatchedKind;

		/// <summary>Get the next Token.</summary>
		public virtual Token GetNextToken()
		{
			Token matchedToken;
			int curPos = 0;
			for (; ; )
			{
				try
				{
					curChar = input_stream.BeginToken();
				}
				catch (IOException)
				{
					jjmatchedKind = 0;
					matchedToken = JjFillToken();
					return matchedToken;
				}
				try
				{
					input_stream.Backup(0);
					while (curChar <= 32 && (unchecked((long)(0x100002000L)) & (1L << curChar)) != 0L)
					{
						curChar = input_stream.BeginToken();
					}
				}
				catch (IOException)
				{
					goto EOFLoop_continue;
				}
				jjmatchedKind = unchecked((int)(0x7fffffff));
				jjmatchedPos = 0;
				curPos = JjMoveStringLiteralDfa0_0();
				if (jjmatchedKind != unchecked((int)(0x7fffffff)))
				{
					if (jjmatchedPos + 1 < curPos)
					{
						input_stream.Backup(curPos - jjmatchedPos - 1);
					}
					if ((jjtoToken[jjmatchedKind >> 6] & (1L << (jjmatchedKind & 0x3f))) != 0L)
					{
						matchedToken = JjFillToken();
						return matchedToken;
					}
					else
					{
						goto EOFLoop_continue;
					}
				}
				int error_line = input_stream.GetEndLine();
				int error_column = input_stream.GetEndColumn();
				string error_after = null;
				bool EOFSeen = false;
				try
				{
					input_stream.ReadChar();
					input_stream.Backup(1);
				}
				catch (IOException)
				{
					EOFSeen = true;
					error_after = curPos <= 1 ? string.Empty : input_stream.GetImage();
					if (curChar == '\n' || curChar == '\r')
					{
						error_line++;
						error_column = 0;
					}
					else
					{
						error_column++;
					}
				}
				if (!EOFSeen)
				{
					input_stream.Backup(1);
					error_after = curPos <= 1 ? string.Empty : input_stream.GetImage();
				}
				throw new TokenMgrError(EOFSeen, curLexState, error_line, error_column, error_after, curChar, TokenMgrError.LexicalError);
EOFLoop_continue: ;
			}
EOFLoop_break: ;
		}

		private void JjCheckNAdd(int state)
		{
			if (jjrounds[state] != jjround)
			{
				jjstateSet[jjnewStateCnt++] = state;
				jjrounds[state] = jjround;
			}
		}

		private void JjAddStates(int start, int end)
		{
			do
			{
				jjstateSet[jjnewStateCnt++] = jjnextStates[start];
			}
			while (start++ != end);
		}

		private void JjCheckNAddTwoStates(int state1, int state2)
		{
			JjCheckNAdd(state1);
			JjCheckNAdd(state2);
		}

		private void JjCheckNAddStates(int start, int end)
		{
			do
			{
				JjCheckNAdd(jjnextStates[start]);
			}
			while (start++ != end);
		}
	}
}
