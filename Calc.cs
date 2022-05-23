using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poquer
{
    class Calc
    {
        public static string calcula(string[] leftH, string[] rightH)
        {
            string[] leftT = new string[5];
            string[] rightT = new string[5];
            int tam = 0;

            for (int i = 0; i < 5; i++)  // leftH and rightH has a card number, leftT and rightT has a card suit
            {
                tam = leftH[i].Length;
                leftT[i] = leftH[i].Substring(tam - 1);
                leftH[i] = leftH[i].Substring(0, tam - 1);
                tam = rightH[i].Length;
                rightT[i] = rightH[i].Substring(tam - 1);
                rightH[i] = rightH[i].Substring(0, tam - 1);
            }



            for (int conta = 0; conta < leftH.Length; conta++)
            {
                switch (leftH[conta])
                {
                    case "J":
                        leftH[conta] = "11";
                        break;

                    case "Q":
                        leftH[conta] = "12";
                        break;

                    case "K":
                        leftH[conta] = "13";
                        break;

                    case "A":
                        leftH[conta] = "14";
                        break;

                }
            }

            for (int conta = 0; conta < rightH.Length; conta++)
            {
                switch (rightH[conta])
                {
                    case "J":
                        rightH[conta] = "11";
                        break;

                    case "Q":
                        rightH[conta] = "12";
                        break;

                    case "K":
                        rightH[conta] = "13";
                        break;

                    case "A":
                        rightH[conta] = "14";
                        break;

                }
            }


            Array.Sort(leftH, leftT);
            Array.Sort(rightH, rightT);

            //  The cards suits are S (spades), C (clubs), H (hearts), and D (diamonds).

            return "xxxx";
        }
    }
}