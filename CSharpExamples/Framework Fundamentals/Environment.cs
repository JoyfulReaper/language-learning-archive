// Environment Class Examples

using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        ConsoleColor org = Console.ForegroundColor;
        //Console.ForegroundColor = ConsoleColor.Red;
        Random rand = new Random();
        //Console.ForegroundColor = (ConsoleColor)rand.Next(0, 16); // Do you want random colors why not?

        Console.WriteLine("");
        Console.WriteLine("Current Dir: {0}", Environment.CurrentDirectory);
        Console.WriteLine("System Dir: {0}", Environment.SystemDirectory);
        Console.WriteLine("Command Line: {0}", Environment.CommandLine);
        Console.WriteLine("Machine Name: {0}", Environment.MachineName);
        Console.WriteLine("Proccessor count: {0}", Environment.ProcessorCount);

        if(Environment.ProcessorCount < 8)
            Console.WriteLine("Less than 8 cores? Ooof!");
        else
            Console.WriteLine("\tYou are rocking {0} cores. Awesome!", Environment.ProcessorCount);
        
        Console.WriteLine("OS Version: {0}", Environment.OSVersion);
        Console.WriteLine("User Name: {0}", Environment.UserName);
        Console.WriteLine("User interactice: {0}", Environment.UserInteractive);
        Console.WriteLine("User Domain Name: {0}", Environment.UserDomainName);
        Console.WriteLine("Tick Count: {0}", Environment.TickCount);

        Console.WriteLine("");
        Console.WriteLine("Stack Trace: {0}", Environment.StackTrace);
        Console.WriteLine("Working Set: {0}", Environment.WorkingSet); // amount of physical memory mapped to the process context
        Console.WriteLine("Version: {0}", Environment.Version); // CLR version

        Console.Write("\nShow Environment Variables? (y/n): ");
        string input = Console.ReadLine();
        if(Char.ToUpper(input[0]) == 'Y')
        {
            Console.WriteLine("Environment variables: ");
            IDictionary vars = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in vars)
            {
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
            Console.ForegroundColor = org;
        }
    }
}