using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Product
    {
        public Product(double height, double width, double weight)
        {
            Height = 4;
            Width = 2;
            Weight = 6;
            Console.WriteLine($"Created product with parametrs {height} {width} {weight}");
               
        }
        public double Height { get; } 


        public double Width { get; }
        public double Weight { get; }


    }
}
