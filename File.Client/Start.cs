namespace Main.Client
{
    public class Start
    {
        static void Main(string[] args)
        {
            var c = new BaseClient();
            var res = c.GetData("https://localhost:7177/File");
            var c2 = new BaseClient();
            var res2 = c2.GetData("https://localhost:7177/Person");
            var c3 = new BaseClient();
            var res3 = c3.GetData("https://localhost:7177/Student");
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine("Hello, World!");
        }
    }
}