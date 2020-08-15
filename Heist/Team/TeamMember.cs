using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heist.Team
{
    class TeamMember
    {
        public string Name { get; set; }

        public int Skill { get; set; }

        public double Courage { get; set; }

        private List<TeamMember> Team = new List<TeamMember>();

        public void createTeamMember(string name, int skill, double courage)
        {
            Team.Add(new TeamMember { Name = name, Skill = skill, Courage = courage });
        }

        public void listTeam()
        {
            var count = Team.Count;

            foreach (var i in Team)
            {
                Console.WriteLine($"Name: {i.Name}, Skill: {i.Skill}, Courage: {i.Courage}\r\n");
            };

            Console.WriteLine($"{count} members on team.\r\n");
        }

        public int sumSkill()
        {
            List<int> skillSum = new List<int>();

            foreach (var i in Team)
            {
                skillSum.Add(i.Skill);
            }

            int result = skillSum.Sum();

            return result;
        }
    }
}
