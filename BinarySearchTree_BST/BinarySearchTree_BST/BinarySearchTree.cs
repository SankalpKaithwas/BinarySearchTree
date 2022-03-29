using System;
namespace BinarySearchTree_BST
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public T nodeData;
        public BinarySearchTree<T> left;
        public BinarySearchTree<T> right;
        public BinarySearchTree(T data)
        {
            nodeData = data;
            left = null;
            right = null;
        }

        public void Insert(T item)
        {
            T node = nodeData;
            if (node.CompareTo(item) > 0)
            {
                if (left == null)
                {
                    left = new BinarySearchTree<T>(item);
                }
                else
                {
                    left.Insert(item);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new BinarySearchTree<T>(item);
                }
                else
                {
                    right.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (left != null)
            {
                left.Display();
            }
            Console.WriteLine(nodeData.ToString());
            if (right != null)
            {
                right.Display();
            }
        }
    }
}