using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_TextValidationWithClasses
{
    class FootballRanking
    {
        private FootballClub[] club;

        public FootballRanking()
        {
            for (int i = 0; i < 14; i++)
            {
                string[] clubDetails = Console.ReadLine().Split('-');
                club[i] = new FootballClub(clubDetails[0], Convert.ToInt32(clubDetails[1]) + Convert.ToInt32(clubDetails[2]));
            }
        }

        public FootballClub[] SortFootballRanking(FootballClub[] club)
        {
            FootballClub aux;
            int length = 14;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (club[j].Points() < club[j + 1].Points())
                    {
                        CheckIfSwapingPosition(j, j + 1, club[j].Name(), club[j + 1].Name());
                        aux = club[j];
                        club[j] = club[j + 1];
                        club[j + 1] = aux;
                    }
                }
            }
            return club;
        }

        private void CheckIfSwapingPosition(int index, int nextIndex,string firstClubName, string secondClubName)
        {
            Console.WriteLine("Swapping elements with indexes (" + index + ", " + nextIndex + ") and values (" + firstClubName + ", " + secondClubName + ")");
        }

        private static void ShowFootballRankingTable(FootballClub[] footballClubs)
        {
            for (int i = 0; i < footballClubs.Length; i++)
                Console.WriteLine(footballClubs[i].Name() + "- " + footballClubs[i].Points());
        }
    }
}
