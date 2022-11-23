using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTijelo_nasljedivanje
{
    class GeometrijskoTijelo
    {
        double volumet, oplosje;
        public static int brojacTijela = 0;
    }
    class Kugla : GeometrijskoTijelo
    {
        static Kugla()
        {
            brojacTijela += 1;
        }
    }
    class Kvadar : GeometrijskoTijelo
    {
        static Kvadar()
        {
            brojacTijela+=1;
        }
    }
       class Kocka: Kvadar
       {
            static Kocka()
            {
                brojacTijela+=1;
            }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();


            Console.WriteLine("Definirana broji tijela je: " + GeometrijskoTijelo.brojacTijela);
            Console.ReadKey();
        }
    }
}
