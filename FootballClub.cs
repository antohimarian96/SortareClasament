using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_TextValidationWithClasses
{
    class FootballClub
    {
        private readonly string name;
        private readonly int points;

        public FootballClub(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public int Points()
        {
            return points;
        }

        public string Name()
        {
            return name;
        }
    }
}
