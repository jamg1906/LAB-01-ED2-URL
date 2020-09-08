using System;

namespace Laboratorio1_ED2
{
    public class Node<T>
    {
        public static int m;
        public T Value { get; set; }
        public T[] Valores = new T[m - 1];
        private Node<T>[] Parents = new Node<T>[2];
        private Node<T>[] Children = new Node<T>[m];


        public Node(T value)
        {
            //aquí habría que hacer la asignación de valores y llamar al método de ordenar
            Value = value;
        }

    }

}
