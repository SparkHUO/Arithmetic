using System;
using System.Collections.Generic;
using System.Text;



public abstract class MouseFactory
{
    public abstract Mouse CreateMouse(string name, Cat cat = null);
}

public class SmallMouseFactory : MouseFactory
{
    public override Mouse CreateMouse(string name, Cat cat = null)
    {
        return new SmallMouse(name,cat);
    }

}

public class BigMouseFactory : MouseFactory
{
    public override Mouse CreateMouse(string name, Cat cat = null)
    {
        return new BigMouse(name,cat);
    }
}