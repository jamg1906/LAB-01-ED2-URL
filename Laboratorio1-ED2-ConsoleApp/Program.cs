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
            Console.ReadKey();
            for (int i = 0; i< 100; i++)
            {
                Tree.InsertMultiWay(ElRandom.Next(1,500));
            }
            Console.ReadKey();
        }
    }
}
