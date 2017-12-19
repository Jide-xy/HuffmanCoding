using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
    public class Decode
    {
        private Node rootnode;
        private string binarycode;
        private string init_msg = "";
        public string getOriginalMessage{
            get
            {
            return init_msg;
            }
        }
        public Decode(string binarycode, Node tree_root)
        {
            rootnode = tree_root;
            this.binarycode = binarycode;
            decode();
        }
        private void decode()
        {
            
            Node temp = rootnode;
            
            for (int i = 0; i <= binarycode.Length; i++)
            {
                if (i != binarycode.Length)
                {
                    if (binarycode[i] == '1' && temp.getRightNode != null)
                    {
                        temp = temp.getRightNode;
                    }
                    else if (binarycode[i] == '0' && temp.getLeftNode != null)
                    {
                        temp = temp.getLeftNode;
                    }
                    else if (binarycode[i] == '1' && temp.getRightNode == null)
                    {
                        init_msg += temp.getChar;
                        temp = rootnode.getRightNode;

                    }
                    else if (binarycode[i] == '0' && temp.getLeftNode == null)
                    {
                        init_msg += temp.getChar;
                        temp = rootnode.getLeftNode;
                    }
                }
                else
                {
                     
                        init_msg += temp.getChar;
                    }
                  
                }
            }
        }
    }

