﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithTextExe2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2- Write a program and ask the user to enter a few numbers
             * separated by a hyphen. If the user simply presses Enter,
             * without supplying an input, exit immediately; otherwise,
             * check to see if there are duplicates. If so, display 
             * "Duplicate" on the console. */

            Console.WriteLine("Enter numbers separated by hyphens or" +
                "just enter to exit!");

            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;
            
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach(var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if(includesDuplicates)
                Console.WriteLine("Duplicate");
            

        }
    }
}
