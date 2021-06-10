using System;
using JuliusBerger;

namespace AccessModifiersPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            JuliusBergerEquipment JBE = new JuliusBergerEquipment();
            JBE.Caterpillar();
            JBE.tools();

        }
    }
}
