using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Faktorial
{
    class Program
    {
        //* Toto je méně elegantnější řešení, jelikož cyklus for se blbě přerušuje, ale zase to nehází Infinite loop(stack overflow!) bug. *\\
        static void Main(string[] args)
        {
            Main main = new Main();
            main.zaklad();
        }
    }
}
