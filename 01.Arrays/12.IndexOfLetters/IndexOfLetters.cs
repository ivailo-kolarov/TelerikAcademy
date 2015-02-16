using System;


//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


class IndexOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter letter from alphabet");
        char[] alphabet = new char[27];
        for (int letter = 0; letter < alphabet.Length - 1; letter++)
        {
            alphabet[letter] = (char)(letter + 65);
        }
        string word = Console.ReadLine();
        word = word.ToUpper();
        foreach (var letter in word)
        {
            int index = Array.IndexOf(alphabet, letter);
            Console.WriteLine("Letter {0}  has index {1}", letter, index + 1);
        }

    }
}
