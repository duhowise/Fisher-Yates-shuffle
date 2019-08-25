using System;
using System.Collections.Generic;

namespace TestYates
{
    public static  class Shuffle
    {
        private static Random rand =new Random();

        public static void shuffle(List<int> number)
        {
            for (var i =number.Count-1;i>0;i--)
            {
                int j = rand.Next(i+1);
                int temp = number[i];
                number[i] = number[j];
                number[j] = temp;
            }
        }

        public static void Assign(List<int> value, Stack<int> Values)
        {
            for (var i = 0; i < value.Count; i++)
            {
               Values.Push(value[i]);
            }
          

        }
    }
}
