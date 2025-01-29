/**
A game machine has 5 games installed on it:

string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" }; 
C#
Write a program to take N number as input and output the corresponding game with N index from the array.

If user enters an invalid number that is out of array range, the program should output "Invalid number"
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            //your code goes here
                if( int.TryParse(Console.ReadLine() , out int number) // alternative : int.Parse(Console.Readline()) - In a try Catch function
                )
                {
                    if(number >= 0 && number < games.Length){
                        Console.WriteLine( games[number] );
                    }
                    else {
                        Console.WriteLine("Invalid number");
                    }
                }
                else{
                    Console.WriteLine("Invalid input");
                }
        }
    }
}