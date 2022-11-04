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
        [Parallelizable(ParallelScope.All)]
        public void Given_a_game_with_one_lance_Then_score_Should_be_quille_count(
            [Range(0, 10, 1)] int quilles)
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

        static int[][] Given_a_game_with_one_tour_Then_score_Should_be_quille_count_Cases =
        {
            new int[] { 0 , 0 },
            new int[] { 0 , 1 },
            new int[] { 0 , 2 },
            new int[] { 0 , 3 },
            new int[] { 0 , 4 },
            new int[] { 0 , 5 },
            new int[] { 0 , 6 },
            new int[] { 0 , 7 },
            new int[] { 0 , 8 },
            new int[] { 0 , 9 },
            new int[] { 0 , 10 },
            new int[] { 1 , 0 },
            new int[] { 1 , 1 },
            new int[] { 1 , 2 },
            new int[] { 1 , 3 },
            new int[] { 1 , 4 },
            new int[] { 1 , 5 },
            new int[] { 1 , 6 },
            new int[] { 1 , 7 },
            new int[] { 1 , 8 },
            new int[] { 1 , 9 },
            new int[] { 2 , 0 },
            new int[] { 2 , 1 },
            new int[] { 2 , 2 },
            new int[] { 2 , 3 },
            new int[] { 2 , 4 },
            new int[] { 2 , 5 },
            new int[] { 2 , 6 },
            new int[] { 2 , 7 },
            new int[] { 2 , 8 },
            new int[] { 3 , 0 },
            new int[] { 3 , 1 },
            new int[] { 3 , 2 },
            new int[] { 3 , 3 },
            new int[] { 3 , 4 },
            new int[] { 3 , 5 },
            new int[] { 3 , 6 },
            new int[] { 3 , 7 },
            new int[] { 4 , 0 },
            new int[] { 4 , 1 },
            new int[] { 4 , 2 },
            new int[] { 4 , 3 },
            new int[] { 4 , 4 },
            new int[] { 4 , 5 },
            new int[] { 4 , 6 },
            new int[] { 5 , 0 },
            new int[] { 5 , 1 },
            new int[] { 5 , 2 },
            new int[] { 5 , 3 },
            new int[] { 5 , 4 },
            new int[] { 5 , 5 },
            new int[] { 6 , 0 },
            new int[] { 6 , 1 },
            new int[] { 6 , 2 },
            new int[] { 6 , 3 },
            new int[] { 6 , 4 },
            new int[] { 7 , 0 },
            new int[] { 7 , 1 },
            new int[] { 7 , 2 },
            new int[] { 7 , 3 },
            new int[] { 8 , 0 },
            new int[] { 8 , 1 },
            new int[] { 8 , 2 },
            new int[] { 9 , 0 },
            new int[] { 9 , 1 },
            new int[] { 10 , 0 }
        };

        [Test]
        [TestCaseSource(nameof(Given_a_game_with_one_tour_Then_score_Should_be_quille_count_Cases))]
        [Parallelizable(ParallelScope.All)]
        public void Given_a_game_with_one_tour_Then_score_Should_be_quille_count(int quillesFirstLance, int quillesSecondLance)
        {
            // Arrange
            var oneTour = new int[] { quillesFirstLance, quillesSecondLance };

            // Act
            var score = _game.Score(oneTour);

            // Assert
            score
                .Should()
                .Be(oneTour.Sum(), "Le score d'un tour est le nombre total de quilles renversées");
        }

        static object[] Given_a_tour_Then_if_all_the_quilles_are_fallen_in_two_lances_Should_be_a_spare_Cases =
        {
            new object[] { 0 , 0, false },
            new object[] { 0 , 1, false },
            new object[] { 0 , 2, false },
            new object[] { 0 , 3, false },
            new object[] { 0 , 4, false },
            new object[] { 0 , 5, false },
            new object[] { 0 , 6, false },
            new object[] { 0 , 7, false },
            new object[] { 0 , 8, false },
            new object[] { 0 , 9, false },
            new object[] { 0 , 10, true },
            new object[] { 1 , 0, false },
            new object[] { 1 , 1, false },
            new object[] { 1 , 2, false },
            new object[] { 1 , 3, false },
            new object[] { 1 , 4, false },
            new object[] { 1 , 5, false },
            new object[] { 1 , 6, false },
            new object[] { 1 , 7, false },
            new object[] { 1 , 8, false },
            new object[] { 1 , 9, true },
            new object[] { 2 , 0, false },
            new object[] { 2 , 1, false },
            new object[] { 2 , 2, false },
            new object[] { 2 , 3, false },
            new object[] { 2 , 4, false },
            new object[] { 2 , 5, false },
            new object[] { 2 , 6, false },
            new object[] { 2 , 7, false },
            new object[] { 2 , 8, true },
            new object[] { 3 , 0, false },
            new object[] { 3 , 1, false },
            new object[] { 3 , 2, false },
            new object[] { 3 , 3, false },
            new object[] { 3 , 4, false },
            new object[] { 3 , 5, false },
            new object[] { 3 , 6, false },
            new object[] { 3 , 7, true },
            new object[] { 4 , 0, false },
            new object[] { 4 , 1, false },
            new object[] { 4 , 2, false },
            new object[] { 4 , 3, false },
            new object[] { 4 , 4, false },
            new object[] { 4 , 5, false },
            new object[] { 4 , 6, true },
            new object[] { 5 , 0, false },
            new object[] { 5 , 1, false },
            new object[] { 5 , 2, false },
            new object[] { 5 , 3, false },
            new object[] { 5 , 4, false },
            new object[] { 5 , 5, true },
            new object[] { 6 , 0, false },
            new object[] { 6 , 1, false },
            new object[] { 6 , 2, false },
            new object[] { 6 , 3, false },
            new object[] { 6 , 4, true },
            new object[] { 7 , 0, false },
            new object[] { 7 , 1, false },
            new object[] { 7 , 2, false },
            new object[] { 7 , 3, true },
            new object[] { 8 , 0, false },
            new object[] { 8 , 1, false },
            new object[] { 8 , 2, true },
            new object[] { 9 , 0, false },
            new object[] { 9 , 1, true },
            new object[] { 10 , 0, false }
        };

        [Test]
        [TestCaseSource(nameof(Given_a_tour_Then_if_all_the_quilles_are_fallen_in_two_lances_Should_be_a_spare_Cases))]
        [Parallelizable(ParallelScope.All)]
        public void Given_a_tour_Then_if_all_the_quilles_are_fallen_in_two_lances_Should_be_a_spare(int quillesFirstLance, int quillesSecondLance, bool expectedResult)
        {
            // Arrange
            var tour = new Tour(quillesFirstLance, quillesSecondLance);

            // Act
            var result = tour.IsSpare();

            // Assert
            result
                .Should()
                .Be(expectedResult, "Un spare est quand le joueur renverse les 10 quilles en 2 lancés lors d'un tour");
        }

        [Test]
        [Parallelizable(ParallelScope.All)]
        public void Given_the_first_tour_with_spare_Then_score_Should_take_in_account_quilles_count_new_lance(
            [Range(0, 10, 1)] int quillesNextLance)
        {
            // Arrange
            var quilles = new int[] { 2, 8, quillesNextLance };

            // Act
            var score = _game.Score(quilles);

            // Assert
            score
                .Should()
                .Be(quilles.Sum() + quillesNextLance, "Le bonus pour un spare est le nombre de quilles renversées par le prochain lancé.");
        }

        [Test]
        public void Given_two_tours_with_spare_Then_score_Should_take_in_account_quilles_count_new_lance()
        {
            // Arrange
            var firstLance = 2;
            var secondLance = 8;
            var thirdLance = 5;
            var fourthLance = 5;
            var fifthLance = 6;
            var quilles = new int[] { firstLance, secondLance, thirdLance, fourthLance, fifthLance };

            // Act
            var score = _game.Score(quilles);

            // Assert
            score
                .Should()
                .Be(quilles.Sum() + thirdLance + fifthLance, "Le bonus pour un spare est le nombre de quilles renversées par le prochain lancé.");
        }
    }
}