using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    //// KONTROLLSTRUKTUREN
    public static class L3_Control_Structures
    {
        // Verzweigung

        public static string verzweigung(bool istWach, bool hatKaffee)
        {
            if (istWach && hatKaffee)
            {
                return "Ich bin wach und hab Kaffee.";
            }

            else if (istWach)
            {
                return "Ich bin wach.";
            }

            else
            {
                return "Ich bin nicht wach.";
            }
        }

        // Verschachtelte Verzweigung

        public static string verschachtelteVerzweigung(int x, int y, int z)
        {
            string result = "Wrong code.";
            if (x == 5)
            {
                if (y == 3)
                {
                    if (z == 0)
                    {
                        result = "The case has been unlocked.";
                    }
                }
            }
            return result;
        }

        // Fallauswahl
        public static string fallauswahl(int x)
        {
            switch (x)
            {
                case 0:
                    return "Null.";

                case 1:
                    return "Eins.";

                case 2:
                    return "Zwei.";

                default:
                    return "Nicht null, eins oder zwei.";

            }
        }

        // Schleifen
        public static void schleifen(bool istBereit)
        {

            //while (istBereit) // kopfgesteuerte Schleife
            //{
            //    return "Ich bin bereit!";
            //}

            //do // fußgesteuerte Schleife wird mindestens ein mal ausgeführt!
            //{
            //    return "Ich bin bereit!";

            //} while (istBereit) ;

            //for (int i = 0; i < 100; i++) // zählergesteuerte Schleife
            //{
            //    result += i;
            //}

            string[] myArray = { "Schere", "Stein", "Papier", "Brunnen" };

            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine($"Index: {j} - {myArray[j]}");
            }

            foreach (string element in myArray)
            {
                Console.WriteLine($"{element}");
            }
        }

        // Exception-Handling
        public static void exceptions()
        {
            try // Versucht die Ausführung des Try-Codeblocks
            {

                //int impossible = 0 / 0;

                int maskedZero = 0;
                int maskedImpossible = maskedZero / maskedZero;
            }
            catch (Exception)   // Sollte während der Ausführung des Try-Blocks ein Kompilierfehler
            {                   // auftreten, so wird dieser Anweisungsblock durchgeführt.
                                // statt den Benutzer mit dem Schließen des Programmes zu erschrecken,
                                // lässt sich so die Verhaltensweise des Programmes selbst bestimmen.

                Console.WriteLine("Geht nicht.");

                //throw;  // throw -> "schmeißt" Fehler
            }

            finally // nicht zwingend notwendig. Wird in jedem Fall am Ende ausgeführt.
            {
                Console.WriteLine("Danke für den Versuch...");
            }
        }
    }
}
