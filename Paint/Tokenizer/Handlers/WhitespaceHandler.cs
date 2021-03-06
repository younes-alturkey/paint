/*
 * Tuwaiq .NET Bootcamp | Paint
 * 
 * Team Members
 * 
 * Abdulrahman Bin Maneea
 * Younes Alturkey
 * Anas Alhmoud
 * Faisal Alsagri
 * 
 */
using System;

namespace Paint.Tokenizer
{
	public class WhitespaceHandler : Tokenizable
	{
		public override bool tokenizable(Input input)
		{
			return Char.IsWhiteSpace(input.peek());
		}

		static bool isWhiteSpace(Input input)
		{
			char currentCharacter = input.peek();
			return Char.IsWhiteSpace(currentCharacter) || isNewLine(currentCharacter) || isTab(currentCharacter) || isCarriageReturn(currentCharacter);
		}

		static bool isNewLine(char c)
		{
			return c == '\n';
		}

		static bool isTab(char c)
		{
			return c == '\t';
		}

		static bool isCarriageReturn(char c)
		{
			return c == '\r';
		}

		public override Token tokenize(Input input)
		{
			return new Token(input.Position, input.LineNumber, TokenType.Whitespace, input.loop(isWhiteSpace));
		}
	}
}