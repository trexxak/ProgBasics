namespace CsharpBasics
{
    public static class L2_Variables_and_Operators
    {
        //// VARIABLEN
        public static void variablen()
        {
            // Deklaration

            int x; // Variable wird definiert, Speicherplatz wird reserviert

            // WriteLine(x); --> funktioniert nicht! Variable hat keinen Wert!



            // Initialisierung

            x = 1; // Initialisierung NACH Deklaration

            int y = 5; // Inline Deklaration + Initialisierung


            // Zuweisung
            //y = 65;
            //Console.WriteLine(y);
            //y += 1;
            //Console.WriteLine(y);
            //y -= 2;
            //Console.WriteLine(y);

            //y *= 3;
            //Console.WriteLine(y);

            //y /= 4;
            //Console.WriteLine(y);

            //y %= 5;
            //Console.WriteLine(y);


            // Beispiele

            bool running; // Deklaration - Speicherplatz reserviert, 

            running = true; // Initialisierung

            while (running)
            {
                Console.WriteLine("läuft.");
                running = false; // Zuweisung
            }

            bool debug = true; // Deklaration + Initialisierung
            Console.WriteLine(debug);

        }

        //// OPERATOREN
        public static void operatoren()
        {
            int x,y = 0;
            // Arithmetische Operatoren

            x = y + 1;
            x = y - 2;
            x = y* 3;
            x = y / 4;
            x = y % 5;

            x++;
            ++x;
            x--;
            --x;


            // Zuweisungsoperatoren

            // siehe VARIABLEN - Zuweisung



            // Vergleichsoperatoren & Logische Operatoren

            bool istWach = true;
            bool hatKaffee = false;

            bool istBereit = (istWach && hatKaffee);
            bool istNichtBereit = !istBereit;

            }
        }
    }
