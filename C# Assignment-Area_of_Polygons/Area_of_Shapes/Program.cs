using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Shapes
{
    class Area_of_shapes
    {
        string shape;
        float side, radius, breadth, length;
        public Area_of_shapes()
        {
            Console.WriteLine("Enter the shape");
            shape = Console.ReadLine().ToLower();
            switch (shape)
            {
                case "rectangle":
                    {
                        Console.WriteLine("Enter length and breadth of rectangle");
                        length = float.Parse(Console.ReadLine());
                        breadth = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of rectangle={0}", length * breadth);
                        break;
                    }

                case "triangle":
                    {
                        Console.WriteLine("Enter the height and base of triangle");
                        length = float.Parse(Console.ReadLine());
                        breadth = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle={0}", (1 / 2) * length * breadth);
                        break;
                    }
                case "circle":
                    {
                        Console.WriteLine("Enter the radius of circle");
                        radius = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of circle={0}", Math.PI * radius * radius);
                        break;
                    }
                case "square":
                    {
                        Console.WriteLine("Enter the side of square");
                        side = float.Parse(Console.ReadLine());
                        Console.WriteLine("Area of square={0}", side * side);
                        break;
                    }
                default:
                    Console.WriteLine("Entered shape is not a valid type");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Area_of_shapes Area_of_Shapes = new Area_of_shapes();
            Console.ReadLine();

        }
    }
}
