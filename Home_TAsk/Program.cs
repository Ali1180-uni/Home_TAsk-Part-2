using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home_TAsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Library book = new Library();
                Employee one = new Employee();
                Console.WriteLine("\t------------------");
                Console.WriteLine("\t||     MENU     ||");
                Console.WriteLine("\t------------------");
                Console.WriteLine("Please Select Option (1-2) or Press 0 to Exit \n 1. Library Managment\n 2. Employee Managment");
                int sel;
                try
                {
                    sel = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Please enter a number.");
                    continue;
                }
                if (sel == 0)
                {
                    Console.WriteLine("Exited!");
                    break;
                }
                switch (sel)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Option 1 selected.");
                        while (true)
                        {
                            Console.WriteLine("\t------------------");
                            Console.WriteLine("\t||     MENU     ||");
                            Console.WriteLine("\t------------------");
                            Console.WriteLine("1. Input\n2. Display\n3. Discount\n0. Exit");
                            int seli;
                            try
                            {
                                seli = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Input! Please enter a number.");
                                continue;
                            }
                            if (seli == 0)
                            {
                                Console.WriteLine("Exited!");
                                break;
                            }
                            switch (seli)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Option 1 selected.");
                                    book.input();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Option 2 selected.");
                                    book.display();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Option 2 selected.");
                                    Console.WriteLine("Enter The Discount You want: ");
                                    double Discount = Convert.ToDouble(Console.ReadLine());
                                    book.discount(Discount / 100);
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input! Please enter a number between 0-3.");
                                    break;
                            }

                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Option 2 selected.");
                        while (true)
                        {
                            Console.WriteLine("\t------------------");
                            Console.WriteLine("\t||     MENU     ||");
                            Console.WriteLine("\t------------------");
                            Console.WriteLine("1. Display\n2. Addition\n0. Exit");
                            int seli;
                            try
                            {
                                seli = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Input! Please enter a number.");
                                continue;
                            }
                            if (seli == 0)
                            {
                                Console.WriteLine("Exited!");
                                break;
                            }
                            switch (seli)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Option 2 selected.");
                                    one.display();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Option 2 selected.");
                                    Console.WriteLine("Enter The Increment You want: ");
                                    double incre = Convert.ToDouble(Console.ReadLine());
                                    one.Increment(incre);
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Invalid Input! Please enter a number between 0-2.");
                                    break;
                            }

                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input! Please enter a number between 0-2.");
                        break;
                }

            }
        }
    }
}
