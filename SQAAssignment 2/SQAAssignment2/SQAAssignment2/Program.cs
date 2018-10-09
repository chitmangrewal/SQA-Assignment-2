using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string side1, side2, side3;
            string value = string.Empty;


            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {



                Console.WriteLine("Press 1 Enter triangle dimensions");
                Console.WriteLine("Press 2 Exit");

                value = Console.ReadLine();

                //switch statement 

                switch (value)
                {
                    case "1":

                        
                        Console.WriteLine("Please enter three values to know the type of triangle");


                        Console.WriteLine("");
                        bool isNum;
                        do
                        {
                            side1 = Console.ReadLine();

                            isNum = int.TryParse(side1, out a);
                        } while (!(isNum));

                        do


                        {
                            side2 = Console.ReadLine();
                            isNum = int.TryParse(side2, out b);
                        } while (!(isNum));
                        do
                        {

                            side3 = Console.ReadLine();
                            isNum = int.TryParse(side3, out c);
                        } while (!(isNum));


                        if ((a <= 0) && (b <= 0) && (c <= 0) && (float.IsNaN(a) && (float.IsNaN(b) && (float.IsNaN(c)))))
                        {
                            Console.WriteLine("Unvalid input, Enter valid input");

                        }

                        else
                        {
                            Console.WriteLine($"Entered input is: {TriangleSolver.Analyze(int.Parse(side1), int.Parse(side2), int.Parse(side3))}");
                        }


                        break;
                    case "2":
                        {
                            System.Environment.Exit(0);
                            break;
                        }

                    default:
                        Console.WriteLine("Enter the valid option");
                        break;
                }



            }

        }
    }
}


