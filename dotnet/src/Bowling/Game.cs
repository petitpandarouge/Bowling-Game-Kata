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

            return quilles.Sum();
        }
    }
}
