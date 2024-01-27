using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericita
{

    public class Trida<T>
    {
        private T promenna;

        public Trida(T promenna)
        {
            this.promenna = promenna;
        }
        public bool Porovnej<T2>(T2 a)
        {
            return promenna.Equals(a);
        }
    }
}