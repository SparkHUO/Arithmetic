using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal class HUAWEIKeyboard : IKeyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个华为键盘");
        }
    }
}
