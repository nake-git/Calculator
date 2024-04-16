using System;

namespace Calculator
{

    /*
     * Programme bestehen generell aus drei Teilen:
     *  - Dateneingabe
     *  - Datenverarbeitung
     *  - Datenausgabe / Visualisierung / Datenspeicherung.
     *  
     * Teile das unten stehende Programm in diese drei Teile mittels 
     * Funktionen/Methoden ein.
     *  
     * Dabei soll die Main-Funktion als Steuerzentrale fungieren, die 
     * Funktionen/Methoden zum Daten einlesen, konvertieren, verarbeiten 
     * und ausgeben aufruft und die jeweiligen Rückgabeparameter weitergibt.
     *  
     * Besondere Herausforderung: 
     *      Für die Konsolenausgabe der Ergebnise soll nur eine Funktion 
     *      verwendet werden. Der Inhalt der jeweiligen Zeilen bleibt gleich.
     * 
     * Bedenke: Jede Funktion bearbeitet nur eine (!) Aufgabe bzw. Teilaufgabe.
     * 
     * Zeit: 1 - 2 Blöcke
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            try
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

                    if (var3.Contains("j"))
                    {
                        isRunning = false;
                    }

                    Console.WriteLine();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
