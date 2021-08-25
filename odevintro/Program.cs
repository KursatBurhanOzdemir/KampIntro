using System;

namespace odevintro
{
    class Program
    {
        static void Main(string[] args)
        {

            product product1 = new product();
            product1.telefon = " ıphon5s ";
            product1.laptop = " applelaptop ";
            product1.tablet = " appletablet ";

            product product2 = new product();
            product2.telefon = " lenovotelefon ";
            product2.laptop = " lenovolaptop ";
            product2.tablet = " lenovotablet ";

            product product3 = new product();
            product3.telefon = " samsungtelefon ";
            product3.laptop = " samsunglaptop ";
            product3.tablet = " samsungtablet ";



            product[] products = new product[]
            {
               product1, product2, product3
            };
            foreach (var product in products)
            {
                Console.WriteLine(product.telefon + product.tablet + product.laptop);
            }
        }
    }

    class product
    {
        public string telefon { get; set; }
        public string laptop { get; set; }
        public string tablet{ get; set; }
    }
}
