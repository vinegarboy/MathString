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
            Console.WriteLine($"足し算:5000+400={ca.Add("5000","400")}\n引き算:500-50={ca.Subtraction("500","5555")}\n掛け算:500*400={ca.Multiplication("484","555")}");
        }
    }
}
