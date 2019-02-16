using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class StageResult
    {
        private readonly string firstTeamName;
        private readonly string secondTeamName;
        private int firstTeamScore;
        private int secondTeamScore;

        public StageResult(string firstTeamName, string secondTeamName, int firstTeamScore, int secondTeamScore)
        {
            this.firstTeamName = firstTeamName;
            this.secondTeamName = secondTeamName;
            this.firstTeamScore = firstTeamScore;
            this.secondTeamScore = secondTeamScore;
        }

        public bool CheckIfEqual()
        {
            return firstTeamScore == secondTeamScore;
        }
       
        public string GetWinner()
        {
            if (firstTeamScore > secondTeamScore)
                return firstTeamName;
            else
                return secondTeamName;
        }
    }
}
