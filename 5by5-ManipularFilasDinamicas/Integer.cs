using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_ManipularFilasDinamicas
{
    internal class Integer
    {
        int number;
        Integer next;

        public Integer(int number)
        {
            this.number = number;
            this.next = null; 
        }

        public override string? ToString()
        {
            return "" + this.number;
        }

        public int getNumber() { return number; }
        public Integer? getNext()
        {
            return this.next;
        }
        public void setNext(Integer aux)
        {
            this.next = aux;
        }
    }

}
