using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleGame
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

        public Gamemode()
        {
            //Man får ett slumpmässigt gamemode.
            Random rnd = new Random();
            int rand = rnd.Next(0, 5);
            this._mode = (Mode)rand;
        }

        public Spelare HighestValueVinnare(List<Spelare> spelareList)
        {
            //om spelaren är namnlös så är det oavgjort.
            Spelare vinnaren = new Spelare();
            int vinnandenmr = 0;
            foreach(Spelare spelare in spelareList)
            {
                int temp = 0;
                foreach(Kort kort in spelare.Hand)
                {
                    temp += kort.Valor;
                }
                if(temp > vinnandenmr)
                {
                    vinnandenmr = temp;
                    vinnaren = spelare;
                }
            }
            return vinnaren;
        }

        public Spelare LowestValueVinnare(List<Spelare> spelareList)
        {
            Spelare vinnaren = new Spelare();
            //största möjliga värdet man kan ha. behövs för att den första spelaren ska kunna ha lägsta
            int vinnandenmr = 39;

            foreach (Spelare spelare in spelareList)
            {
                int temp = 0;

                foreach (Kort kort in spelare.Hand)
                {
                    temp += kort.Valor;
                }
                if (temp < vinnandenmr)
                {
                    vinnandenmr = temp;
                    vinnaren = spelare;
                }
            }
            return vinnaren;
        }

        public Spelare MostOfBlackVinnare(List<Spelare> spelareList)
        {
            Spelare vinnaren = new Spelare();
            int vinnandenmr = 0;
            
            foreach (Spelare spelare in spelareList)
            {
                int temp = 0;
                foreach(Kort kort in spelare.Hand)
                {
                    if(kort.Farg == Kort.kortfarg.klöver || kort.Farg == Kort.kortfarg.spader)
                    {
                        temp++;
                    }
                }
                if(temp > vinnandenmr)
                {
                    vinnandenmr = temp;
                    vinnaren = spelare;
                }
            }
            return vinnaren;
        }

        public Spelare MostOfRedVinnare(List<Spelare> spelareList)
        {
            Spelare vinnaren = new Spelare();
            int vinnandenmr = 0;

            foreach (Spelare spelare in spelareList)
            {
                int temp = 0;
                foreach (Kort kort in spelare.Hand)
                {
                    if (kort.Farg == Kort.kortfarg.hjärter || kort.Farg == Kort.kortfarg.ruter)
                    {
                        temp++;
                    }
                }
                if (temp > vinnandenmr)
                {
                    vinnandenmr = temp;
                    vinnaren = spelare;
                }
            }
            return vinnaren;
        }

        public Spelare MostOfPairVinnare(List<Spelare> spelareList)
        {
            Spelare vinnaren = new Spelare();
            int vinnandenmr = 0;
            foreach (Spelare spelare in spelareList)
            {
                List<int> ValorList = new List<int>();
                foreach(Kort kort in spelare.Hand)
                {
                    ValorList.Add(kort.Valor);
                }

                int nmrofpairs = spelare.Hand.Count - ValorList.Distinct().Count();
                if(nmrofpairs>vinnandenmr)
                {
                    vinnandenmr = nmrofpairs;
                    vinnaren = spelare;
                }
            }
            return vinnaren;
        }
    }
}
