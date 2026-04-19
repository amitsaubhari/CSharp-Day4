using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Iphone");
        list.Add("Oneplus");
        list.Add("Redmi");
        list.Add("Google");
        foreach (String i in list)
        {
            Console.WriteLine(i);
        }
    }
}