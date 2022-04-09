// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using SnakeAndLadderGame;
public class program
{
    public static void Main(String[] args)
    {
        SnakeAndLadderGames game = new SnakeAndLadderGames();
        int start = game.dieRolls();
        Console.WriteLine("Welcome in the Game, Your Position is: " + "****" + start + "****");
    }
}

