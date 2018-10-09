using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAAssignment2
{
    public static class TriangleSolver
    {


        public static string Analyze(int side1, int side2, int side3)
        {
            string output = string.Empty;



            if (IsValidSide(side1) && IsValidSide(side2) && IsValidSide(side3))
            {
                if ((side1 + side2 > side3) && (side3 + side2 > side1) && (side1 + side3 > side2))
                {
                    if ((side1 == side2) && (side2 == side3))
                    {
                        output = "Equilateral";
                    }
                    else if ((side1 != side2) && (side2 != side3) && (side3 != side1))
                    {
                        output = "Scalene";
                    }
                }
                else
                {
                    output = "Not a Triangle";
                }
            }
            else
            {
                output = "Not a Triangle";
            }
            return output;
        }


        private static bool IsValidSide(int side)
        {
            if (side <= 0)
            {
                Console.WriteLine("Unvalid value for side");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}