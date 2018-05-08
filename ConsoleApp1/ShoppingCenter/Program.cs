using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter
{
    class Program
    {
        //PRODUCT
        static List<string> names = new List<string>();
        static List<decimal> prices = new List<decimal>();
        static List<string> producers = new List<string>();

        //Output
        static StringBuilder _output = new StringBuilder();



        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            int n = int.Parse(Console.ReadLine() + "");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string tag = input.Split(' ')[0];
                
                switch (tag)
                {
                    case "AddProduct":
                        AddProduct(input);
                        break;
                    case "DeleteProducts":
                        DeleteProducts(input);
                        break;
                    case "FindProductsByName":
                        FindProductsByName(input);
                        break;
                    case "FindProductsByPriceRange":
                        FindProductByPriceRange(input);
                        break;
                    case "FindProductsByProducer":
                        FindProductsByProducer(input);
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine(_output.ToString().Trim());
        }

        static void AddProduct(string input)
        {
            string info = input.Replace(input.Split(' ')[0],"").Trim();

            string name = info.Split(';')[0].Trim();
            decimal price = decimal.Parse(info.Split(';')[1]);
            string producer = info.Split(';')[2].Trim();

            names.Add(name);
            prices.Add(price);
            producers.Add(producer);

            _output.AppendLine("Product added");
        }

        static void DeleteProducts(string input)
        {
            input = input.Replace(input.Split(' ')[0], "").Trim();
            if (input.Contains(';'))
            {
                string name = input.Split(';')[0].Trim();
                string producer = input.Split(';')[1].Trim();

                int howMany = 0;

                for (int i = 0; i < names.Count; i++)
                {
                    string productName = names[i];
                    string productProducer = producers[i];

                    if (productName == name && productProducer == producer)
                    {
                        Delete(i);
                        howMany++;
                    }
                }

                _output.AppendLine(howMany > 0 ? $"{howMany} products deleted" : "No products found");
            }
            else
            {
                string producer = input;

                int howMany = 0;

                for (int i = 0; i < producers.Count; i++)
                {
                    string productProducer = producers[i];

                    if (productProducer == producer)
                    {
                        Delete(i);
                        i--;
                        howMany++;
                    }
                }

                _output.AppendLine(howMany > 0 ? $"{howMany} products deleted" : "No products found");
            }
        }

        static void FindProductsByName(string input)
        {
            input = input.Replace(input.Split(' ')[0], "").Trim();

            string name = input;
            var products = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                string productName = names[i];

                if (productName == name)
                {
                    string wrapp = '{' + $"{names[i]};{producers[i]};{prices[i]:F2}" + '}';
                    products.Add(wrapp);
                }
            }

            products.Sort();

            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    _output.AppendLine(products[i]);
                }
            }
            else
            {
                _output.AppendLine("No products found");
            }
        }

        static void FindProductByPriceRange(string input)
        {
            input = input.Replace(input.Split(' ')[0], "").Trim();
            var products = new List<string>();

            decimal min = decimal.Parse(input.Split(';')[0]);
            decimal max = decimal.Parse(input.Split(';')[1]);

            for (int i = 0; i < prices.Count; i++)
            {
                decimal productPrice = prices[i];
                if (productPrice >= min && productPrice <= max)
                {
                    string wrapp = '{' + $"{names[i]};{producers[i]};{prices[i]:F2}" + '}';
                    products.Add(wrapp);
                }
            }

            products.Sort();

            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    _output.AppendLine(products[i]);
                }
            }
            else
            {
                _output.AppendLine("No products found");
            }
        }

        static void FindProductsByProducer(string input)
        {
            input = input.Replace(input.Split(' ')[0], "").Trim();
            var products = new List<string>();

            string producer = input;

            for (int i = 0; i < producers.Count; i++)
            {
                string productProducer = producers[i];

                if (productProducer == producer)
                {
                    string wrapp = '{' + $"{names[i]};{producers[i]};{prices[i]:F2}" + '}';
                    products.Add(wrapp);
                }
            }

            products.Sort();

            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    _output.AppendLine(products[i]);
                }
            }
            else
            {
                _output.AppendLine("No products found");
            }
        }


        static void Delete(int index)
        {
            names.RemoveAt(index);
            prices.RemoveAt(index);
            producers.RemoveAt(index);
        }
    }
}
