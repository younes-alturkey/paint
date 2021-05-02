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
using System;using Paint.Tokenizer;

namespace Paint.Parser
{
	public class JString : Value
	{
		Token token;
		public JString(Token token)
		{
			this.token = token;
		}

		public override JString getString()
		{
			return this;
		}

		public override string ToString()
		{
			return token.Value;
		}

		public override JSONMemberType getType()
		{
			return JSONMemberType.String;
		}

		public override string Indent(uint indentation = 0)
		{
			return this.ToString();
		}

		public override Value ConsoleColorization(int indentation = 0)
		{
			Console.ResetColor();
			Console.Write('"');
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(this.ToString().Trim('"'));
			Console.ResetColor();
			Console.Write('"');
			return this;
		}
	}
}