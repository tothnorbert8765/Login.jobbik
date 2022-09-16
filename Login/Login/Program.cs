using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Felhasználó név:");
            string felh = Console.ReadLine();
            Console.WriteLine("Jelszó");
            string jelsz = Console.ReadLine();
            string a = felh + ";" + jelsz;
            string[] beolvas = File.ReadAllLines("login.txt");
            bool OK = false;
            for (int i = 0; i < beolvas.Length && !OK; i++)
            {
                if (a==beolvas[i])
                {
                    Console.WriteLine("Sikeres bejelentkezés");
                    OK = true;
                }
                

            }
            if (OK==true)
            {
                
            }
            else
            {
                Console.WriteLine("Hibás felhasználónév vagy jelszó");
            }
            Console.ReadKey();
        }
    }
}
