using System;

public sealed class Singleton
{
    // Static variable to hold the single instance
    private static Singleton instance = null;

    // Private constructor prevents object creation from outside
    private Singleton()
    {
        Console.WriteLine("Creating Singleton Object...");
    }

    // Public method to get the single instance
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("This is the Singleton object.");
    }
}
