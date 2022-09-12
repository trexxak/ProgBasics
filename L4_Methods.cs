namespace CsharpBasics
{
    // METHODEN bzw. "Funktionen"
    public static class L4_Methods
    {
        //              v
        public static void printMyHandle()  // soll kein Wert zurückgegeben werden,
        {                                   // muss der Rückgabewert als "void" deklariert werden
            Console.WriteLine("trexxak");
        }
        //              v
        public static string returnMyHandle()
        {
            return "trexxak";               // sobald ein Wert zurückgegeben wird,
        }                                   // muss der jeweilige Datentyp deklariert werden.


        public static int returnOne()
        {
            return 1;
            int x = 1 + 1;
            Console.WriteLine("Das wirst du nicht sehen...");
        }

        public static void p(string content, int amount=1) // parameterisiert!
        {

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine(content);
                }

        }

        public static void demoMethoden()
        {
            string t = "trexxak";
            printMyHandle();
            returnMyHandle();
            Console.WriteLine(returnMyHandle());

            p(t,42);

            Console.WriteLine(t);

        }
    }
}
