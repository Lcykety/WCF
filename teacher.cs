using System;

public class teacher : Personel
{
	
    

    public override void salloryCalculator()
    {
         
        if (hours > 20)
        {
            this.sallory += (this.sallory*4) +((hours - 20) * 200);

        }
        else
            this.sallory= this.sallory*4;
      
    }
}
