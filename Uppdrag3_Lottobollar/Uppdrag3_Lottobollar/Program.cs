using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppdrag3_Lottobollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int slump = random.Next(0, 21);


            int[] chosenBalls = new int[10];


            Console.WriteLine("Välkommen till Lotto!");
            Console.WriteLine("Ange 10 valfria nummer mellan 1 och 20 som kommer vara dina lottonummer.");



            for (int i = 0; i < chosenBalls.Length; i++)
            {
                Console.WriteLine("Vänligen skriv in ett nummer: ");
                chosenBalls[i] = Convert.ToInt32(Console.ReadLine());

                if (chosenBalls[i] <1 || chosenBalls[i] >20)
                {
                    Console.WriteLine("Du kan bara ange nummer mellan 1 och 20, försök igen!");
                }
            }

            Console.WriteLine("Detta är dina valda nummer: ");

            foreach (var number in chosenBalls)
            {
                Console.WriteLine(number);
            }

            bool jackpot = false;
            Console.WriteLine("LÅT SPELET BÖRJA!");

            foreach (var number in chosenBalls)
            {
                if (number == slump)
                {
                    jackpot = true;
                }
            }

            if (jackpot)
            {
                Console.WriteLine("Gratulerar! Du vann på Lotto!");
            }
            else
            {
                Console.WriteLine("Tyvärr...ingen vinst denna gången.");
            }



        }

    }
}
