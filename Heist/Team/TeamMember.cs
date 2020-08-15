﻿using System;
using System.Collections.Generic;
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
            foreach (var i in Team)
            {
                Console.WriteLine($"{i.Name} {i.Skill} {i.Courage}");
            }
        }
    }
}