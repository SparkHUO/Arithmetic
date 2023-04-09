using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal class HUAWEIMouse:IMouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个华为鼠标");

        }
    }
   
}
