/*
 * Copyright 2004 The Apache Software Foundation
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
/* Generated By:JavaCC: Do not edit this line. StandardTokenizer.java */
using System;
namespace Monodoc.Lucene.Net.Analysis.Standard
{
	
	/// <summary>A grammar-based tokenizer constructed with JavaCC.
	/// 
	/// <p> This should be a good tokenizer for most European-language documents.
	/// 
	/// <p>Many applications have specific tokenizer needs.  If this tokenizer does
	/// not suit your application, please consider copying this source code
	/// directory to your project and maintaining your own grammar-based tokenizer.
	/// </summary>
	public class StandardTokenizer : Monodoc.Lucene.Net.Analysis.Tokenizer
	{
		
		/// <summary>Constructs a tokenizer for this Reader. </summary>
		public StandardTokenizer(System.IO.TextReader reader) : this(new FastCharStream(reader))
		{
			this.input = reader;
		}
		
		/// <summary>Returns the next token in the stream, or null at EOS.
		/// <p>The returned token's type is set to an element of {@link
		/// StandardTokenizerConstants#tokenImage}.
		/// </summary>
		public override Monodoc.Lucene.Net.Analysis.Token Next()
		{
			Token token = null;
			switch ((jj_ntk == - 1) ? Jj_ntk() : jj_ntk)
			{
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.ALPHANUM: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.ALPHANUM);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.APOSTROPHE: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.APOSTROPHE);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.ACRONYM: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.ACRONYM);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.COMPANY: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.COMPANY);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.EMAIL: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.EMAIL);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.HOST: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.HOST);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.NUM: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.NUM);
					break;
				
				case Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.CJK: 
					token = Jj_consume_token(Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.CJK);
					break;
				
				case 0: 
					token = Jj_consume_token(0);
					break;
				
				default: 
					jj_la1[0] = jj_gen;
					Jj_consume_token(- 1);
					throw new ParseException();
				
			}
			if (token.kind == Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.EOF)
			{
				{
					if (true)
						return null;
				}
			}
			else
			{
				{
					if (true)
						return new Monodoc.Lucene.Net.Analysis.Token(token.image, token.beginColumn, token.endColumn, Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.tokenImage[token.kind]);
				}
			}
			throw new System.ApplicationException("Missing return statement in function");
		}
		
		public StandardTokenizerTokenManager token_source;
		public Token token, jj_nt;
		private int jj_ntk;
		private int jj_gen;
		private int[] jj_la1 = new int[1];
		private static int[] jj_la1_0_Renamed_Field;
		private static void  jj_la1_0()
		{
			jj_la1_0_Renamed_Field = new int[]{0x10ff};
		}
		
		public StandardTokenizer(CharStream stream)
		{
			token_source = new StandardTokenizerTokenManager(stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 1; i++)
				jj_la1[i] = -1;
		}
		
		public virtual void  ReInit(CharStream stream)
		{
			token_source.ReInit(stream);
			token = new Token();
			jj_ntk = -1;
			jj_gen = 0;
			for (int i = 0; i < 1; i++)
				jj_la1[i] = -1;
		}
		
		public StandardTokenizer(StandardTokenizerTokenManager tm)
		{
			token_source = tm;
			token = new Token();
			jj_ntk = - 1;
			jj_gen = 0;
			for (int i = 0; i < 1; i++)
				jj_la1[i] = - 1;
		}
		
		public virtual void  ReInit(StandardTokenizerTokenManager tm)
		{
			token_source = tm;
			token = new Token();
			jj_ntk = - 1;
			jj_gen = 0;
			for (int i = 0; i < 1; i++)
				jj_la1[i] = - 1;
		}
		
		private Token Jj_consume_token(int kind)
		{
			Token oldToken = token;
			if (oldToken.next != null)
				token = token.next;
			else
				token = token.next = token_source.GetNextToken();
			jj_ntk = - 1;
			if (token.kind == kind)
			{
				jj_gen++;
				return token;
			}
			token = oldToken;
			jj_kind = kind;
			throw GenerateParseException();
		}
		
		public Token GetNextToken()
		{
			if (token.next != null)
				token = token.next;
			else
				token = token.next = token_source.GetNextToken();
			jj_ntk = - 1;
			jj_gen++;
			return token;
		}
		
		public Token GetToken(int index)
		{
			Token t = token;
			for (int i = 0; i < index; i++)
			{
				if (t.next != null)
					t = t.next;
				else
					t = t.next = token_source.GetNextToken();
			}
			return t;
		}
		
		private int Jj_ntk()
		{
			if ((jj_nt = token.next) == null)
				return (jj_ntk = (token.next = token_source.GetNextToken()).kind);
			else
				return (jj_ntk = jj_nt.kind);
		}
		
		private System.Collections.ArrayList jj_expentries = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
		private int[] jj_expentry;
		private int jj_kind = - 1;
		
		public virtual ParseException GenerateParseException()
		{
			jj_expentries.Clear();
			bool[] la1tokens = new bool[15];
			for (int i = 0; i < 15; i++)
			{
				la1tokens[i] = false;
			}
			if (jj_kind >= 0)
			{
				la1tokens[jj_kind] = true;
				jj_kind = - 1;
			}
			for (int i = 0; i < 1; i++)
			{
				if (jj_la1[i] == jj_gen)
				{
					for (int j = 0; j < 32; j++)
					{
						if ((jj_la1_0_Renamed_Field[i] & (1 << j)) != 0)
						{
							la1tokens[j] = true;
						}
					}
				}
			}
			for (int i = 0; i < 15; i++)
			{
				if (la1tokens[i])
				{
					jj_expentry = new int[1];
					jj_expentry[0] = i;
					jj_expentries.Add(jj_expentry);
				}
			}
			int[][] exptokseq = new int[jj_expentries.Count][];
			for (int i = 0; i < jj_expentries.Count; i++)
			{
				exptokseq[i] = (int[]) jj_expentries[i];
			}
			return new ParseException(token, exptokseq, Monodoc.Lucene.Net.Analysis.Standard.StandardTokenizerConstants.tokenImage);
		}
		
		public void  Enable_tracing()
		{
		}
		
		public void  Disable_tracing()
		{
		}
		static StandardTokenizer()
		{
			{
				jj_la1_0();
			}
		}
	}
}
