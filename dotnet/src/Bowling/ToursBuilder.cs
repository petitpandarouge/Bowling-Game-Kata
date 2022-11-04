namespace Bowling
{
    public class ToursBuilder
    {
        public Tour[] Build(int[] quilles)
        {
            return new Tour[]
            {
                new Tour(GetQuillesForLance(quilles, 0), GetQuillesForLance(quilles, 1)),
                new Tour(GetQuillesForLance(quilles, 2), GetQuillesForLance(quilles, 3)),
                new Tour(GetQuillesForLance(quilles, 4), GetQuillesForLance(quilles, 5)),
                new Tour(GetQuillesForLance(quilles, 6), GetQuillesForLance(quilles, 7)),
                new Tour(GetQuillesForLance(quilles, 8), GetQuillesForLance(quilles, 9)),
                new Tour(GetQuillesForLance(quilles, 10), GetQuillesForLance(quilles, 11)),
                new Tour(GetQuillesForLance(quilles, 12), GetQuillesForLance(quilles, 13)),
                new Tour(GetQuillesForLance(quilles, 14), GetQuillesForLance(quilles, 15)),
                new Tour(GetQuillesForLance(quilles, 16), GetQuillesForLance(quilles, 17)),
                new Tour(GetQuillesForLance(quilles, 18), GetQuillesForLance(quilles, 19))
            };
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