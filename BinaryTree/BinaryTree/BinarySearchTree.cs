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

        public bool AddNode(int newNumberId)
        {
            Node temp = new Node(newNumberId);
            bool nodeAlreadyExist = false;
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
                    else
                    {
                        nodeAlreadyExist = true;
                    }
                }
            }

            return nodeAlreadyExist;
        }

        public Node Search(int numberId)
        {
            Node temp = new Node(numberId);
            Node start = root;
            bool nodeDoesNotExist = false;
            
            bool nextRound = true;
            while (nextRound)
            {
                if (temp.id > start.id)
                {
                    if (start.right == null)
                    {
                        nextRound = false;
                        nodeDoesNotExist = true;

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
                        nextRound = false;
                        nodeDoesNotExist = true;

                    }
                    else
                    {
                        start = start.left;

                    }
                }
                else if (temp.id == start.id) 
                {
                    nextRound = false;
                }
                else
                {
                    nextRound = false;
                    nodeDoesNotExist = true;
                }
            }
            if(temp.id == start.id)
            {
                return start;
            }
            else
            {
                return temp;
            }
        }

    }
    
}
