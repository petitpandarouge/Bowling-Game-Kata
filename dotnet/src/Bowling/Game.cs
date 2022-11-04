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
