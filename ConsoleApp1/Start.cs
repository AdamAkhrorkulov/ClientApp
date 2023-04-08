using System;

namespace Person.Client
{
    public class Start
    {
        static void Main(string[] args)
        {
            var c  = new Client();
           var res = c.GetData();
           Console.WriteLine(res);
            Console.WriteLine("Hello, World!");
        }
    }
}
