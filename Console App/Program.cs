using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            int armor;
            int damage;

            Console.Write("Enter your HP:");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your armor point:");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter damage point:");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage / 100 * armor;

            Console.WriteLine("After you take " + damage + " points of damage, you have " + health + "HP left.");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
