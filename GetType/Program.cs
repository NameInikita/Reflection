using System;

namespace GetType
{
    class MyClass
    {
        private int field;

        int Field { get; set; }
        public MyClass()
        {
        }
        public MyClass(int field)
        {
            this.field = field;
        }
        private int Method(int a, int b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            Type type;

            type = my.GetType();
            Console.WriteLine(type);


            Console.ReadKey();

        }
    }
}
