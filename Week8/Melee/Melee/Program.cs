using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melee
{
    class Program
    {


        static void Main(string[] args)
        {
            bool home = true;
            while (home)
            Console.WriteLine("Choose Weapon");
            Console.WriteLine("1. Melee");
            Console.WriteLine("1. Ranged");
            string Option = Console.ReadLine();



            switch (Option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter amout of Attacks");
                        int amounts = int.Parse(Console.ReadLine());
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Enter amout of Attacks");
                        int amounts = int.Parse(Console.ReadLine());
                        break;
                    }

                case 3:
                    {
                        home = false;
                        break;
                    }


            }
        }
    }
              


            


