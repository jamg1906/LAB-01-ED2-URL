using System;
using System.Collections.Generic;

namespace Laboratorio1_ED2
{
    public class Node<T>
    {
        public static int m;
        public T Value { get; set; }
        public T[] Valores = new T[m - 1];
        public int capacityLeft = m;
        public T[] Parents = new T[2];
        public Node<T> ParentNode;
        public Node<T>[] Children = new Node<T>[m];
        public Delegate Comparer;


        public Node(T value, int MNode)
        {
            m = MNode;
            Valores[0] = value;
        }

        public void InsertInNode(T value)
        {
            for (int i = 0; i < Valores.Length; i++)
            {
                if (Valores[i] == null)
                {
                    Valores[i] = value;
                    capacityLeft--;
                }
            }
            SortValuesWithinNode();
        }

        private void SortValuesWithinNode()
        {
            for (int i = 0; i < (Valores.Length-capacityLeft)-1; i++)
            {
                for (int j = 0; j < (Valores.Length-capacityLeft) - i -1; j++)
                {
                    if ((int)Comparer.DynamicInvoke(Valores[j], Valores[j+1]) == 1)
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
