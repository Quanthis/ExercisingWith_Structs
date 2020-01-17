using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp94
{
    struct Osoba
    {
        public string Imię, Nazwisko;
        public int RokUrodzenia;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Osoba o;
            Console.Write("Name: ");
            o.Imię = Console.ReadLine();
            Console.Write("Surname: ");
            o.Nazwisko = Console.ReadLine();
            Console.Write("Year of Birth: ");
            o.RokUrodzenia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} was born in {2}.", o.Imię, o.Nazwisko, o.RokUrodzenia);
            Console.ReadKey();
        }
    }
}
