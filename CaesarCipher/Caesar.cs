using System;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace CaesarCipher
{
    public class Caesar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write shift for caesar cipher:");
            string shiftS = Console.ReadLine();
            Console.WriteLine("Write text:");
            string text = Console.ReadLine();
            bool isNumber = int.TryParse(shiftS, out int shift);
            if (!isNumber)
            {
                Console.WriteLine("Shift is not a number");
                return;
            }
            string encrypted = Encrypt(shift, text);
            string decrypted = Decrypt(shift, encrypted);

            Console.WriteLine("Encrypted: " + encrypted);
            Console.WriteLine("Decrypted: " + decrypted);

        }

        public static string Encrypt(int shift, string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    result += Convert.ToChar(text[i] + shift);

                }
                else result += Convert.ToChar(text[i]);
            }
            return result;
        }

        public static string Decrypt(int shift, string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    result += Convert.ToChar(text[i] - shift);

                }
                else result += Convert.ToChar(text[i]);
            }
            return result;
        }
    }
}
