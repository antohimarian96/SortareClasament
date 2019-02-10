using FootballRankingWithClasses;
using System;
using Xunit;

namespace FootballRankingTest
{
    public class FootballRankingTest
    {

        [Fact]
        public void Test1()
        {
            var initialRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 34), new FootballClub("Dinamo", 30) });
            var secondRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 35), new FootballClub("Dinamo", 33) });
            initialRanking.AddStageResults(new int[] { 1, 3 });
            Assert.Equal(secondRanking,initialRanking);
        }
    }
}
