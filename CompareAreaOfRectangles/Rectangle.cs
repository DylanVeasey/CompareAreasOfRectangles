using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAreaOfRectangles
{
    class Rectangle
    {
        public int width;
        public int length;
        public int area;

        public void GetWidth()
        {
            Console.WriteLine("What is the width of the rectangle?:");
            width = Int32.Parse(Console.ReadLine());
        }
        public void GetLength()
        {
            Console.WriteLine("What is the length of the rectangle?:");
            length = Int32.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = width * length;
        }
    }
}
