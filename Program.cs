/// Homework 2 Project 2
/// File Name: Program.cs
/// Author: Lucas Smith
/// Date: September 13, 2021
/// Problem Statement: Write a program that converts degrees Fahrenheit to Celsius using the following formula. 
/// Prompt the user to enter a temperature in degrees Fahrenheit (just a whole number of degrees without a fractional part), and then let the program print out the equivalent Celsius temperature, including the fractional part to one decimal point. 
/// Use the Math.Round(number, decimal) method.
/// 
///
/// Overall Plan:
///  1) Print a welcome message to the console.
///  2) Ask for the temperature in degrees Fahrenheit
///  3) Run the conversion to degreesC and print out the results to the screen, rounded to one decimal place.
using System;

namespace Homework_2_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fahrenheit to Celsius converter!");
            Console.WriteLine("Start by inputting the temperature in Fahrenheit.");
            double degreesF = Double.Parse(Console.ReadLine());
            double degreesC = (5 * (degreesF - 32)) / 9;
            degreesC = Math.Round(degreesC, 1);
            Console.WriteLine("The temperature in degrees Celsius is" + degreesC + " C.");
        }
    }
}
