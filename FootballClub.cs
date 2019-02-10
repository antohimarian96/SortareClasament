using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballClub
    {
        private readonly string name;
        private  int points;

        public FootballClub(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public bool LessThan(FootballClub that)
        {
            if (points < that.points)
                return true;
            return false;
        }

        public void AddPoints(int stagePoints)
        {
            points = points + stagePoints;
        }

        public string GetResult()
        {
            string result;
            result = name + Convert.ToString(points);
            return result;
        }
    }
}
