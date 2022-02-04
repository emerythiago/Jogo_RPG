using Dungeon_RPG.Entities;
using System;

namespace Dungeon_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack());
        }
    }
}
