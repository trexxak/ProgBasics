namespace CsharpBasics
{
    public static class L5_Object_Orientation
    {
        // Member: Felder und Methoden

        public class Auto
        {
            // Felder - "Variablen" einer Klasse
            string hersteller = "Autole";
            string seriennummer = "z9fw";
            int leistung = 42;

            // Methoden - "Funktionen" einer Klasse
            public void fahren()
            {
                Console.WriteLine($"{hersteller} {seriennummer} fährt mit {leistung} km/h.");
            }

        }

        // Instanziierung
        //
        // Das "Drucken" eines Gegenstands (Objekt) anhand eines "Musters" (Klasse)
        public static void instanziierung()
        {                                   // Beliebig viele Objekte derselben Klasse können zur
            Auto myAuto = new();            // selben Zeit im Code bestehen!
            myAuto.fahren();
        }

        // Statische Klassen
        //
        // können nicht instanziiert werden!

        public static class Counter
        {
            public static int count = 0;
        }

        // Konstruktor
        //
        // Ermöglicht das Parametisieren von Objekten!

        public class Auto2
        {
            // Felder 
            string hersteller = "Autole"; 
            string seriennummer = "z9fw";
            int leistung = 42;

            // Konstruktor
            public Auto2(string customHersteller, string customSeriennummer, int customLeistung)
            {
                // this. bezieht sich auf die Felder!
                this.hersteller = customHersteller;
                this.seriennummer = customSeriennummer;
                this.leistung = customLeistung;
            }

            // Methoden
            public void fahren()
            {
                Console.WriteLine($"{hersteller} {seriennummer} fährt mit {leistung} km/h.");
            }


        }
        public static void instanziierung2()
        {
            Auto2 myAuto = new("Hersteller", "Seriennummer", 512);
            myAuto.fahren();
        }


        // VERERBUNG durch Klassenvererbung

        public class Fortbewegungsmittel
        {
            protected string name;
            protected int geschwindigkeit;

            public Fortbewegungsmittel(string name, int geschwindigkeit)
            {
                this.name = name;
                this.geschwindigkeit = geschwindigkeit;
            }

            public void bewegen()
            {
                Console.WriteLine($"{name} erreicht {geschwindigkeit} km/h.");
            }

        }

        public class Fahrrad : Fortbewegungsmittel
        {
            decimal preis;
            public Fahrrad(string name, int geschwindigkeit, decimal preis) : base(name,geschwindigkeit)
            {
                this.name = name;
                this.geschwindigkeit = geschwindigkeit;
                this.preis = preis;
            }
            new public void bewegen()
            {
                Console.Write("Das Fahrrad ");
                base.bewegen();
            }

            public void klingeln()
            {
                Console.WriteLine("Klingelingeling!");
            }
        }

        static public void instanziierung3()
        {
            Fortbewegungsmittel fbm = new Fortbewegungsmittel("wat", 120);
            Fahrrad bike = new Fahrrad("coolbike", 40, 302.23m);

            //fbm.bewegen();

            //bike.bewegen();
            //bike.klingeln();

            //fbm.klingeln();
        }


        // DATENKAPSELUNG durch Zugriffsmodifizierer

        // private
        // Standard. Nur innerhalb der Klasse kann auf die Member zugegriffen werden.
        // Da private der default-Zugriff ist, muss das Schlüsselwort nicht angegeben werden.

        private class PrivateKlasse 
        {                                        
            private string privat = "privat!";  
        }
        //      ^
        //  selbes Ergebnis
        //      v
        class PrivatereKlasse
        {
            string privat = "privat!";
        }

        private class PrivatKind : PrivateKlasse
        {
            void printPrivat()
            {
                //Console.WriteLine(privat);
            }
        }

        // protected
        // Nur innerhalb der Klasse und innerhalb davon erbenden Klassen kann auf die Member
        // zugegriffen werden.

        protected class GeschuetzteKlasse
        {
            protected string privat = "nur für Familie!";
        }
        protected class GeschuetztesKind : GeschuetzteKlasse
        {
            void printPrivat()
            {
                Console.WriteLine(privat);
            }
        }

        // internal
        // Nur innerhalb desselben Dokuments/ Assemblies kann auf Member zugegriffen werden.

        internal static class InterneKlasse
        {
            internal static string status = "nur hier drin!";
        }

        static void interneMethode()
        {
            Console.WriteLine(InterneKlasse.status);
        }

        // public - Überall kann auf die Member zugegriffen werden.

        public class OeffentlicheKlasse
        {
            public string status = "Hereinspaziert! Voll nicht privat!";
        }

        // POLYMORPHISMUS durch Vererbung, virtuelle Methoden, abstrakte Klassen und Überschreibung.

        // Kind- und Geschwisterklassen können stark voneinander in Inhalt und Form abweichen:
        abstract public class Tier  // ABSTRAKTE KLASSE. Kann NICHT instanziiert werden.
                                    // Wird zur reinen Weitervererbung verwendet.
        {
            public bool istAmLeben;

            virtual protected void geraeusch()      // virtuelle Methoden können in vererbter Klasse
                                                    // überschrieben werden.
            {
                Console.WriteLine("macht ein Geräusch.");
            }
        }

        public class Katze : Tier
        {
            public int leben = 7;

            override protected void geraeusch()     // Überschreibung der geerbten Methode durch Override
            {
                Console.WriteLine("macht 'Miau'.");
            }
        }

        public class Hund : Tier
        {
            public float loyalitaet = 99.999999f;

            override protected void geraeusch()
            {
                Console.WriteLine("macht 'Wuff'.");
            }
        }

        public class Tiger : Katze
        {
            public bool haustier = false;

            override protected void geraeusch()
            {
                Console.WriteLine("macht 'Grr'.");
            }
        }


    }
}
