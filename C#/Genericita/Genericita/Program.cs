using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericita
{
    class Program
    {
        static void main(string[] args)
        {
            Trida<int> instance = new Trida<int>(10);

            bool stejne = instance.Porovnej<string>("15");
            Console.WriteLine(stejne);
        }
    }
}