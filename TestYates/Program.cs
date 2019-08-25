using System;
using System.Collections.Generic;
namespace TestYates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            int num = 12;
            //Stack<int> AssignedNumbers=new Stack<int>();
            //int[] number;
            //number=new int[10];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number.SetValue(i+1, i);
            //}
            //Shuffle.Doshuffle(number);
            //foreach (int numbers in number)
            //{
            //    Console.WriteLine(numbers); 
            //}

            List<int> QuestionNumber = new List<int>();
            for (var i = 1; i < num + 1; i++)
            {
                QuestionNumber.Add(i);
                
            }
            foreach (var number in QuestionNumber)
            {
                Console.WriteLine(number);
            }
           Shuffle.shuffle(QuestionNumber);
            

            Stack<int> shufled = new Stack<int>();
            //new Shuffle(QuestionNumber);
            //foreach (int numbers in QuestionNumber)
            //{
            //    AssignedNumbers.Push(numbers);
            //}
            Shuffle.Assign(QuestionNumber,shufled);
            for (var i = 0; i < QuestionNumber.Count; i++)
            {
                Console.WriteLine(QuestionNumber[i]);
            }
            Console.ReadLine();

            #endregion



        }
    }
}



