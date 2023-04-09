using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    internal abstract class IFactory
    {
        public abstract IMouse CreateMouse();
        public abstract IKeyboard CreateKeyboard();


    }


}
