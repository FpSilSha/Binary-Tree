using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree
    {

        Node root = null;

        public void AddNode(int newNumberId)
        {
            Node temp = new Node();
            temp.id = newNumberId;
            if(root == null)
            {
                root = temp;

            }
            else
            {

            }
        }

        public void Search(Node node)
        {


        }
    }
}
