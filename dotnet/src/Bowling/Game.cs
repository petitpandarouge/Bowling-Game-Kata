using System.Linq;

namespace Bowling
{
    public class Game
    {
        public int Score(int[] quilles)
        {
            if (quilles.Any() == false)
            {
                return 0;
            }

            var firstTour = new Tour(GetQuillesForLance(quilles, 0), GetQuillesForLance(quilles, 1));
            var secondTour = new Tour(GetQuillesForLance(quilles, 2), GetQuillesForLance(quilles, 3));
            var thirdTour = new Tour(GetQuillesForLance(quilles, 4), GetQuillesForLance(quilles, 5));
            var fourthTour = new Tour(GetQuillesForLance(quilles, 6), GetQuillesForLance(quilles, 7));

            int score = firstTour.Score() +
                secondTour.Score(firstTour) +
                thirdTour.Score(secondTour) +
                fourthTour.Score(thirdTour);

            return score;
        }

        // TODO : tester cette méthode aux limites.
        private int GetQuillesForLance(int[] quilles, int index)
        {
            if (index < 0 || index >= quilles.Length)
            {
                return 0;
            }

            return quilles[index];
        }
    }
}
