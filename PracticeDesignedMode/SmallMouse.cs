using System;
using System.Collections.Generic;
using System.Text;

public class SmallMouse:Mouse
{
    public SmallMouse(string name,Cat cat=null)
    { 
        this.name = name;
        if (cat!=null)
        {
            cat.CatComingEvent += Run;
        }
    }


}
