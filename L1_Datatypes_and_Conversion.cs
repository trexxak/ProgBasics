namespace CsharpBasics
{
    public static class L1_Datatypes_and_Conversion
    {
    //// DATENTYPEN

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
            //Console.WriteLine(1.234m - 1.234f); // GEHT NICHT!

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

        public static void stringLiterale()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            Console.WriteLine(a + "ist a, " + b + " ist b," + c + " ist c, " + d + " ist d");
            Console.WriteLine($"{a} ist a, {b} ist b, {c} ist c, {d} ist d");
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
        public static void arrayDatentyp()
        {
            int[] ganzzahlArray = { 12, 24, 36, 48, 50, 62 };

            string[] zeichenkettenArray = { "stingray", "shark", "some fish" };
        }

        // Ein- und Ausgabe

        public static void ausgabeDemo()
        {
            Console.WriteLine(""); // Konsolenausgabe mit Absatz.

            Console.Write(""); // Konsolenausgabe ohne Absatz.

        }

        public static void eingabeDemo()
        {
            Console.Read(); // Konsoleneingabe für ein Zeichen (char).

            Console.ReadLine(); // Konsoleneingabe für eine Zeichenkette (string). Um zur nächsten Anweisung zu springen muss ein Absatz gegeben werden.
        }

        // null-Wert
        public static void nulled()
        {
            // In speziellen Fällen ist es möglicherweise erwägenswert eine Variable
            // zwar zu initialisieren, ihr vorerst aber nur einen "leeren" Wert zuzuweisen.

            // Andere Anwendungen können es benötigen eine Variable zu entleeren, um nicht
            // versehentlich unerwartete Ergebnisse zu liefern.

            // Eine dritte Anwendung ist die Übernahme von Werten über eine Programmschnittstelle (API)
            // in das eigene Programm. 

            string nulled = null; // Hinweiscode CS8600
            string? nulled2 = null;

            if (nulled == null && nulled2 == null){
                Console.WriteLine("Beides nichts.");
            }

            // WICHTIG: Eine nur deklarierte Variable enthält KEINEN Wert, also auch nicht "null"!
            // AUCH WICHTIG: null ist NICHT 0, false oder entspricht einem leeren String!
        }

        //// KONVERTIEREN
        public static void convertParseTryparse()
        {
            string f = "248,23";

            float g,h,k; // Deklaration mehrerer Variablen desselben Typs

            g = Convert.ToSingle(f); // konvertiert f zu float (interner Typ: single)
                                     // der Wert "false" wird zu 0 konvertiert.
                                     // der spezielle Wert "null" wird zu 0 konvertiert.
                                     // wirft OverflowException und FormatException

            h = float.Parse(f); // konvertiert f zu float
                                // wirft NullException, OverflowException und FormatException
                                // bools können nicht konvertiert werden.

            float.TryParse(f, out k); // konvertiert f zu float
                                      // wirft keine Fehler - der Wert wird einfach als "0" gewertet.

            Console.WriteLine($"Convert: {g+1}\nParse: {h+1}\nTryParse: {k+1}");
        }
    }
}
