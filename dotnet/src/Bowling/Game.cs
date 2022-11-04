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

            int bonus = 0;

            var firstTour = new Tour(GetQuillesForLance(quilles, 0), GetQuillesForLance(quilles, 1));
            if (firstTour.IsSpare())
            {
                bonus = GetQuillesForLance(quilles, 2);
            }

            var secondTour = new Tour(GetQuillesForLance(quilles, 2), GetQuillesForLance(quilles, 3));
            if (secondTour.IsSpare())
            {
                bonus += GetQuillesForLance(quilles, 4);
            }

            var thirdTour = new Tour(GetQuillesForLance(quilles, 4), GetQuillesForLance(quilles, 5));
            if (thirdTour.IsSpare())
            {
                bonus += GetQuillesForLance(quilles, 6);
            }

            return quilles.Sum() + bonus;
        }

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
