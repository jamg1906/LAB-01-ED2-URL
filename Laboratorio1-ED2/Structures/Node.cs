using System;
using System.Collections.Generic;

namespace Laboratorio1_ED2
{
    class Node<T> where T:IComparable
    {
        public static int m;
        public T Value { get; set; }
        public T[] Valores;
        public int capacityLeft;
        public T[] Parents = new T[2];
        public Node<T> ParentNode;
        public Node<T>[] Children;


        public Node(T value, int MNode)
        {
            m = MNode;
            Children= new Node<T>[m];
            Valores = new T[m -1];
            capacityLeft = m-1;
            capacityLeft--;
            Valores[0] = value;
        }

        public void InsertInNode(T value)
        {
            Valores[m - capacityLeft - 1] = value;
            capacityLeft--;
            /*for (int i = 0; i < Valores.Length; i++)
            {
                if (Valores[i] == null)
                {
                    Valores[i] = value;
                    capacityLeft--;
                }
            }*/
            if (capacityLeft == 0)
            {
                SortValuesWithinNode();
            }
        }

        private void SortValuesWithinNode()
        {
            for (int i = 0; i < (Valores.Length-capacityLeft)-1; i++)
            {
                for (int j = 0; j < (Valores.Length-capacityLeft) - i -1; j++)
                {
                    if(Valores[j].CompareTo(Valores[j+1]) == 1)
                    {
                        //swap de valores dentro del nodo
                        T temp = Valores[j];
                        Valores[j] = Valores[j + 1];
                        Valores[j + 1] = temp;
                    }
                }
            }
        }

    }

}
