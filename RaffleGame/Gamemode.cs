using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortspelsDemo2022
{
    class Gamemode
    {
        public int ID
        {
            get { return (int)this._mode; }
        }

        public enum Mode
        {
            HighestValue,
            LowestValue,
            MostOfBlack,
            MostOfRed,
            MostOfPair
        }

        private Mode _mode;
        public Mode mode
        {
            get { return this._mode; }
        }

        public Gamemode(Mode mode)
        {
            this._mode = mode;
        }
    }
}
