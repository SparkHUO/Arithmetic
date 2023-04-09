using System;
using System.IO;


namespace DesignMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HUAWEIFactory HUAWEIFactory = new HUAWEIFactory();  //新建一个工厂对象
            IMouse huaweiMouse = HUAWEIFactory.CreateMouse();  //通过工厂对象去生产所需要的对象
            IKeyboard huaweiKeyboard = HUAWEIFactory.CreateKeyboard();  //通过工厂对象去生产所需要的对象

            MIFactory miFactory = new MIFactory();  //新建一个工厂对象
            IMouse miMouse = miFactory.CreateMouse();  //通过工厂对象去生产所需要的对象
            IKeyboard miKeyboard = miFactory.CreateKeyboard();  //通过工厂对象去生产所需要的对象

            huaweiMouse.Print();
            huaweiKeyboard.Print();

            miMouse.Print();
            miKeyboard.Print();

        }
    }





}
