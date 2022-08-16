using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class program
    {
        public  static List<Product> products = new List<Product>();
        static void Main()
        {
            char process = 'Y';
            while (process == 'Y')
            {
                Menu();
                int Userchoice = int.Parse(Console.ReadLine());
                
                if (Userchoice == 1)
                {
                    Product product1 = new Product();
                    Console.WriteLine("Your choice is Add product ");
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    product1.Productname = name;

                    Console.WriteLine("Enter product price : ");
                    double price = double.Parse(Console.ReadLine());
                    product1.Productprice = price;
                    products.Add(product1);
                    Console.WriteLine("Add product successfully.");
                    information();
                    Console.WriteLine("Product name = {0} \nProduct Price = {1}", product1.Productname, product1.Productprice, "\nThank You for Add product.");
                }

                else if (Userchoice == 2)
                {
                    Console.WriteLine("Your choice is Remove product ");
                    Console.WriteLine("Enter product name: ");
                    string name = (Console.ReadLine());
                    RemoveProduct(name);
                }

                else if (Userchoice == 3)
                {
                    Console.WriteLine("Your choice is Update product");
                    Console.WriteLine("Enter product name :");
                    //  Console.WriteLine("Enter product price :", products);

                    string name = (Console.ReadLine());

                    UpdateProduct(name);
                    Console.ReadLine();
                }

                else if (Userchoice == 4)
                {
                    Console.WriteLine("Your choice is View");
                    Console.WriteLine("product name           product price ");
                    Console.WriteLine("------------------------------------");
                    foreach (var product in products)
                    {
                        Console.WriteLine((product.Productname + "                     " + product.Productprice));
                    }
                    Console.WriteLine();
                    information();
                }

                else if (Userchoice == 5)
                {
                    Console.WriteLine("Your choice is exit");
                    information();
                    Console.Clear();
                }

                do
                {
                    process = Process();
                    Console.WriteLine();
                    if (process != 'Y' && process != 'N')
                    {
                        Console.WriteLine("please enter valid choice.");
                    }
                }
                while (process != 'Y' && process != 'N');
                Console.WriteLine();
                Console.ReadLine();

            }

        }
        public static void information()
        {
            Console.WriteLine("Thank you for visit!! \nHave a grate day");
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Enter your choice.");
            Console.WriteLine(" 1.Add product \n 2.Remove product \n 3.Update program \n 4.View product \n 5.Exit ");
            Console.WriteLine("Please select your choice (1:5) : ");
        }
        public static char Process()
        {
            Console.WriteLine("Do you want to continye YES (Y) or NO (N)");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        public static void UpdateProduct(string name)
        {
            int updateCount = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (name == products[i].Productname)
                {
                    Console.WriteLine("Enter product price :");
                    double price = double.Parse(Console.ReadLine());
                    products[i].Productprice = price;
                    updateCount++;
                }
            }
            if (updateCount != 0)
            {
                Console.WriteLine("product update successfully.");
            }
            else
            {
                Console.WriteLine(name + " Product not found");
            }
        }
        public static void RemoveProduct(string name)
        {
            int removeCount = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (name == products[i].Productname)
                {
                    products.RemoveAt(i);
                    removeCount++;
                }
            }
            if (removeCount != 0)
            {
                Console.WriteLine("Remove product successfully.");
            }
            else
            {
                Console.WriteLine(name + " Product not found");
            }
        }


    }




}
