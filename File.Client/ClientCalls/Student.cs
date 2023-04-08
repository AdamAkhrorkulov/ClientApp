using File.Client;

namespace Main.Client.ClientCalls;

public class Student
{
    public void Process()
    {

        var c = new BaseClient();
        var res = c.GetData("https://localhost:7177/Student");
        Console.WriteLine(res);
        Console.WriteLine("Hello, World!");
    }
}