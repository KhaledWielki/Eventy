using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntTabelaZdarzenia
{
    class Tabela
    {
        public delegate void AddToTableDelegate(int index, int value);
        public event AddToTableDelegate AddToTable;

        public delegate void ResizeTableDelegate(int newSize);
        public event ResizeTableDelegate ResizeTable;

        private int[] temps = new int[10];

        public int Length
        {
            get { return temps.Length; }
        }

        public void Resize(int newSize)
        {
            Array.Resize(ref temps, newSize);
        }

        public void Add(int index, int value)
        {
            temps[index] = value;
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
