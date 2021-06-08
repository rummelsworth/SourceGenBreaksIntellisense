using System;

namespace SourceGenBreaksIntellisense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HelloWorldGenerated.HelloWorld.SayHello();
        }

        public Test test { get; set; }

        public Test2 test2 { get; set; }
    }

    class Test2
    {
    }
}
