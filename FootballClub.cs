using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballClub
    {
        private readonly string name;
        private readonly int points;

        public FootballClub(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public bool CompareTo(FootballClub that)
        {
            if (points < that.points)
                return true;
            return false;
        }

        public int AddPoints(FootballClub that)
        {
            int result = 0;
            result = points + that.points;
            return result;
        }

        public string GetResult()
        {
            string result;
            result = name + Convert.ToString(points);
            return result;
        }
    }
}
