using System;

namespace Delegates
{
    class Program
    {
        public delegate void DelegatePointer(int r, int s);

        static void Main(string[] args)
        {
            DelegatePointer pointer;

            MySchool newSchool = new MySchool();
            pointer = newSchool.FirstMethod;
            pointer += newSchool.SecondMethod;

            pointer += delegate (int x, int y) {
                Console.WriteLine("I have two parameters ["
                  + x + "," + y + "]");
            };

            pointer += (int z, int l) => {
                Console.WriteLine(z / l);
                };

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            pointer(12, 4);

            pointer -= newSchool.FirstMethod;
            pointer -= newSchool.SecondMethod;
            pointer(12, 4);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
public class MySchool
{
    public void FirstMethod(int b, int c)
    {
        Console.WriteLine(b * c * b);
    }
    public void SecondMethod(int b, int c)
    {
        Console.WriteLine(b + b - c);
    }
}