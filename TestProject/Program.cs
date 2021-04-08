using System;
using System.Reflection;
using MathString;
namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation ca = new Calculation();
            Console.WriteLine($"足し算:5+4={ca.Add("5","4")}\n掛け算:500*400={ca.Multiplication("500","400")}");
            Console.WriteLine("終了するにはキーを押してください。");
            Console.ReadKey();
        }
    }
}
