using System;
using System.Collections.Generic;
using System.Text;

namespace FootballRankingWithClasses
{
    public class FootballRanking
    {
        public FootballClub[] club;
        public StageResult[] results;

        public FootballRanking(FootballClub[] club)
        {
            this.club = new FootballClub[club.Length];
            for (int i = 0; i < club.Length; i++)
            {
                this.club[i] = club[i];
            }
        }

        public void AddStageResults(StageResult[] results)
        {
            results = new StageResult[club.Length / 2];
            for (int i = 0; i < results.Length; i++)
            {
                UpdatePoints(results[i]);
            }
            SortRanking();
        }

        private void UpdatePoints(StageResult stage)
        {
            int result = 3;
           if(stage.CheckIfEqual())
                result = 1;
            for (int i = 0; i < club.Length; i++)
            {
                if (stage.ComparePoints() && club[i].CheckClubName(stage.GetFirstTeamName()))
                    club[i].AddPoints(result);
                if (!stage.ComparePoints() && club[i].CheckClubName(stage.GetSecondTeamName()))
                    club[i].AddPoints(result);
                else
                    club[i].AddPoints(result);
            }
        }
        private void SortRanking()
        {
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
