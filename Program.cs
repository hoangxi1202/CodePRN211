namespace OOP;
using static System.Console;
public class Program
{
    public static void Main()
    {
        //instance
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Hoang";
        e.Salary = 1500;
        e.level = "ngu";
        WriteLine(e);
        ReadLine();
    }
}
