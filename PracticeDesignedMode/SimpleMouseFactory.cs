using System;
using System.Collections.Generic;
using System.Text;

public enum MouseType
{
    SmallMouse,
    BigMouse,
}

public class SimpleMouseFactory
{
   
        
    public Mouse CreatMouse(string name,MouseType mouseType)
    {
        switch (mouseType)
        {
            case MouseType.SmallMouse:
                return new SmallMouse(name);
            case MouseType.BigMouse:
                return new BigMouse(name);
            default:
                break;
        }
        return null;
    }

}
