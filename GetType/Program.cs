using System;
using System.Reflection;

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
        public int Method(int a, int b)
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

            type = my.GetType();//на экземпляре класса  MyClass
            Console.WriteLine(type);

            type = Type.GetType("GetType.MyClass");//static Type GetType()
            Console.WriteLine(type);

            type = typeof(MyClass);//оператор typeof()


            Console.WriteLine("про метод");

            MethodInfo methodType =type.GetMethod("Method");
            Console.WriteLine(methodType);

            Console.ReadKey();
        }
    }
}
