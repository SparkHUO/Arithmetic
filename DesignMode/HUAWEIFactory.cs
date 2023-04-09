using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal class HUAWEIFactory : IFactory
    {
        public override IKeyboard CreateKeyboard()
        {
            return new HUAWEIKeyboard();
        }

        public override IMouse CreateMouse()
        {
            return new HUAWEIMouse();
        }

    }



}
