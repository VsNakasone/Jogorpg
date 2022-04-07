using System;
using Jogorpg.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Wands knight = new Wands("Knight", 14, "Fire");
        Cups queen = new Cups("Queen", 15, "Water");
        Pentacles ace = new Pentacles( "Ace", 17, "Earth");
        Swords king = new Swords("King", 20, "Air");

        Console.WriteLine( knight.Attack(5));
        Console.WriteLine(queen.Attack(9));
        Console.WriteLine(ace.Attack(4));
        Console.WriteLine(king.Attack(7));
    }
}
