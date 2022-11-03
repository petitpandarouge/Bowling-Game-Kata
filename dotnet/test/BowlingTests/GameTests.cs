using FluentAssertions;
using NUnit.Framework;
using System;

namespace Bowling.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Given_an_empty_game_Then_score_Should_be_0()
        {
            // Arrange
            Game game = new();
            var noPoint = Array.Empty<int>();

            // Act
            // Nothing to do.

            // Assert
            game
                .Score(noPoint)
                .Should()
                .Be(0);
        }
    }
}