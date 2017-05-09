using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntTabelaZdarzenia
{
    class Tabela
    {
        private int[] temps = new int[10];

        public int Length
        {
            get { return temps.Length; }
        }

        public void Resize(int newSize)
        {
            Array.Resize(ref temps, newSize);
        }

        public int this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }
}
