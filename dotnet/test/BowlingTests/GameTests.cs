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
                .Be(0, "La partie à vide (aucune quille tombée) a un score total de 0 point");
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [Parallelizable(ParallelScope.All)]
        public void Given_a_game_with_one_lance_Then_score_Should_be_quille_count(int quilles)
        {
            // Arrange
            var oneLance = new int[] { quilles };

            // Act
            var score = _game.Score(oneLance);

            // Assert
            score
                .Should()
                .Be(oneLance.Sum(), "Le score d'un tour est le nombre total de quilles renversées");
        }
    }
}