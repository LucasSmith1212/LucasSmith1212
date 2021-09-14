/// Homework 2 Project 1
/// File Name: homework2.sln
/// Author: Lucas Smith
/// Date:  September 13, 2021
/// Problem Statement: Output your name in Pig Latin.
/// 
/// 
/// Overall Plan:
/// 1) Setup the individual variables to store the normal first and last names, and then pig first and last names.
/// 2) Setup an algorithm to change the name 
/// 3) Print the Pig Latin version to the screen.


using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            String first = "Lucas";
            String last = "Smith";
            String pigFirstName;
            String pigLastName;

            first = first.ToLower();
            last = last.ToLower();
            pigFirstName = first.Substring(1, 4) + first.Substring(0,1) + "ay";
            pigFirstName = pigFirstName.Substring(0, 1).ToUpper() + pigFirstName.Substring(1,6);
            pigLastName = last.Substring(1, 4) + last.Substring(0, 1) + "ay";
            pigLastName = pigLastName.Substring(0, 1).ToUpper() + pigLastName.Substring(1,6);
            Console.WriteLine(pigFirstName + " " + pigLastName);
        
        }
    }
}
