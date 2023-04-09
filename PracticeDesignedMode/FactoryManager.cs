using System;
using System.Collections.Generic;
using System.Text;

public class FactoryManager
{
    private static FactoryManager _instance;
    public static FactoryManager Instance
    {
        get 
        {
            if (_instance==null)
            {
                _instance = new FactoryManager();
            }
            return _instance;
        }
    }

    public SimpleMouseFactory CreateSimpleFactory()
    {
        return new SimpleMouseFactory();
    }

    public SmallMouseFactory CreateSmallMouseFactory()
    { 
        return new SmallMouseFactory();
    }

    public BigMouseFactory CreateBigMouseFactory()
    {
        return new BigMouseFactory();
    }


}
