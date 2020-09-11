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
            List<int> PinchiRecorrido = Tree.Inorder();
            string result = "";
            int iterardor = 1;
            foreach(int number in PinchiRecorrido)
            {
                result += number.ToString()+ ",";
                if((iterardor%4)==0)
                {
                    result += Environment.NewLine; 
                }
                iterardor++;
            }
            Console.WriteLine(result+Environment.NewLine+"Termino aqui");
            PinchiRecorrido = Tree.Preorder();
             result = "";
             iterardor = 0;
            foreach (int number in PinchiRecorrido)
            {
                result += number.ToString();
                if ((iterardor % 4) == 0)
                {
                    result += Environment.NewLine;
                }
            }
            Console.WriteLine(result + Environment.NewLine + "Termino aqui");

            Console.ReadKey();
        }
    }
}
