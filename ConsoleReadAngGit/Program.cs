using System;

namespace ConsoleReadAngGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());

            int rezultatSabiranja = prviBroj + drugiBroj;
            Console.WriteLine("Rezultat sabiranja: " + rezultatSabiranja);

            //TODO: Unaprediti ovaj primer da ispisuje rezultate osnovnih matematickih operacija ( + - / *)
            //TODO: Uraditi commit izmena i publishovati na Git Repo
        }
    }
}
