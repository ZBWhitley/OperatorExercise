﻿using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

           
            if (a == 17 && b == 4);
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double r = radius;
            double pi = 3.14159265359;
            double multiply = radius * radius;


            double answer = (pi * multiply);

            Console.WriteLine($"The area of a circle with the radius of {radius} is {answer}");


        }
    }
}
