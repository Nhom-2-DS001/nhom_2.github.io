using System;
using ConsoleApp1;
using ConsoleApp2;

namespace ConsoleApp3
{
    class Binarytree
    {
        public Node root { get; set; }
       
        public bool Insert(nhanvien list)
        {
            Node before = null, after = this.root;
            while (after != null)
            {
                before = after;
                if (list.getId() < after.Data.getId())
                    after = after.LeftNode;
                else if (list.getId() > after.Data.getId())
                    after = after.RightNode;
                else return false;
            }
            Node newNode = new Node(list);
            newNode.Data = list;
            if (this.root == null)

                this.root = newNode;

            else
            {
                if (list.getId() < before.Data.getId())
                    before.LeftNode = newNode;
                else before.RightNode = newNode;
            }
            return true;
        }
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.WriteLine(parent.Data);
                TraverseInOrder(parent.RightNode);
            }
        }
        public void Print()
        {
            TraverseInOrder(this.root);
        }
        public Node timID(int ID, Node parent)
        {
            if (parent != null)
            {
                if (ID == parent.Data.getId())
                {
                    return parent;
                }
                if (ID > parent.Data.getId())
                {
                    return timID(ID, parent.RightNode);
                }
                else
                {
                    return timID(ID, parent.LeftNode);
                }
            }
            return null;
        }
        public Node timhoten(string hoten, Node parent, ref int temp)
        {
            if (parent == null)
            {
                return null;
            }
            Node left = timhoten(hoten, parent.LeftNode, ref temp);
            if (parent.Data.getHoTen().ToLower() == hoten)
            {
                Console.WriteLine(parent.Data);
                temp++;
            }
            Node right = timhoten(hoten, parent.RightNode, ref temp);
            return parent;
        }

        public Node timTuoi(int min, int max, Node parent, ref int temp)
        {
            if (parent == null)
            {
                return null;
            }
            Node left = timTuoi(min, max, parent.LeftNode, ref temp);
            if (min <= parent.Data.getTuoi() && parent.Data.getTuoi() <= max)
            {
                Console.WriteLine(parent.Data);
                temp++;
            }
            Node right = timTuoi(min, max, parent.RightNode, ref temp);
            return parent;
        }
        public Node mintuoi(Node parent)
        {
            Node min = parent;
            if (parent != null)
            {
                if (parent.LeftNode != null)
                {
                    Node left = mintuoi(parent.LeftNode);
                    if (min.Data.getTuoi() > left.Data.getTuoi())
                    {
                        min = left;
                    }
                }
                if (parent.RightNode != null)
                {
                    Node right = maxtuoi(parent.RightNode);
                    if (min.Data.getTuoi() > right.Data.getTuoi())
                    {
                        min = right;
                    }
                }
            }
            return min;
        }

        public void print_min()
        {
            Console.WriteLine(mintuoi(this.root).Data);
        }

        public Node maxtuoi(Node parent)
        {
            Node max = parent;
            if (parent != null)
            {
                if (parent.LeftNode != null)
                {
                    Node left = maxtuoi(parent.LeftNode);
                    if (max.Data.getTuoi() < left.Data.getTuoi())
                    {
                        max = left;
                    }
                }
                if (parent.RightNode != null)
                {
                    Node right = maxtuoi(parent.RightNode);
                    if (max.Data.getTuoi() < right.Data.getTuoi())
                    {
                        max = right;
                    }
                }
            }
            return max;
        }

        public void print_max()
        {
            Console.WriteLine(maxtuoi(this.root).Data);
        }
        public Node timhsl(double min, double max, Node parent, ref int temp)
        {
            if (parent == null) return null;
            Node left = timhsl(min, max, parent.LeftNode, ref temp);
            if (min <= parent.Data.getHSL() && parent.Data.getHSL() <= max)
            {
                Console.WriteLine(parent.Data);
                temp++;
            }
            Node right = timhsl(min, max, parent.RightNode, ref temp);
            return parent;
        }
        public Node timBH(string BH, Node parent, ref int temp)
        {
            if (parent == null)
            {
                return null;
            }
            Node left = timBH(BH, parent.LeftNode, ref temp);
            if (parent.Data.getBH().ToUpper() == BH)
            {
                Console.WriteLine(parent.Data);
                temp++;
            }
            Node right = timBH(BH, parent.RightNode, ref temp);
            return parent;
        }
        public Node remove(Node node, int ngaynghi)
        {

            if (node == null)
            {
                return null;
            }
            if (node.Data.getNghi() > ngaynghi)
            {
                return remove(node.RightNode, ngaynghi);
            }
            else
            {
                return node;
            }
        }

        public int print_Remove(Node parent, int ngaynghi)
        {
            int tmp = 0;
            if (parent != null && remove(parent, ngaynghi) != null)
            {
                print_Remove(remove(parent.LeftNode, ngaynghi), ngaynghi);
                Console.WriteLine(remove(parent, ngaynghi).Data);
                tmp++;
                print_Remove(remove(parent.RightNode, ngaynghi), ngaynghi);
            }
            return tmp;
        }
    }






   
        }
   

