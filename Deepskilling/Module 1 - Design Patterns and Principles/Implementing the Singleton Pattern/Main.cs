using System;

class Program
{
    static void Main(string[] args)
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        obj1.ShowMessage();
        obj2.ShowMessage();

        Console.WriteLine("Are both objects the same? " + Object.ReferenceEquals(obj1, obj2));
    }
}
