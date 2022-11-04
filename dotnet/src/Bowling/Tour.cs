namespace Bowling
{
    public class Tour
    {
        private const int QUILLES_MAX_COUNT = 10;
        private int _quillesFirstLance;
        private int _quillesSecondLance;

        public Tour(int quillesFirstLance, int quillesSecondLance)
        {
            _quillesFirstLance = quillesFirstLance;
            _quillesSecondLance = quillesSecondLance;
        }

        public bool IsSpare()
        {
            return
                AreAllQuillesFallenInTheFirstLance() == false &&
                AreAllQuillesFallenWithTwoLances();
        }

        public int Score()
        {
            return _quillesFirstLance + _quillesSecondLance;
        }

        public int Score(Tour previousTour)
        {
            int score = Score();
            if (previousTour.IsSpare())
            {
                score += _quillesFirstLance;
            }

            return score;
        }

        private bool AreAllQuillesFallenWithTwoLances()
        {
            return _quillesFirstLance + _quillesSecondLance == QUILLES_MAX_COUNT;
        }

        private bool AreAllQuillesFallenInTheFirstLance()
        {
            return _quillesFirstLance == QUILLES_MAX_COUNT;
        }
    }
}