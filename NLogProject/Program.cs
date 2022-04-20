using System;
using NLog;

namespace NLogProject
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Nlogger.");
            AddNumbers add = new AddNumbers();
            add.Sum(1, 2);
        }
    }
}
