using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        string input = "";
        do
        {
            Console.Write("Enter Input: ");
            input = Console.ReadLine();
            if(input != "exit")
            {
                output += input + " ";
                Console.WriteLine("Output: " + output.Trim());
            }
            else
            {
                Console.WriteLine("Output: exit");
                break;
            }
        } while (true);
        Console.WriteLine("Exiting Program...");
    }
}