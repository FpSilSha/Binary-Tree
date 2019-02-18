using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();

            binaryTree.AddNode(100);
            binaryTree.AddNode(90);
            binaryTree.AddNode(101);
            binaryTree.AddNode(105);
            binaryTree.AddNode(75);
            binaryTree.AddNode(10);
            binaryTree.AddNode(35);
            binaryTree.AddNode(104);

            
            binaryTree.Search(75);
            binaryTree.Search(35);
           Node capture1 = binaryTree.Search(104);
           Node capture2 = binaryTree.Search(32);
        }
    }
}
