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
            Node temp = new Node(newNumberId);
            if(root == null)
            {
                root = temp;

            }
            else
            {
                
                Node start = root;
                bool nextRound = true;
                while (nextRound)
                {
                    if (temp.id > start.id)
                    {
                        if (start.right == null)
                        {
                            start.right = temp;
                            nextRound = false;
                        }
                        else
                        {
                            start = start.right;

                        }
                    }
                    else if (temp.id < start.id)
                    {

                        if (start.left == null)
                        {
                            start.left = temp;
                            nextRound = false;
                        }
                        else
                        {
                            start = start.left;

                        }
                    }
                }
            }
        }

        public void Search(Node node)
        {


        }
    }
}
