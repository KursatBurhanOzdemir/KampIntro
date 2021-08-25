using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //farklı kullanım şekli 
            Product product2 = new Product { Id = 2, ProductName = "kalem", UnitsInStock = 5, UnitPrice = 35,CategoryId=5};
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

 
            
            
            
            
            //productManager.Topla(3, 6);
            //int toplamSonucu = productManager.Topla(3,6);
            //Console.WriteLine(toplamSonucu * 2);


        }
    }
}
