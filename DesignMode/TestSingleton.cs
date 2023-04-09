using System;
using System.Collections.Generic;
using System.Text;


namespace DesignMode
{
    public class TestSingleton
    {
        private static TestSingleton _instance;
        public static TestSingleton Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new TestSingleton(); 
                }
                return _instance;
            }
        }

        private TestSingleton()
        { 
            
        }

        public void Test()
        {
            Console.Write("成功构造一个单例类");
        }




    }





}
