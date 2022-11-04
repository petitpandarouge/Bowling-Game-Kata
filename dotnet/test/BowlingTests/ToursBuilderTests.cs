using FluentAssertions;
using NUnit.Framework;

namespace Bowling.Tests
{
    [TestFixture]
    public class ToursBuilderTests
    {
        private ToursBuilder _builder;

        [SetUp]
        public void Setup()
        {
            _builder = new ToursBuilder();
        }

        [Test]
        public void Given_a_list_of_twety_lances_Then_if_we_build_the_tours_Should_build_ten_tours()
        {
            // Arrange
            var oneQuille = 1;
            var twoQuilles = 2;
            var threeQuilles = 3;
            var fourQuilles = 4;
            var fiveQuilles = 5;
            var quilles = new int[] 
            { 
                oneQuille, twoQuilles, 
                threeQuilles, fourQuilles,
                fiveQuilles, oneQuille,
                twoQuilles, threeQuilles,
                fourQuilles, fiveQuilles,
                oneQuille, twoQuilles,
                threeQuilles, fourQuilles,
                fiveQuilles, oneQuille,
                twoQuilles, threeQuilles,
                fourQuilles, fiveQuilles
            };

            // Act
            var tours = _builder.Build(quilles);

            // Assert
            tours
                .Should()
                .HaveCount(10, "Une partie se fait en 10 tours de 2 lancés.");
        }
    }
}
