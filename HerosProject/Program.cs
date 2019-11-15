using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero k1 = new Hero("Batman*", "London");
            k1.Name = ("Batman*");
            Console.WriteLine("Hero number one is: " + k1.Name);
            Hero k2 = new Hero("Superman", "Tokyo");
            Hero k3 = new Hero("Kyogo*", "Peking");
            Console.ReadLine();
        }
    }
}
