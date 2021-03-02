using System;

using RévisionLib;

namespace ConsoleFonctions
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "*** Genevieve Trudel ***";
            Console.WriteLine("Bonjour, je suis Genevieve Trudel");
            Console.WriteLine("Vive Git!");
            AfficherAdditionAléatoire();

            _ = Console.ReadKey();
        }

        private static void AfficherAdditionAléatoire()
        {
            var random = new Random();
            int n1 = random.Next(100);
            int n2 = random.Next(100);
            Console.WriteLine(
                $"{n1} + {n2} = {Fonctions.Additionner(n1, n2)}");
        }
    }
}
