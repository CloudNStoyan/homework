using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program for extracting all email addresses from given text. All sub-strings that match the format 
            //<identifier>@<host>…<domain> should be recognized as emails.

            string[] text = Console.ReadLine()
                .Split(new string[] {" ", ";", ",", ". "}, StringSplitOptions.RemoveEmptyEntries);
            string[] emails = Array.FindAll<string>(text, IsValid);

            foreach (string email in emails)
            {
                Console.WriteLine("- {0}",email);
            }
        }

        static bool IsValid(string email)
        {
            if (email.Contains("@"))
            {
                int index = email.IndexOf("@");
                if (index <= 2)
                {
                    return false;
                }
                else
                {
                    if (email.Length - index <= 2)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
