using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1_ED2;

namespace Laboratorio1_ED2
{
    class MultiwayTree<T> where T: IComparable
    {
        //Nodo raiz
        Node<T> root { get; set; }
        public static int m = 2;
        public static int Count;
        
        public void InsertMultiWay(T value)
        {
            if (root == null)
            {
                Node<T> nodeF = new Node<T>(value);

            }
        }
         


    }
}
