using bossfight;
using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hero and Boss fight! ");

        //hero player
        GameCharacter hero = new(100, 20, 10, "Hero");

        //boss player
        GameCharacter boss = new(400, 0, 10, "Boss");

        //for og se om vardiene er riktige

        int round = 0;
        while (hero.Health > 0 && boss.Health > 0)
        {
             Console.WriteLine("---------------------------------------------------------------");
            round++;
            Console.WriteLine("Round: " + round);
            Console.WriteLine("before attack");
            Console.WriteLine($"boss stats: hp = {boss.Health} stamina = {boss.Stamina} strength = {boss.Strength}");
            Console.WriteLine($"hero stats: hp = {hero.Health} stamina = {hero.Stamina}");
            GameCharacter.Fight(hero, boss);
            Console.WriteLine("after attack");
            Console.WriteLine($"boss stats: hp = {boss.Health} stamina = {boss.Stamina}");
            Console.WriteLine($"hero stats: hp = {hero.Health} stamina = {hero.Stamina}");
            Console.WriteLine(" ");

        }

    }
}