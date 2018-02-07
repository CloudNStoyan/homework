using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
            //3 credit card numbers associated with the account.
            //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

            string person0HolderName = "Stoyan Antonov Kolev";
            int person0Money = 100000;
            string person0BankName = "Unicef Bulbank";
            string person0IBAN = "GB99 RBOS 1234 5612 3456 78";
            long person0CreditCardNumber0 = 1324521662131234;
            long person0CreditCardNumber1 = 1364521562132234;
            long person0CreditCardNumber2 = 1624221612131232;

            Console.WriteLine(person0HolderName);
            Console.WriteLine(person0Money);
            Console.WriteLine(person0BankName);
            Console.WriteLine(person0IBAN);
            Console.WriteLine(person0CreditCardNumber0);
            Console.WriteLine(person0CreditCardNumber1);
            Console.WriteLine(person0CreditCardNumber2);
        
        }
    }
}
