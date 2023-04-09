using System;

namespace PracticeDesignedMode
{
    internal class Program
    {
        static SimpleMouseFactory factory;

        static SmallMouseFactory smallMouseFactory;
        static BigMouseFactory bigMouseFactory;

        static Mouse mouse1;
        static Mouse mouse2;
        static Cat cat;
        static void Main(string[] args)
        {
            smallMouseFactory = FactoryManager.Instance.CreateSmallMouseFactory();
            bigMouseFactory = FactoryManager.Instance.CreateBigMouseFactory();

            cat = new Cat("Cat");

            mouse1 = smallMouseFactory.CreateMouse("SmallMouse",cat);
            mouse2 = bigMouseFactory.CreateMouse("BigMouse",cat);

            cat.CatchTheMouse();
        }




    }


}
