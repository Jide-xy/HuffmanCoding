using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
   public class PriorityQueue : IComparer<Node>
    {
        private List<Node> pq;
        public PriorityQueue(){
            pq = new List<Node>();
        }
       public Node this [int index]
        {
            get
            {
                return pq[index];
            }
        }
        public int Count
        {
            get
            {
                return pq.Count;
            }
        }
        public void Enqueue(Node node)
        {
            pq.Add(node);
            pq.Sort(Compare);
        }
        public Node Dequeue()
        {
            if (pq.Count>0)
            {
                Node temp = pq[0];
                pq.RemoveAt(0);
                return temp;
            }
            throw new ArgumentOutOfRangeException("Priority Queue is empty");
        }
        public int Compare(Node node1, Node node2)
        {
            return node1.getFrequency.CompareTo(node2.getFrequency);
        }

        //int IComparer<Node>.Compare(Node x, Node y)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

