using System;

namespace Opdracht2Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            Zak deZak = new Zak();

            Cadeau eenCadeau = new Cadeau("Transformer");

            deZak.AddPresent(eenCadeau);

            foreach(Cadeau c in deZak.GetPresents())
            {
                Console.WriteLine(c.GetName());
            }
        }
    }
}
