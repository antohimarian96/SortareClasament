using System;
using Xunit;

namespace JSON_Text.Test
{
    public class ProgramTest
    {
        [Fact]
        public void TestCharacterWhenIsTrue()
        {
            var character = new Character('a');
            var answear = character.Match("abcd");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestCharacterWhenIsFalse()
        {
            var character = new Character('b');
            var answear = character.Match("abcd");
            Assert.False(answear.Success());
        }

        [Fact]
        public void TestCharacterWhenIsNull()
        {
            var character = new Character(' ');
            var answear = character.Match("abcd");
            Assert.False(answear.Success());
        }

        [Fact]
        public void TestRangeWhenIsInside()
        {
            var range = new Range('a', 'g');
            var answear = range.Match("bc");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestRangeWhenIsAtHalf()
        {
            var range = new Range('a', 'e');
            var answear = range.Match("c");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestRangeWhenIsOutSide()
        {
            var range = new Range('a', 'e');
            var answear = range.Match("f");
            Assert.False(answear.Success());
        }

        [Fact]
        public void TestChoiceWhenWeHaveCharacterAndRange()
        {
            var digit = new Choice(
               new Character('0'),
               new Range('1', '5'),
               new Range('a', 'm')
            );
            var answear = digit.Match("012");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestChoiceWhenIsTrue()
        {
            var digit = new Choice(
               new Character('0'),
               new Range('1', '9')
            );

            var hex = new Choice(
               digit,
               new Choice(
               new Range('a', 'f'),
               new Range('A', 'F')
                         )
            );
            var answear = hex.Match("F8");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestMatch_RemainingText()
        {
            var digit = new Sequance(
               new Character('0'),
               new Character('1'),
               new Range('A','E')
            );
            var answear = digit.Match("01AF");
            Assert.Equal("F",answear.RemainingText());
        }

        [Fact]
        public void TestSequanceWhenHaveManyCombinations()
        {
            var hex = new Choice(
                 new Range('0', '9'),
                 new Range('a', 'f'),
                  new Range('A', 'F')
                );

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var answear = hexSeq.Match("u1234");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestSequanceWhenIsTrueAndHaveRemainingText()
        {
            var hex = new Choice(
                 new Range('0', '9'),
                 new Range('a', 'f'),
                  new Range('A', 'F')
                );

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var answear = hexSeq.Match("uB005 ab");
            Assert.True(answear.Success());
        }

        [Fact]
        public void TestSequanceWhenIsFalseAndHaveRemainingText()
        {
            var hex = new Choice(
                 new Range('0', '9'),
                 new Range('a', 'f'),
                  new Range('A', 'F')
                );

            var hexSeq = new Sequance(
                new Character('u'),
                new Sequance(
                    hex,
                    hex,
                    hex,
                    hex
                )
            );
            var answear = hexSeq.Match("abc");
            Assert.False(answear.Success());
        }


    }
}
