using FluentAssertions;
using NUnit.Framework;
using System;
using System.Linq;

namespace Bowling.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game _game;

        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }

        [Test]
        public void Given_an_empty_game_Then_score_Should_be_0()
        {
            // Arrange
            var noPoint = Array.Empty<int>();

            // Act
            var score = _game.Score(noPoint);

            // Assert
            score
                .Should()
                .Be(0);
        }

        [Test]
        public void Given_a_game_with_one_lance_Then_score_Should_be_quille_count()
        {
            // Arrange
            var oneLance = new int[] { 1 };

            // Act
            var score = _game.Score(oneLance);

            // Assert
            score
                .Should()
                .Be(oneLance.Sum());
        }
    }
}