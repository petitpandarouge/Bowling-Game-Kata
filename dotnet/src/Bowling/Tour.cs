using System;

namespace Bowling
{
    public class Tour
    {
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
                _quillesFirstLance < 10 && 
                _quillesFirstLance + _quillesSecondLance == 10;
        }
    }
}