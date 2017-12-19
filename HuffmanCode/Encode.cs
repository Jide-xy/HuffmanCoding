using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
   public class Encode
    {
        private string binary_code;
        private Node root;
        private ParseText parse;
        private Dictionary<char, string> charcode = new Dictionary<char, string>();
        private PriorityQueue p_queue = new PriorityQueue();
        public string getBinarycode
        {
            get
            {
                return binary_code;
            }
        }
        public Node getTreeRoot
        {
            get
            {
                return root;
            }
        }
        public Encode(string msg)
        {
            parse = new ParseText(msg);
            encode();
        }
        private void encode()
        {
            string temp = "";
            buildTree();
            Traverse(root, temp, charcode);
            for (int i = 0; i < parse.Original_Message.Length; i++)
            {
                binary_code += charcode[parse.Original_Message[i]];
            }
        }
        private void buildTree()
        {
            for (int i = 0; i < parse.getCharToFrequencyList.Count; i++)
            {

                p_queue.Enqueue(new Node(parse.getCharToFrequencyList.ElementAt(i).Key, parse.getCharToFrequencyList.ElementAt(i).Value));
            }
            while (p_queue.Count > 1)
            {
                var newnode = new Node(p_queue.Dequeue(), p_queue.Dequeue());
                p_queue.Enqueue(newnode);

            }
            root = p_queue.Dequeue();
        }
        public static void Traverse(Node node, string code, Dictionary<char, string> codelist)
        {

            if (node.getLeftNode != null && node.getRightNode != null)
            {
                Traverse(node.getLeftNode, code + "0", codelist);
                Traverse(node.getRightNode, code + "1", codelist);
            }
            else
            {
                codelist.Add(node.getChar, code);
            }

        }
    }
}
