using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductId = 111;
            ProductName = "Mobile";
            ProductPrice = 16000;
        }
        public static void getProductDetails()
        {
            Console.WriteLine("Product id={0}", ProductId);
            Console.WriteLine("Product Name={0}", ProductName);
            Console.WriteLine("Product Price ={0}", ProductPrice);


        }
        public static void getDisCount()
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("You discount amount is:{0}", d_amount);
            Console.WriteLine("Total cost of product is:{0}", (ProductPrice - d_amount));

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product.getProductDetails();
            Product.getDisCount();
            Console.ReadLine();
        }
    }
}
