using FluentAssertions;
using NUnit.Framework;
using System;

namespace Bowling.Tests
{
    [TestFixture]
    public class GameTests
    {

        [Test]
        public void Given_an_empty_game_Then_score_should_be_0()
        {
            Game game = new();
            var noPoint = Array.Empty<int>();

            game.Score(noPoint).Should().Be(0, "Une partie vide doit retourner un score nul");

        }
    }
}