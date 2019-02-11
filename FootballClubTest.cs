using FootballRankingWithClasses;
using System;
using Xunit;

namespace FootballRankingTest
{
    public class FootballRankingTest
    {

        [Fact]
        public void AddStageResultForTwoClubs()
        {
            var initialRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 34), new FootballClub("Dinamo", 30) });
            var secondRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 35), new FootballClub("Dinamo", 33) });
            initialRanking.AddStageResults(new int[] { 1, 3 });           
            if (initialRanking.club.Length == secondRanking.club.Length)
            {
                for (int i = 0; i < initialRanking.club.Length; i++)
                {
                    Assert.Equal(initialRanking.club[i].points, secondRanking.club[i].points);
                    Assert.Equal(initialRanking.club[i].name, secondRanking.club[i].name);
                }
            }
            else
                Assert.False(true);
        }

        [Fact]
        public void AddStageResultForManyClubs()
        {
            var initialRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 34), new FootballClub("Dinamo", 30), new FootballClub("Viitorul",20), new FootballClub("CFR",19)});
            var secondRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 35), new FootballClub("Dinamo", 33), new FootballClub("CFR", 22), new FootballClub("Viitorul", 21) });
            initialRanking.AddStageResults(new int[] { 1, 3, 1,3});
            if (initialRanking.club.Length == secondRanking.club.Length)
            {
                for (int i = 0; i < initialRanking.club.Length; i++)
                {
                    Assert.Equal(initialRanking.club[i].points, secondRanking.club[i].points);
                    Assert.Equal(initialRanking.club[i].name, secondRanking.club[i].name);
                }
            }
            else
                Assert.False(true);
        }
    }
}
