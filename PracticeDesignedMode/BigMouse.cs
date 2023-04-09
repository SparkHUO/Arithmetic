using System;
using System.Collections.Generic;
using System.Text;

public class BigMouse : Mouse
{
    public BigMouse(string name,Cat cat=null)
    {
        this.name = name;
        if (cat != null)
        {
            cat.CatComingEvent += Run;
        }
    }


}
