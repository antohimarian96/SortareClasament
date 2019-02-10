using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballRanking
    {
        private readonly FootballClub[] club;

        public FootballRanking(FootballClub[] club)
        {
            for (int i = 0; i < club.Length; i++)
            {
                this.club[i] = club[i];
            }
        }

        public void AddStageResults(int[] stageResult)
        {
            for (int i = 0; i < club.Length; i++)
            {
                club[i].AddPoints(stageResult[i]);
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
