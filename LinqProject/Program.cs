using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="MSI Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=12560,UnitInStock=10},
                new Product{ProductId=2, CategoryId=1, ProductName="Lenovo Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=8060,UnitInStock=7},
                new Product{ProductId=3, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=5000,UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=3500,UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=8000,UnitInStock=0},
            };

            Console.WriteLine("-----LINQ Yapısı Olmadan-----");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 5)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("-----LINQ Yapısı İle-----");

            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitInStock>5);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            
        }

        //LINQ yapısını kullanadan fonksiyon yazalırsa...
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 500 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        //LINQ yapısı ile filtreleme yapılırsa.
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3).ToList();
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}


