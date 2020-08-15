using Heist.Team;
using System;

namespace Heist
{
    class Program
    {   
        static void Main(string[] args)
        {
            var newt = new TeamMember();

            Console.WriteLine("Plan your heist!");
            Console.WriteLine("Enter Team Member's name: ");
            var tName = Console.ReadLine();

            Console.WriteLine("Now enter their skill level: ");
            var tSkill = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter their courage factor (with decimals please): ");
            var tCourage = Convert.ToDouble(Console.ReadLine());

            newt.createTeamMember(tName, tSkill, tCourage);
              
            newt.listTeam();

        }
    }
}
