using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballClub
    {
        public readonly string name;
        public  int points;

        public FootballClub(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public bool CheckClubName(string clubName)
        {
            return name == clubName;
        }

        public bool LessThan(FootballClub that)
        {
            return points < that.points;
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
