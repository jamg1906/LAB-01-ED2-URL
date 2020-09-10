using Laboratorio1_ED2;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Laboratorio1_ED2_ConsoleApp
{
    class Program
    {
        public static Laboratorio1_ED2.MultiwayTree<int> Tree = new Laboratorio1_ED2.MultiwayTree<int>();

        static void Main(string[] args)
        {
            Laboratorio1_ED2.MultiwayTree<int>.m = 5;
            Random ElRandom = new Random();
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
            for (int i = 0; i< 100; i++)
            {
                //Console.WriteLine("Inserte un número");
                //Tree.InsertMultiWay(Convert.ToInt32(Console.ReadLine()));
                Tree.InsertMultiWay(ElRandom.Next(1,500));
            }
            Console.WriteLine("Se ha llenado satisfactoriamente el árbol.");
            Console.ReadKey();
        }
    }
}
