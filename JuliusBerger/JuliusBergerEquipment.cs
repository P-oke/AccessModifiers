using System;
using RCC;



namespace JuliusBerger
{
    public class JuliusBergerEquipment:RCCEquipment
    {
        public string name;
        public JuliusBergerEquipment()
        {
            
        }
        private protected void Crane()
        {
            Console.WriteLine("This is Julius berger Crane");
        }

        public void Caterpillar()
        {
            Console.WriteLine("This is Julius Berger CaterPillar");
        }

        public void tools()
        {
          
            JuliusBergerEquipment JBE = new JuliusBergerEquipment();

            base.RCCOtherTool();
            Test test = new Test();
            test.showinternal();

        }
    }
}
