using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_TAsk
{
    internal class Library
    {
        public string Title;
        public string Auther;
        public int ISBN;
        public double price;

        public void input()
        {
            Console.WriteLine("Please Enter the Title of Book: ");
            Title = Console.ReadLine();
            Console.WriteLine("Please Enter the Author of Book: ");
            Auther = Console.ReadLine();
            Console.WriteLine("Please Enter the ISBN of Book: ");
            ISBN=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Price of Book: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("The Title of Book is: {0}", Title);
            Console.WriteLine("The Author of Book is: {0}", Auther);
            Console.WriteLine("The ISBN of Book is: {0}", ISBN);
            Console.WriteLine("The Price of Book is: {0}", price);
        }

        public void discount(double per)
        {
            price *= per;
            Console.WriteLine("Now the discounted Price on the book {0} is: {1}", Title, price);
        }
    }
}
