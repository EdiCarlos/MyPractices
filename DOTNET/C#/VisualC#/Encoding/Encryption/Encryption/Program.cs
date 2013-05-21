using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write("Usage: GenerationofTokens string Flag, string plaintext");
                return;
            }
            Console.WriteLine(EncodeString(args[1]));
        }
        static String EncodeString(string Plaintext)
        {
            int length, i, j;
            String Token;
            Token = null;
            i = 0;
            length = Plaintext.Length;
            Random rnd = new Random();
            for (i = 0; i <= length; i++)
            {
                for (j = 0; j <= length + i; j++)
                {
                    Token = Token + Convert.ToChar(Convert.ToInt32(rnd.Next(32, 127)));
                }
                try
                {
                    if (i < length)
                    {
                        Token += Plaintext[i];
                    }
                }
                catch (IndexOutOfRangeException index)
                {
                }
            }
            return ReverseString(Token);    //return Token;//Array.Reverse(Token.ToCharArray());
        }
        private static string ReverseString(String Token)
        {
            char[] charStr = Token.ToCharArray();
            Array.Reverse(charStr);
            return new string(charStr);
        }
    }
}
