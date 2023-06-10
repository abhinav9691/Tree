using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTest
{
    internal class Tree
    {
        Node1 root;

        public Tree()
        {
            root = null;
        }

        public Node1 Returnroot()
        {
            return root;
        }

        public void Insert(int data)
        {
            Node1 newnode = new Node1(data);
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node1 current = root;
                Node1 parent;
                while (true)
                {
                    parent = current;
                    if (data < current.data)
                    {
                        current = current.Left;
                        if(current == null)
                        {
                            parent.Left = newnode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if(current == null)
                        {
                            parent.Right = newnode;
                            return;
                        }
                    }
                }

            }
        }
        public void Display(Node1 root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                Display(root.Left);
                Display(root.Right);
            }
        }
    }
}
