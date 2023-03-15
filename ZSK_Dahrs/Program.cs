namespace ZSK_Dahrs {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, ZSK!");
            ZSK(2850);
            Console.Read();
        }

        static void ZSK(int euro) {
            int anzKuh, anzSchaf, anzZiege, anzKlziege, rest;

            anzKuh = euro / 2800;
            rest = euro % 2800;
            euro = rest;

            anzSchaf = euro / 650;
            rest = euro % 650;
            euro = rest;

            anzZiege = euro / 500;
            rest = euro % 500;
            euro = rest;

            anzKlziege = euro / 50;
            rest = euro % 50;
            euro = rest;

            Console.WriteLine(  "{0} Kühe {1} Schafe {2} Ziegen {3} Kleine Ziegen", anzKuh, anzSchaf, anzZiege, anzKlziege);
        }
    }
}