using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    public class Bank
    {
        // set the property
        public int Difficulty { get; set; }

        // constructor for Bank
        public Bank(int diff)
        {
            Difficulty = diff;
        }

    }
}