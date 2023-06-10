using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTest
{
    internal class Node1
    {
        public int data;
        public Node1 Left;
        public Node1 Right;

        public Node1(int data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    }
}
