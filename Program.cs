using System;
using System.IO;

namespace verhaalsinterklaas;
class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\rei\Desktop\sinterklaas\verhaal.txt";
        string[] stories = File.ReadAllLines(filePath);
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, stories.Length);
        
        try
        {
            string name = args[0];
            string present = args[1];
            Console.WriteLine($"Hallo {name} jouw cadeau is {present} , verhaal: {stories[randomNumber]}");
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("need atleast 2 arguyment");
            throw;
        }
    }
}