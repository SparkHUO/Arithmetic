using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal class MIFactory : IFactory
    {
        public override IKeyboard CreateKeyboard()
        {
            return new MIKeyboard();
        }

        public override IMouse CreateMouse()
        {
           return new MIMouse();
        }
    }
}
