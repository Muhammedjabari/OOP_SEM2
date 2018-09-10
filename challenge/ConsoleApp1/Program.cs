using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            bool home = true;
            while(home)
            Console.WriteLine("Welcome, please enter number to select from menu.");
            Console.WriteLine("");
            Console.WriteLine("1. Area of a Sqaure");
            Console.WriteLine("2. Area of a Reqtangle");
            Console.WriteLine("");
            string Option = Console.ReadLine();

            try
            {


                if (Option == "1")
                {
                    Console.WriteLine("Enter color");
                    string color = Console.ReadLine();
                    Console.WriteLine("Enter Length");
                    float Side1Length = float.Parse(Console.ReadLine());
                    Square square = new Square(color,Side1Length);
                    

                    if (Side1Length <= 0)
                    {
                        throw new ZeroException();
                    }
                    Console.WriteLine(square.GetArea());

                }
                if (Option == "2")
                {
                    Console.WriteLine("Enter color");
                    string color = Console.ReadLine();
                    Console.WriteLine("Enter Length");
                    float Side1Length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width");
                    float Side2Length = float.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(color, Side1Length, Side2Length);
                    

                    if (Side1Length <= 0)
                    {
                        throw new ZeroException();
                    }
                    if (Side2Length <= 0)
                    {
                        throw new ZeroException();
                    }
                    Console.WriteLine(rectangle.GetArea());


                }


               

            }
            catch (ZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            } 
            Console.ReadLine();
        }

        public class ZeroException : Exception
        {
            public ZeroException() : base("Number must be greater than 0 ")
            {
                

            }

        }



    }
}

