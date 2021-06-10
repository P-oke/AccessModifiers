using System;
using System.Collections.Generic;
using System.Text;

namespace JuliusBerger
{
    class JuliusBergerTools:JuliusBergerEquipment
    {
        public void anothertool()
        {
            JuliusBergerTools JBGT = new JuliusBergerTools();
            JBGT.Crane();
            JuliusBergerEquipment jb = new JuliusBergerEquipment();
            jb.Crane();
        }
       
        
    }
}
