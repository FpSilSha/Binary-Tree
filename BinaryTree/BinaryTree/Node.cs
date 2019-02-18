using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int id;
        public bool doesNotExist = false;
        public Node right;
        public Node left;
        public Node (int id)
        {
            this.id = id;
        }
    }
}
