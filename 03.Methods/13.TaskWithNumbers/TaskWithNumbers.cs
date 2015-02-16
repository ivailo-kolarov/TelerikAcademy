﻿/*
 * Write a program that can solve these tasks:
 * - Reverses the digits of a number
 * - Calculates the average of a sequence of integers
 * - Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 * - The decimal number should be non-negative
 * - The sequence should not be empty
 * - a should not be equal to 0
 */


    using System;
    using System.Collections.Generic;
    class TasksWithNumbers
    {
        static int ReversNumberDigits(int inputNumber)
        {
            if (inputNumber < 0)
            {
                return -1;
            }
            int reversedNumber = 0;
            while (inputNumber != 0)
            {
                reversedNumber = reversedNumber * 10 + inputNumber % 10;
                inputNumber = inputNumber / 10;
            }
            return reversedNumber;
        }
        static double CalcAverageNumber(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return -1;
            }
            int sumOfNumbers = 0;
            foreach (var number in numbers)
            {
                sumOfNumbers += number;
            }

            double average = (double)sumOfNumbers / numbers.Length;
            return average;
        }
        static double SolvesLinearEquation(int indexA, int indexB)
        {
            if (indexA == 0)
            {
                return -1;
            }
            double unknownX = (double)-indexB / indexA;
            return unknownX;
        }
        static void Main()
        {
            Console.WriteLine("Please choose:");
            Console.WriteLine("\tA) Reverses the digits of a number;");
            Console.WriteLine("\tB) Calculates the average of a sequence of integers;");
            Console.WriteLine("\tC) Solves a linear equation a * x + b = 0");
            Console.WriteLine("\tE)For exit");
            char userChoice = Console.ReadKey().KeyChar;
            while (userChoice != 'A' && userChoice != 'B' && userChoice != 'C' && userChoice != 'E')
            {
                Console.WriteLine("Please enter correct letter from menu above (A, B, C or E)");
                userChoice = Console.ReadKey().KeyChar;
            }

            switch (userChoice)
            {
                case 'A':
                    {
                        Console.Write("\n Please enter possitive integer: ");
                        int userInteger = int.Parse(Console.ReadLine());
                        int reversetInteger = ReversNumberDigits(userInteger);
                        if (reversetInteger != -1)
                        {
                            Console.WriteLine("{0} reversed is {1}", userInteger, reversetInteger);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not possitive number!", userInteger);
                        }
                        break;
                    }
                case 'B':
                    {
                        Console.Write("\n Please enter some integers. Enter any letter to stop: ");
                        List<int> userInput = new List<int>();
                        int result = 0;
                        while (true)
                        {
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out result))
                            {
                                userInput.Add(result);
                            }
                            else
                            {
                                break;
                            }
                        }
                        double averageInteger = CalcAverageNumber(userInput.ToArray());
                        if (averageInteger != -1)
                        {
                            Console.WriteLine("Average is {0}", averageInteger);
                        }
                        else
                        {
                            Console.WriteLine("You did not enter at least one number!");
                        }
                        break;
                    }
                case 'C':
                    {
                        Console.WriteLine("\nPlease enter coeficient A and constand B");
                        Console.WriteLine("of equation A*X + B = 0");
                        Console.Write("A: ");
                        int coeficientA = int.Parse(Console.ReadLine());
                        Console.Write("B: ");
                        int constantB = int.Parse(Console.ReadLine());
                        double unknownX = SolvesLinearEquation(coeficientA, constantB);
                        if (unknownX != -1)
                        {
                            Console.WriteLine("Unknown X is {0}", unknownX);
                        }
                        else
                        {
                            Console.WriteLine("Coeficient A must not be equal to 0!");
                        }
                        break;
                    }
                case 'E':
                    {
                        break;
                    }
                default:
                    break;
            }
        }
    }
