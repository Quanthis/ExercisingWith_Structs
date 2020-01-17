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
            Console.Write("Podaj Imię: ");
            o.Imię = Console.ReadLine();
            Console.Write("Podaj Nazwisko: ");
            o.Nazwisko = Console.ReadLine();
            Console.Write("Podaj rok urodzenia: ");
            o.RokUrodzenia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} urodził się w {2} roku.", o.Imię, o.Nazwisko, o.RokUrodzenia);
            Console.ReadKey();
        }
    }
}
