using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16._12._222
{
    public class Cleaner : Personel
    {
        
        public override void salloryCalculator()
        {
            base.salloryCalculator();

            
            if (hours > 30)
            {
                this.sallory = (sallory*2)+ ((hours - 30) * 40);
            }
            else
            {
                this.sallory = sallory * 2;
            }
            
            
        }
    }
}