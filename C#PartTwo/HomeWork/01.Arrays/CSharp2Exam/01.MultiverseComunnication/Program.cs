using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class MultiversCommunication
{

    static void Main()
    {

        string input = Console.ReadLine();
        List<string> inputMessages = new List<string>();
        Dictionary<string, int> numbers = new Dictionary<string, int>();
        numbers.Add("CHU", 0);
        numbers.Add("TEL", 1);
        numbers.Add("OFT", 2);
        numbers.Add("IVA", 3);
        numbers.Add("EMY", 4);
        numbers.Add("VNB", 5);
        numbers.Add("POQ", 6);
        numbers.Add("ERI", 7);
        numbers.Add("CAD", 8);
        numbers.Add("K-A", 9);
        numbers.Add("IIA", 10);
        numbers.Add("YLO", 11);
        numbers.Add("PLA", 12);

        Stack<int> messageToNumbers = new Stack<int>();
        for (int i=0 ; i < input.Length; i++)
        {
            if ((i+1) % 3 == 0)
            {


                if(i == input.Length-1)
                {
                    inputMessages.Add(input.Substring(input.Length-1- 2, 3));
                   // Console.WriteLine(inputMessages);

                    break;
                }
                inputMessages.Add(input.Substring(i - 2, 3));
               // messageToNumbers.Push(numbers[inputMessages[i]]);
                //Console.WriteLine(inputMessages  );
            }
          
        }

        for (int i = 0; i < inputMessages.Count; i++)
        {
            if (numbers.ContainsKey(inputMessages[i])) 
            {
                messageToNumbers.Push(numbers[inputMessages[i]]);
            }
        }

          long sum = messageToNumbers.Pop();
          int count = messageToNumbers.Count;
            for (int i = 1; i <= count; i++)
            {
                sum += messageToNumbers.Pop() * (long)Math.Pow(13, i);
            }
            Console.WriteLine(sum);
    }


}

