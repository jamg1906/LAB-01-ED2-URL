using System;
using System.Collections.Generic;

namespace Laboratorio1_ED2
{
    public class MultiwayTree<T> where T: IComparable
    {
        Node<T> root { get; set; }
        private int m = 2;
        public int Count = 0;

        public void SetM(int val)
        {
            m = val;
        }

        public void InsertMultiWay(T value)
        {
            if (root == null)
            {
                root = new Node<T>(value, m);
            }
            else
            {
                Node<T> temp = root;
                //temp2 servirá para enlazar el nodo padre al crear un nuevo hijo
                Node<T> temp2 = temp;
                bool a = true;
                while (temp.capacityLeft == 0 && a)
                {
                    bool found = false;
                    for (int i = 0; i < (m - 1); i++)
                    {
                        temp2 = temp;
                        if (value.CompareTo(temp.Valores[i]) == -1 && !found)
                        {
                            //Significa que el valor va en el sub arbol izquierdo.
                            try
                            {
                                //CASO se asume que si existe nodo
                                //Caso tiene capacidad, por tanto, se inserta
                                if (temp.Children[i].capacityLeft != 0)
                                {
                                    temp.Children[i].InsertInNode(value);
                                    temp = temp.Children[i];
                                    a = false;
                                    temp.ParentNode = temp2;
                                }
                                //Caso no tiene capacidad, por tanto se sigue en el ciclo while
                                else
                                {
                                    temp = temp.Children[i];
                                }
                            }
                            catch
                            {
                                //Si llega acá es porque no existía nodo, por tanto se crea.
                                temp.Children[i] = new Node<T>(value, m);
                                temp = temp.Children[i];
                                temp.ParentNode = temp2;
                                a = false;
                            }
                            found = true;
                        }
                        else if (i == ((m - 1) - 1) && !found)
                        {
                            //Significa que el valor va en el último subarbol.
                            try
                            {
                                //CASO se asume que si existe nodo
                                //Caso tiene capacidad, por tanto, se inserta
                                if (temp.Children[m - 1].capacityLeft != 0)
                                {
                                    temp.Children[m - 1].InsertInNode(value);
                                    temp = temp.Children[m - 1];
                                    a = false;
                                    temp.ParentNode = temp2;
                                }
                                //Caso no tiene capacidad, por tanto se sigue en el ciclo while
                                else
                                {
                                    temp = temp.Children[m - 1];
                                }
                            }
                            catch
                            {
                                //Si llega acá es porque no existía nodo, por tanto se crea.
                                temp.Children[m - 1] = new Node<T>(value, m);
                                temp = temp.Children[m - 1];
                                temp.ParentNode = temp2;
                                a = false;
                            }
                            found = true;
                        }
                    }
                }
                if (a)
                {
                    temp.InsertInNode(value);
                }
            }
            Count++;
        }
         

        public List<T> Preorder()
        {
            List<T> Respre = new List<T>();
            Node<T> Guia = root;
            for(int i=0; i<Guia.usedSpace;i++)
            {
                Respre.Add(Guia.Valores[i]);
            }
            for (int i = 0; i < Guia.usedSpace+1; i++)
            {
                if (Guia.Children[i] != null)
                {
                    RecorPreorder(Respre, Guia.Children[i]);
                }
            }
            return Respre;
        }
        private List<T> RecorPreorder(List<T> resul, Node<T> hijo)
        {
            Node<T> Guia = hijo;
            for (int i = 0; i < Guia.usedSpace; i++)
            {
                resul.Add(Guia.Valores[i]);
            }
            for (int i = 0; i < Guia.usedSpace + 1; i++)
            {
                if(Guia.Children[i]!=null)
                {
                 RecorPreorder(resul, Guia.Children[i]);
                }
            }
            return resul;
        }

        public List<T> Inorder()
        {
            List<T> Respre = new List<T>();
            Node<T> Guia = root;
            for (int i = 0; i < Guia.usedSpace + 1; i++)
            {
                if (Guia.Children[i] != null)
                {
                    RecorInorder(Respre, Guia.Children[i]);
                }
                if (i < Guia.usedSpace)
                {
                    Respre.Add(Guia.Valores[i]);
                }
            }
            return Respre;
        }
        private List<T> RecorInorder(List<T> resul, Node<T> hijo)
        {
            Node<T> Guia = hijo;
            for (int i = 0; i < Guia.usedSpace + 1; i++)
            {
                if (Guia.Children[i] != null)
                {
                    RecorInorder(resul, Guia.Children[i]);
                }
                if (i < Guia.usedSpace)
                {
                    resul.Add(Guia.Valores[i]);
                }
            }
            return resul;
        }

        public List<T> Postorder()
        {
            List<T> Respre = new List<T>();
            Node<T> Guia = root;
            for (int i = 0; i < Guia.usedSpace; i++)
            {
                Respre.Add(Guia.Valores[i]);
            }
            for (int i = 0; i < Guia.usedSpace + 1; i++)
            {
                if (Guia.Children[i] != null)
                {
                    RecorPosorder(Respre, Guia.Children[i]);
                }
            }
            return Respre;
        }
        private List<T> RecorPosorder(List<T> resul, Node<T> hijo)
        {
            Node<T> Guia = hijo;
            for (int i = 0; i < Guia.usedSpace + 1; i++)
            {
                if (Guia.Children[i] != null)
                {
                    RecorPreorder(resul, Guia.Children[i]);
                }
            }
            for (int i = 0; i < Guia.usedSpace; i++)
            {
                resul.Add(Guia.Valores[i]);
            }
            return resul;
        }
    }
}
