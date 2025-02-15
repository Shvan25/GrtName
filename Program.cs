using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Евгения";
        string oldname = "Евгения";

        GetName(out name, out oldname);
        Console.WriteLine(name);
        Console.WriteLine(oldname);
    }
    static void GetName(out string name, out string oldname)
    {
        oldname = "Евгения";
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }
}