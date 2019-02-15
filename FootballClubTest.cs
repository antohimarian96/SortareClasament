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
            var secondRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 37), new FootballClub("Dinamo", 30) });
            initialRanking.AddStageResults("Steaua","Dinamo",2,1);           
            Assert.Equal(initialRanking.club[0].points, secondRanking.club[0].points);
            Assert.Equal(initialRanking.club[0].name, secondRanking.club[0].name);
            Assert.Equal(initialRanking.club[1].points, secondRanking.club[1].points);
            Assert.Equal(initialRanking.club[1].name, secondRanking.club[1].name);
        }

        [Fact]
        public void AddStageResultForManyClubs()
        {
            var initialRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 34), new FootballClub("Dinamo", 30), new FootballClub("Viitorul",20), new FootballClub("CFR",19)});
            var secondRanking = new FootballRanking(new FootballClub[] { new FootballClub("Steaua", 35), new FootballClub("Dinamo", 31), new FootballClub("CFR", 22), new FootballClub("Viitorul", 20) });
            initialRanking.AddStageResults("Steaua","Dinamo",1,1);
            initialRanking.AddStageResults("CFR","Viitorul", 2, 0);
            Assert.Equal(initialRanking.club[0].points, secondRanking.club[0].points);
            Assert.Equal(initialRanking.club[0].name, secondRanking.club[0].name);
            Assert.Equal(initialRanking.club[1].points, secondRanking.club[1].points);
            Assert.Equal(initialRanking.club[1].name, secondRanking.club[1].name);
            Assert.Equal(initialRanking.club[2].points, secondRanking.club[2].points);
            Assert.Equal(initialRanking.club[2].name, secondRanking.club[2].name);
            Assert.Equal(initialRanking.club[3].points, secondRanking.club[3].points);
            Assert.Equal(initialRanking.club[3].name, secondRanking.club[3].name);
        }
    }
}
