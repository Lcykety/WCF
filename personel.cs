using System;

public class  Personel
{
	public string Name { get; set; }
	public string lastName { get; set; }
	public int hours { get; set; }	
	public int sallory = 2000;

	public virtual void  salloryCalculator()
    {
		sallory = 2000;
    }
}
