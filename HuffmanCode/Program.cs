using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Encode encode = new Encode("DATA COMPRESSION");
            Console.WriteLine(encode.getBinarycode);
            Decode decode = new Decode(encode.getBinarycode, encode.getTreeRoot);
            Console.WriteLine(decode.getOriginalMessage);
            Console.ReadLine();
            
        }
    }
}
