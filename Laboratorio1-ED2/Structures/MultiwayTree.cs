using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio1_ED2;

namespace Laboratorio1_ED2
{
    class MultiwayTree<T> where T: IComparable
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
                while (temp.capacityLeft == 0)
                {
                    bool found = false;
                    for (int i = 0; i < (m - 1); i++)
                    {
                        temp2 = temp;
                        if (value.CompareTo(temp.Valores[i]) == -1 && !found)
                        {
                            found = true;
                            temp = temp.Children[i];
                            ParentsIndex[0] = i;
                            ParentsIndex[1] = i++;

                        }
                        else if (i == ((m - 1) - 1) && !found)
                        {
                            temp = temp.Children[m - 1];
                            ParentsIndex[0] = i;
                            ParentsIndex[1] = i++;
                        }
                    }
                }
                if (temp == null)
                {
                    temp = new Node<T>(value, m);
                    temp.ParentNode = temp2;
                    temp.Parents[0] = temp.ParentNode.Valores[ParentsIndex[0]];
                    temp.Parents[1] = temp.ParentNode.Valores[ParentsIndex[1]];
                }
                else
                {
                    temp.InsertInNode(value);
                }
            }
            Count++;
        }
         


    }
}
