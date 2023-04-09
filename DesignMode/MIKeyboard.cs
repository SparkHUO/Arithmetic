using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal class MIKeyboard : IKeyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个小米键盘");
        }
    }
}
