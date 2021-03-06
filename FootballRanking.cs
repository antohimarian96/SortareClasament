﻿using System;
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

        public void AddStageResult(StageResult result)
        {
            UpdatePoints(result);
            SortRanking();
        }

        private void UpdatePoints(StageResult stage)
        {
            int result = 3;
            for (int i = 0; i < club.Length; i++)
            {
                if (club[i].CheckClubName(stage.GetWinner()))
                    club[i].AddPoints(result);
                if (stage.CheckIfEqual() && (club[i].CheckClubName(stage.GetFirstTeamName()) || club[i].CheckClubName(stage.GetFirstTeamName())))
                {
                    result = 1;
                    club[i].AddPoints(result);
                }

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
