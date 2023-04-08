using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Client.ClientCalls
{
    public class Person
    {
        public void Process()
        {

            var c = new BaseClient();
            var res = c.GetData("https://localhost:7177/Person");
            Console.WriteLine(res);
            Console.WriteLine("Hello, World!");
        }
    }
}
