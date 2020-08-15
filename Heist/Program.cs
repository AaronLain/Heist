using Heist.Team;
using Heist.Banks;
using System;

namespace Heist
{
    class Program
    {   
        static void Main(string[] args)
        {
            var newTeam = new TeamMember();
            var bank = new Bank(100);

            Console.WriteLine("Plan your heist! Press Enter");

            var input = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter Team Member's name: ");
                string tName = Console.ReadLine();
                
                if (tName == "exit" || tName == "")
                {
                    break;
                }

                Console.WriteLine("Now enter their skill level: ");
                var tSkill = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now enter their courage factor (with decimals please): ");
                var tCourage = Convert.ToDouble(Console.ReadLine());

                newTeam.createTeamMember(tName, tSkill, tCourage);

            } while (input != "" || input != "exit");

            int result = newTeam.sumSkill();

            Console.WriteLine($"Skill: {result}, Difficulty: {bank.BankDifficulty}\r\n");

            if (result > bank.BankDifficulty)
            {
                Console.WriteLine("You successfully robbed the bank!");
            }
            else
            {
                Console.WriteLine("You failed! Looks like you're going to jail.");
                }
        }
    }
}
