using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballRanking
    {
        public FootballClub[] club;

        public FootballRanking(FootballClub[] club)
        {
            this.club = new FootballClub[club.Length];
            for (int i = 0; i < club.Length; i++)
            {
                this.club[i] = club[i];
            }
        }

        public void AddStageResults(string firstTeam, string secondTeam, int firstTeamScor, int secondTeamScor)
        {
            int result = 3;
            if (firstTeamScor == secondTeamScor)
                result = 1;
            for (int i = 0; i < club.Length; i++)
            {
                if (firstTeamScor >= secondTeamScor && club[i].CheckClubName(firstTeam))
                    club[i].AddPoints(result);
                if (secondTeamScor >= firstTeamScor && club[i].CheckClubName(secondTeam))
                    club[i].AddPoints(result);
            }
            FootballClub aux;
            for (int i = 0; i < club.Length; i++)
            {
                for (int j = 0; j < club.Length - 1; j++)
                {
                    if (club[j].LessThan(club[j + 1]))
                    {
                        
                        aux = club[j];
                        club[j] = club[j + 1];
                        club[j + 1] = aux;
                    }
                }
            }
        }

        public string[] GetResult()
        {
            string[] result = new string[club.Length];
            for (int i = 0; i < club.Length; i++)
                result[i] = result[i] + club[i].GetResult();
            return result;
        }
    }
}
