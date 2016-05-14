using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_Code_Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello CodeEval";
            string[]userLine = line.Split();
            Array.Reverse(userLine);
            foreach(string Words in userLine)
            {
                Console.Write(' ');
                Console.Write(Words);
            }
            Console.WriteLine();
            
            
            
        }
    }
}
