using System;
using System.Collections.Generic;

namespace Laboratorio1_ED2
{
    public class MultiwayTree<T> where T: IComparable
    {
        Node<T> root { get; set; }
        public static int m = 2;
        public static int Count = 0;
        
        public void InsertMultiWay(T value)
        {
            if (root == null)
            {
                root = new Node<T>(value, m);
            }
            else
            {
                Node<T> temp = root;
                int[] ParentsIndex = new int[2];
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
                            found = true;
                            temp.Children[i] = new Node<T>(value, m);
                            temp = temp.Children[i];
                            temp.ParentNode = temp2;
                            a = false;
                            ParentsIndex[0] = i;
                            ParentsIndex[1] = i++;
                            break;

                        }
                        else if (i == ((m - 1) - 1) && !found)
                        {
                            found = true;
                            temp.Children[m - 1] = new Node<T>(value, m);
                            temp = temp.Children[m - 1];
                            temp.ParentNode = temp2;
                            a = false;
                            ParentsIndex[0] = i;
                            ParentsIndex[1] = i++;
                            break;
                        }
                    }
                }
                /*
                if (temp == null)
                {
                    temp = new Node<T>(value, m);
                    temp.ParentNode = temp2;
                    //temp.Parents[0] = temp.ParentNode.Valores[ParentsIndex[0]];
                    //temp.Parents[1] = temp.ParentNode.Valores[ParentsIndex[1]];
                }*/
                if (a)
                {
                    temp.InsertInNode(value);
                }
            }
            Count++;
        }
         


    }
}
