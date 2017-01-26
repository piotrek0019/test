using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("piotrek");
            lista.Add("waldek");
            lista.Add("ktos");

            
            foreach(string list in lista)
            {
            Console.WriteLine(list);
            }

            Console.ReadLine();
        }
    }
}
