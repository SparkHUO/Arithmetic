using System;
using System.Collections.Generic;
using System.Text;
namespace DesignMode
{
    internal class SimpleFactory
    {


        public HUAWEIMouse CreateHuaWeiMouse()
        { 
            return new HUAWEIMouse();
        }

        public MIMouse CreateMIMouse()
        {
            return new MIMouse();
        }

    }
}
