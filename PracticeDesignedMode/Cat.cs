using System;
using System.Collections.Generic;
using System.Text;


public class Cat:Animal
{
    public delegate void CatComing();
    public event CatComing CatComingEvent;

    public Cat(string name)
    {
        this.name = name;
    }

    public void CatchTheMouse()
    {
        Console.WriteLine(this.name+" is Catching the mouse!");
        if (CatComingEvent!=null)
        {
            CatComingEvent();
        }
    }

}
