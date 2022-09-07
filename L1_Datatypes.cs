using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    //// DATENTYPEN
    public static class L1_Datatypes
    {

        // Numerische Datentypen
        public static void numerischeDatentypen()
        {
            int ganzzahl = 42; // reserviert 4 bytes
            long langeGanzzahl = 9223372036854775807; // reserviert 8 bytes

            float gleitkommazahl = 3.123f; // reserviert 4 bytes
            double langeGleitkommazahl = 0.0000000000000001d; // reserviert 8 bytes

            decimal festkommazahl = 3.123m;
        }

        /// Demo Kombination verschiedener numerischen Datentypen:
        public static void numerischeOperationenDemo()
        {
            Console.WriteLine(42 + 1.234f);
            Console.WriteLine(42 + 1.234m);

            Console.WriteLine(9223372036854775807 - 1);
            //WriteLine(1.234m - 1.234f); // GEHT NICHT!

        }

        /// Demo Gleitkommazahl vs. Festkommazahl:
        public static void rundungsfehlerDemo()
        {
            Console.WriteLine(1.234f * 3);
            Console.WriteLine(1.234m * 3);
        }

        // Zeichen und Zeichenketten
        public static void zeichenDatentypen()
        {
            char zeichen = '!'; // Ein einziges Zeichen, 2 bytes werden reserviert 
            string zeichenkette = "Hallo Welt, Bello bellt!"; // Aneinanderreihung einzelner Zeichen, 2 bytes pro Zeichen
        }

        /// Demo Verkettung
        public static void zeichenVerkettungDemo()
        {
            Console.WriteLine("C" + "+" + "+");
            Console.WriteLine("1" + 2 + "3");
        }

        // Bool'scher Datentyp

        public static void boolWerte()
        {
            bool istFalsch = false; // bools reservieren je 1 bit!
            bool istWahr = true;

            bool isRunning = false;
        }

        // (Eindimensionale) Arrays
        public static void ArrayDatentyp()
        {
            int[] ganzzahlArray = { 12, 24, 36, 48, 50, 62 };

            string[] zeichenkettenArray = { "stingray", "shark", "some fish" };
        }
    }
}
