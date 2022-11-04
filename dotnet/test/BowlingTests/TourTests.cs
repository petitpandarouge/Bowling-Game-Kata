using FluentAssertions;
using NUnit.Framework;

namespace Bowling.Tests
{
    [TestFixture]
    public class TourTests
    {
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
    }
}
