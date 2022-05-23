using System;
using System.Collections;


namespace Poquer
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                Console.Write("Enter the left hand: ");
                string leftHand = Console.ReadLine();
                Console.Write("Enter the right hand: ");
                string rightHand = Console.ReadLine();


                string[] left = leftHand.Split(" ");
                string[] right = rightHand.Split(" ");

                Array.Sort(left);
                int tam = left[0].Length;
                Console.WriteLine(left[0].Substring(tam - 1));

                string win = Calc.calcula(left, right);

            }


        }
    }
}
