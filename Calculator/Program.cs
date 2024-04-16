using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Gib eine Zahl ein!");
                string var1 = Console.ReadLine();
                Console.WriteLine("Gib eine weitere Zahl ein!");
                string var2 = Console.ReadLine();

                bool parseStat1 = float.TryParse(var1, out float nVar1);
                bool parseStat2 = float.TryParse(var2, out float nVar2);

                if (!parseStat1 || !parseStat2)
                {
                    Console.WriteLine("Die Eingabe enthielt Fehler. Bitte versuch es noch einmal.");
                    continue;
                }

                float sum = nVar1 + nVar2;
                Console.WriteLine("Die Summe von {0} + {1} = {2}", nVar1, nVar2, sum);
                float diff = nVar1 - nVar2;
                Console.WriteLine("Die Summe von {0} - {1} = {2}", nVar1, nVar2, diff);
                float prod = nVar1 * nVar2;
                Console.WriteLine("Die Summe von {0} * {1} = {2}", nVar1, nVar2, prod);
                float quot = nVar1 / nVar2;
                Console.WriteLine("Die Summe von {0} / {1} = {2}", nVar1, nVar2, quot);
                float mod = nVar1 % nVar2;
                Console.WriteLine("Die Summe von {0} % {1} = {2}", nVar1, nVar2, mod);


                Console.WriteLine("Soll das Programm beendet werden (j/n)?");
                var var3 = Console.ReadKey().KeyChar.ToString();
                
                if(var3.Contains("j"))
                {
                    isRunning = false;
                }
                
                Console.WriteLine();

            }
        }
    }
}
