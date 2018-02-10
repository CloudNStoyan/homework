using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            if (companyName == "")
            {
                companyName = "(no company name)";
            }
            string companyAddress = Console.ReadLine();
            if (companyAddress == "")
            {
                companyAddress = "(no company address)";
            }
            string phoneNumber = Console.ReadLine();
            if (phoneNumber == "")
            {
                phoneNumber = "(no phone number)";
            }
            string faxNumber = Console.ReadLine();
            if (faxNumber == "")
            {
                faxNumber = "(no phone fax number)";
            }
            string webSite = Console.ReadLine();
            if (webSite == "")
            {
                webSite = "(no website)";
            }
            string managerFirstName = Console.ReadLine();
            if (managerFirstName == "")
            {
                managerFirstName = "(no manager first name)";
            }
            string managerLastName = Console.ReadLine();
            if (managerLastName == "")
            {
                managerLastName = "(no manager last name)";
            }
            string managerAge = Console.ReadLine();
            if (managerAge == "")
            {
                managerAge = "(no age)";
            }
            string managerPhone = Console.ReadLine();
            if (managerPhone == "")
            {
                managerPhone = "(no manager phone)";
            }
            
            
            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}",companyAddress);
            Console.WriteLine("Tel. {0}",phoneNumber);
            Console.WriteLine("Fax: {0}",faxNumber);
            Console.WriteLine("Web site: {0}",webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2},tel. {3})",managerFirstName,managerLastName,managerAge,managerPhone);


        }
    }
}
