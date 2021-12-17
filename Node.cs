using System;
using ConsoleApp1;

namespace ConsoleApp2
{
    class Node
    {
        public nhanvien Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public Node( nhanvien emp)
        { 
            this.Data = Data;
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}

