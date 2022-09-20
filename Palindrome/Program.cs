using System;

namespace Palindrome
{
    class Program
    {
        /// <summary>
        // Schreiben Sie eine Funktion int palin(string satz), die prüfen soll, ob ein gegebenes Wort oder ein Satz ein Palindrom ist. 
        //Groß-/Kleinschreibung soll dabei keine Rolle spielen.
        //(Ein Palindrom ist eine Zeichenkette, die „von hinten“ und „von vorne“ gelesen gleich aussieht.Beispiele: Otto; Erika feuert nur untreue Fakire)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Wir erstellen eine logische und eine string Variable und geben wir eine wort ein
            bool palindrome = true;
            string pali;
            Console.WriteLine("Gib ein Palindrome Wort oder Satz: ");
            pali = Console.ReadLine();


            //Die schleife hat ifAnweisung die prüft ob erte Buchstabe ist nicht gleich letzte Buchstabe. 
            //Und bei zweite Durchlauf die prüft ob zweite Buchstabe nicht gleich ist vorletzte Buchstabe, und so weiter
            for (int i = 0; i < pali.Length; i++)
            {
                if (pali[i] != pali[pali.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome == true)
            {
                Console.WriteLine("Das wort ist Palindrome");
            }
            else
            {
                Console.WriteLine("Das ist kein Palindrome");
            }



            Console.WriteLine();
            Console.ReadKey();






        }
    
    }
}
