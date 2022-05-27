using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("-----------------");

            List<TeamMember> teamList = new List<TeamMember>();




            Console.Write("Enter a team member's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a team member's skill level:");
            string skill = Console.ReadLine();
            int skillLvl = int.Parse(skill);

            Console.Write("Enter team member's courage factor (0.0 - 2.0):");
            string courage = Console.ReadLine();
            decimal courageFact = decimal.Parse(courage);
            // test courageFact 0-2
            // 
            while (courageFact < 0 || courageFact > 2)
            {
                Console.Write("Enter team member's courage factor (0.0 - 2.0):");
                courage = Console.ReadLine();
                courageFact = decimal.Parse(courage);

            }

            TeamMember firstMember = new TeamMember(name, skillLvl, courageFact);
            teamList.Add(firstMember);

            Console.WriteLine(teamList[0]);
            Team newTeam = new Team(teamList);
            // define new skill variable
            int skillSum = 0;
            skillSum += skillLvl;
            // newTeam.Description();

            while (true)
            {
                Console.Write("Enter a team member's name: ");
                name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {


                    Console.Write("Enter a team member's skill level:");
                    skill = Console.ReadLine();
                    skillLvl = int.Parse(skill);
                    skillSum += skillLvl;

                    Console.Write("Enter team member's courage factor:");
                    courage = Console.ReadLine();

                    courageFact = decimal.Parse(courage);

                    while (courageFact < 0 || courageFact > 2)
                    {
                        Console.Write("Enter team member's courage factor (0.0 - 2.0):");
                        courage = Console.ReadLine();
                        courageFact = decimal.Parse(courage);

                    }

                    TeamMember thisMember = new TeamMember(name, skillLvl, courageFact);
                    teamList.Add(thisMember);


                }


                // instantiating/initializing the obj
                TeamMember member = new TeamMember(name, skillLvl, courageFact);

            }
            newTeam.Description();
            Console.WriteLine("How many times do you want to run this?");
            string runTrial = Console.ReadLine();
            int trialRun = int.Parse(runTrial);

            int i = 0;
            while (i < trialRun)
            {
                Random rnd = new Random();
                int randomNum = rnd.Next(-10, 11);
                // generate min/max int


                Bank thisBank = new Bank(100 + randomNum);
                Console.WriteLine($"Combined skill level is: {skillSum}");
                Console.WriteLine($"The bank's difficulty level is: {thisBank.Difficulty}");

                if (skillSum >= thisBank.Difficulty)
                {

                    Console.WriteLine("You robbed the bank!");
                }
                else
                {
                    Console.WriteLine("Try again next time.");
                }
                i++;
            }
        }
    }
}
// decimal.Parse 
