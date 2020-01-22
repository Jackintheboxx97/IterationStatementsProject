using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //done Create a List called "numbers"
            var numbers = new List<int>();

            //DONE Create a variable of type int with an initializer of 0
            // collection of ints
            var i = 0;
            do
            {// execute this code at least once
                i++; // increment your variable by 1 i = 1
                numbers.Add(i); // then add your variable to "numbers"

            } while (i < 100); // while your variable i is less than 100


            Console.WriteLine("Hello!");
            // Done Create a do-while loop
                

           
                // DoneIncrement your variable by 1
                // DoneThen add your variable to "numbers"
            
            // While your variable is less than 100
                       
            // Create a while loop

            while (i < 200)
            {
                i++;
                numbers.Add(i);
            }
                                 

            // DONE While your variable is less than 200
            {
                // DONE Increment your variable by 1
                //  DONE Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");


            
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            // DONE Create a foreach loop
            // DONE Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for(int a = 199; a <= numbers.Count && a >=0; a--)
            {
                Console.WriteLine(numbers[a]);
            }

            Console.WriteLine(numbers.Count);
            
            //DONE  Create a for loop
            // DONE in your initializer set the value of i to 199
            // DONE in your conditional, as long as i is less than or equal to the length of "numbers"
            // DONE and as long as i is greater than or equal to 0
            // DONE Decrement i by 1
            
        }
    }
}
