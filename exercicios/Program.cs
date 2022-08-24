using System.Globalization;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ExerciciosTreinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // propriedades do timeSpan

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t4.Add(t5);
            TimeSpan sub = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine($"soma dos valores: {soma}");
            Console.WriteLine($"subtração dos valores: {sub}");
            Console.WriteLine($"multiplicação dos valores: {mult}");
            Console.WriteLine($"divisão dos valores: {div}");
        }
    }
}
