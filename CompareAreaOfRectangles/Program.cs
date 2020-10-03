using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAreaOfRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rectangle1 = new Rectangle();
            Rectangle Rectangle2 = new Rectangle();

            Rectangle1.GetWidth();
            Rectangle1.GetLength();
            Rectangle1.CalculateArea();

            Rectangle2.GetWidth();
            Rectangle2.GetLength();
            Rectangle2.CalculateArea();

            if(Rectangle1.area > Rectangle2.area)
            {
                Console.WriteLine("Rectangle 1 is bigger");
            }else if (Rectangle1.area < Rectangle2.area)
            {
                Console.WriteLine("Rectangle 2 is bigger");
            }
            else
            {
                Console.WriteLine("The rectangles are the same size");
            }

            Console.ReadLine();
        }
    }
}
