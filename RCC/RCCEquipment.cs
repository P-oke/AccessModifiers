using System;
using RCC;
using RCC1;

namespace RCC
{
    public class RCCEquipment
    {
        internal void Crane()
        {
            Console.WriteLine("This is RCC Crane");
        }

        internal void Caterpillar()
        {
            Console.WriteLine("This is RCC CaterPillar");
        }

       protected internal void RCCOtherTool()
       {
           Console.WriteLine("RCC Other Tools");
       }

    }
    


}

public class Test
{
    public void showinternal()
    {
        RCCEquipment rcce = new RCCEquipment();
        rcce.RCCOtherTool();

        Class1 class1 = new Class1();
        class1.Name="paul";






    }

}

