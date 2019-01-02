using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDA.FantasyPlayers
{
    public class FantasyPlayers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }

        public string PlayerFullDetails()
        {
            return $"{FirstName} {LastName}, {Position} for the {Team} age {Age}";
        }
    }
}
