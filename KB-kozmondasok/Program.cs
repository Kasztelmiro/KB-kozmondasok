using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KB_kozmondasok
{
    internal class Program
    {

        static void leghosszabb(List<string> lista)
        {
            int sz = 0;
            int leghossz = 0;
            string legsor = "";
            foreach (string s in lista)
            {
                foreach (char c in s)
                {
                    sz++;
                }
                if (sz >= leghossz)
                {
                    leghossz = sz;
                    legsor = s;
                    
                }
                sz = 0;

            }
            Console.WriteLine($"A leghosszabb sora: {legsor}");
        }

        static void egyesit(List<string> kozos, List<string> lista, List<string> pista)
        {
            foreach (string s in lista)
            {
                kozos.Add(s);
            }
            foreach (string s in pista)
            {
                kozos.Add(s);
            }
        }

        static void sorba(List<string> lista)
        {
            lista.Sort();
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }

        static void nemspace(List<string> lista)
        {
            int sz = 0;
            foreach (string s in lista)
            {
                foreach (char c in s)
                {
                    if (c != ' ')
                    {
                        sz++;
                        
                    }
                }
            }
            Console.WriteLine(sz);
        }

        static void ment(List<string> lista)
        {
            StreamWriter ki = new StreamWriter("kozmondasok.txt");
            foreach (string s in lista)
            {
                ki.WriteLine(s);
            }
            ki.Close();
        }


        static void Main(string[] args)
        {/*
        Közmondások
        KB - 2025.01.28.
        */

            string fejlec = "Közmondások";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write('-');
            Console.WriteLine();

            List<string> szoveg1 = new List<string>();
            int c = 0;
            StreamReader be = new StreamReader("szoveg1.txt");
            string sor = be.ReadLine();
            while (sor != null)
            {
                szoveg1.Add(sor);
                sor = be.ReadLine();
                c++;
            }
            be.Close();
            Console.WriteLine($"1. A szoveg1 {c} sort tartalmaz");
            //----------------------------------------------------//
            c = 0;
            List<string> szoveg2 = new List<string>();
            be = new StreamReader("szoveg2.txt");
            sor = be.ReadLine();
            while (sor != null)
            {
                szoveg2.Add(sor);
                sor = be.ReadLine();
                c++;

            }
            be.Close();
            Console.WriteLine($"A szoveg2 {c} sort tartalmaz");
            List<string> kozos = new List<string>();


            //2. feladat
            Console.WriteLine("2. feladat:");
            Console.WriteLine("szoveg1:");
            leghosszabb(szoveg1);
            Console.WriteLine("szoveg2:");
            leghosszabb(szoveg2);

            //3. feladat
            egyesit(kozos, szoveg1, szoveg2);


            //4. feladat
            Console.WriteLine("4. feladat:");
            sorba(kozos);

            //5. feladat
            Console.WriteLine("5. feladat:");
            nemspace(kozos);

            //6. feladat
            ment(kozos);

            Console.WriteLine("Kilépéshez nyomja meg az ENTER billentyűt!");
            Console.ReadLine();
        }
    }
}
