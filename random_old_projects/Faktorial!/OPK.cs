using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Faktorial
{ //začátek
    class OPK  //class
    {
        public string next;

        public void opakovani() //funkce
        {
            Console.WriteLine("\r\n");
            Console.Write("Chcete vypočíst další příklad? a/n => ");
            next = Console.ReadLine();
            Console.WriteLine("\r\n");
        }
    }
}
