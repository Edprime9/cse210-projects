using System;

namespace math 
{
    class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assign =new  WritingAssignment("Morrison","Chemistry","I love Chemistry");

        Console.WriteLine(assign.GetString());
        Console.WriteLine($"{assign.GetWritingInformation()}");
    }
}
}