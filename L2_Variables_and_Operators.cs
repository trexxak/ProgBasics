using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            x = 6;

            y += 1;
            y -= 2;
            y *= 3;
            y /= 4;
            y %= 5;

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
