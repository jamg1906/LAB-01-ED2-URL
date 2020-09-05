using System;

namespace Laboratorio1_ED2
{
    public class Nodo<T>
    {
        private Nodo<T>[] padres;
        private Nodo<T>[] hijos;
        private T[] valores;

        public T[] Valores { get => valores; set => valores = value; }
        internal Nodo<T>[] Padres { get => padres; set => padres = value; }
        internal Nodo<T>[] Hijos { get => hijos; set => hijos = value; }
    }

}
