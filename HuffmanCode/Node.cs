using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
   public class Node
    {
        int frequency;
        char literal;
        Node leftnode;
        Node rightnode;

        public Node(char literal, int frequency)
        {
            this.literal = literal;
            this.frequency = frequency;
            this.leftnode = null;
            this.rightnode = null;
        }
        public Node(Node leftnode, Node rightnode)
        {
            this.leftnode = leftnode;
            this.rightnode = rightnode;
            this.frequency = leftnode.frequency + rightnode.frequency;

        }
        public int getFrequency
        {
            get
            {
                return frequency;
            }
        }
        
        public Node getLeftNode
        {
            get
            {
                return leftnode;
            }
        }
        public Node getRightNode
        {
            get
            {
                return rightnode;
            }
        }
        public char getChar
        {
            get
            {
                return literal;
            }
        }
       

      
    }
}
