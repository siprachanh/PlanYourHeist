using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        // create a constructor (to initialize the fields):
        public TeamMember(string name, int skillLvl, decimal courageFact)
        {
            Name = name;
            SkillLevel = skillLvl;
            CourageFactor = courageFact;

        }
        // return values of fields above
        // giving new behavior with override ToString()

        public override string ToString()
        {
            return $"{Name} is at {SkillLevel} skill level and {CourageFactor} courage factor.";
        }
    }
}
// declared fields inside class (TeamMember)




