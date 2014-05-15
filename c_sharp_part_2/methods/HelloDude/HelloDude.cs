using System;
//01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.
    class HelloDude
    {
        
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            printName(name);
        }

        static void printName(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
    }

