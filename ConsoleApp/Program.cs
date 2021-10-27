using ConsoleApp.Extensions;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---MD5---");
            string text = "Azerbaijan";
            string chiperText = text.ToMD5();
            Console.WriteLine(chiperText);

            //Encrypt
            Console.WriteLine("---Encrypt---");
            string encrypted = text.Encrypt();
            Console.WriteLine(encrypted);
            //Encrypt

            //Decrypt
            Console.WriteLine("---Decrypt---");
            string decrypted = encrypted.Decrypt();
            Console.WriteLine(decrypted);
            //Decrypt

            Console.ReadKey();
        }
    }
}
