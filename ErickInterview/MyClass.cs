using System;
using System.Collections.Generic;
using System.Linq;

namespace ErickInterview
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            bool foundNum = false;
            int num = 1;
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            List<int> myList = A.ToList().OrderBy(x => x).ToList();

            while(!foundNum)
            {
                if(!myList.Contains(num))
                {
                    foundNum = true;
                }

                num++;
            }

            System.Console.WriteLine(num);
        }
    }
}
