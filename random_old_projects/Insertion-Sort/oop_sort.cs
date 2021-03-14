using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class oop_sort : IComparable
    {
        public int number { get; set; }

        //Pro zobrazení v listboxu
        //public override string ToString()
        //{ return number.ToString(); }

        //Implementace rozhrání IComparable
        public int CompareTo(object obj)
        {
            oop_sort secNumber = (oop_sort)obj;
            int vysledek = number.CompareTo(secNumber.number);
            return vysledek;
        }
    }
}
