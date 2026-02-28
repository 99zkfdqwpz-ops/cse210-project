using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{

   
    static void Main(string[] args)
    { 
        
        Console.Write("enter a number: ");
        string UserNumber = Console.ReadLine();
        int x = int.Parse(UserNumber);
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("greater");
        }
        else if(x < y)
        {
            Console.WriteLine("less");
        }
    }
}