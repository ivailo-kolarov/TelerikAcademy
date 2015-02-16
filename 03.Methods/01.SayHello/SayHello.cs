using System;
/*
Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.

Example:

input	output
Peter	Hello, Peter!
*/

class SayHelloMethod
{
    public static void SayHello(String method)
    {
        Console.WriteLine("Hello {0}", method);
    }


    static void Main()
    {
        SayHello(Console.ReadLine());
    }
}

