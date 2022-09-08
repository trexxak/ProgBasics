namespace CsharpBasics
{
    public class Exercises
    {

        // Schreiben Sie ein Programm, welches eine
        // Benutzereingabe 100 mal ausgibt und dann endet.

        public static void echo()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(input);
            }
        }

        // Schreiben Sie ein Programm, welches von 0 bis 150 iteriert und:
        //  - bei jeder durch 3 teilbaren Zahl "Fizz" ausgibt
        //  - bei jeder durch 5 teilbaren Zahl "Buzz" ausgibt
        //  - bei jeder durch 15 teilbaren Zahl "FizzBuzz" ausgibt
        //  - bei jeder anderen Zahl dieselbe ausgibt.

        public static void fizzBuzz()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Schreiben Sie ein Programm, welches ein eingegebenes Jahr darauf überprüft,
        // ob es ein Schaltjahr darstellt.
        //
        // Hinweis: Als Schaltjahr gilt jedes 400. als auch jedes 4. Jahr,
        // wenn das 4. Jahr nicht gleichzeitig ein 100. Jahr ist.

        public static void schaltjahrRechner()
        {
            Console.Write("Geben Sie bitte ein Jahr ein: ");
            string eingabe = Console.ReadLine();
            int jahr = int.Parse(eingabe);

            if (jahr % 4 == 0 && jahr % 100 != 0)
            {
                Console.WriteLine($"{eingabe} ist ein Schaltjahr.");
            }
            else if (jahr % 4 == 0 && jahr % 400 == 0)
            {
                Console.WriteLine($"{eingabe} ist ein Schaltjahr.");
            }
            else
            {
                Console.WriteLine($"{eingabe} ist KEIN Schaltjahr.");
            }
        }

        // Schreiben Sie ein Programm, welches eine Ganzzahl als Benutzereingabe
        // annimmt, und als binäre Zahlenfolge zurückgibt.
        //
        // Bsp.: Eingabe = 31 -> Ausgabe = 00011111

        public static void binaerzahlRechner()
        {
            string result = "";
            //int eingabe = int.Parse(Console.ReadLine());

            int eingabe = 127;
            for (int i = 128; i > 0; i/=2)
            {
                Console.WriteLine("Runde: " + i);

                if (eingabe >= i)
                {
                    Console.WriteLine("Zähler: "+i);
                    Console.WriteLine("Eingabe: " + eingabe);

                    result += "1";
                    eingabe -= i;
                }
                else
                {
                    Console.WriteLine("Zähler: " + i);
                    Console.WriteLine("Eingabe: " + eingabe);

                    result += "0";
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine(result);
        }

        //      Schreiben Sie ein Programm, dass die Menüführung eines
        //      erfundenen Videospiels simuliert.

        public static void optionsMenue()
        {
            bool inMenue = true;
            Console.WriteLine("Menü\n\n(0) Tastaturbelegung\n(1) Sound\n(2) Grafik\n(x) Schließen");

            while (inMenue)
            {
                char eingabe = Console.ReadKey().KeyChar;
                switch (eingabe)
                {
                    case '0':
                        Console.WriteLine("Tastaturbelegung\n\n(x) Schließen");
                        eingabe = Console.ReadKey().KeyChar;
                        if (eingabe == 'x') { inMenue = false; }
                        break;
                    case '1':
                        Console.WriteLine("Sound\n\n(x) Schließen");
                        eingabe = Console.ReadKey().KeyChar;
                        if (eingabe == 'x') { inMenue = false; }
                        break;
                    case '2':
                        Console.WriteLine("Grafik\n\n(x) Schließen");
                        eingabe = Console.ReadKey().KeyChar;
                        if (eingabe == 'x') { inMenue = false; }
                        break;
                    case 'x':
                        inMenue = false;
                        break;
                    default:
                        break;
                }
            }
        }

    }

}
