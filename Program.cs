using System;
using System.Globalization;

namespace ArrraysAndCollections;

class ArrraysAndCollections
    {
        static void Main(string[] args)
        {
            // Lists Lesson
            List<string> cars = new List<string>();
            cars.Add("Bugatti");
            cars.Add("Ferarri");
            cars.Add("Toyota");
            cars.Add("Honda");
            
            foreach(string car in cars)
            {
                Console.WriteLine(car.ToUpper());
            }

            // Fibonacci  series using lists
            List<int> fibNums = [1, 1];
            for(int n = 2; n < 20 ; n++)
            {
                int previousNum1 = fibNums[n-1]; 
                int previousNum2 = fibNums[n-2];
                int nextNum =previousNum1 + previousNum2;

                fibNums.Add(nextNum);
            }
            
            foreach(int fibNum in fibNums)
            {
                Console.WriteLine(fibNum);
            }


            //Factorial of a number
            
            Console.WriteLine("FACTORIAL OF A NUMBER");
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine()!);

            long factorial = 1;

            for(int n = 1; n <= number; n++)
            {
                factorial *= n;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}\n");

            Console.WriteLine("ARRAYS");
            // Write a program that finds the largest, smallest, and average values in an array of integers.

            int[] nums = {10, 9, 11,19,25,50,4,1,6};
            Array.Sort(nums);
            Console.WriteLine($"Array minimum number is: {nums.Min()}");
            Console.WriteLine($"Array maximum number is: {nums.Max()}");
            Console.WriteLine($"Array average number is: {nums.Average()}");

            double sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double average = sum/nums.Count();
            Console.WriteLine($"The average number is: {average}");
        }

        
    }