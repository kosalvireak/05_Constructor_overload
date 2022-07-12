using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_Example_Constructor_overloading_
{
    class Book
    {
        private string strTitle;
        public string Title //a
        {
            get { return strTitle; } //b
            set { strTitle = value; }
        }
        private float fltPrice;
        public float Price
        {
            get { return fltPrice; }
            set { fltPrice = value; }
        }
        public Book()  //empty constructor
        {

        }
        public Book(string strTitle, float fltPrice) //constructor take 2 parameters
        {
            this.strTitle = strTitle;
            this.fltPrice = fltPrice;
        }
        public Book(string str)
        {
            this.strTitle=str;
            this.fltPrice = 2f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1 = new Book();  //declare objects
            Book objBook2,objBook3 ;
            Console.Write("Enter the title of book 1: ");
            string titleb1 = Console.ReadLine();
            Console.Write("Enter the price of book 1: ");
            float priceb1 = float.Parse(Console.ReadLine());
            objBook1.Title = titleb1;
            objBook1.Price = priceb1;
            Console.Write("Enter the title of book 2: ");
            string titleb2 = Console.ReadLine();
            Console.Write("Enter the price of book 2: ");
            float priceb2 = float.Parse(Console.ReadLine());
            objBook2 = new Book(titleb2, priceb2);

            Console.Write("Enter the title of book 3: ");
            string titleb3 = Console.ReadLine();
            objBook3 = new Book(titleb3);

            Console.WriteLine("Book 1 Title: {0} Price: {1}",objBook1.Title, objBook1.Price);
            Console.WriteLine("Book 2 Title: {0} Price: {1}", objBook2.Title, objBook2.Price);
            Console.WriteLine("Book 3 Title: {0} Price: {1}", objBook3.Title, objBook3.Price);

        }
    }
}
