using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string key = Console.ReadLine();
            Console.WriteLine("Encryption: {0}", Encrypt(word, key));
            Console.WriteLine("Decryption: {0}", Decrypt(Encrypt(word, key),key));
        }

        static string Encrypt(string word, string key)
        {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
                cipher.Append((char)(word[i] ^ key[i % key.Length]));
            return cipher.ToString();
        }

        static string Decrypt(string word, string key)
        {
            return Encrypt(word, key);
        }
    }
}
