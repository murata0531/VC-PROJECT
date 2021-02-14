using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg091_CardsWar
{
    class Computer : Player
    {
        private Random rdm;
        private int length;
        private bool[] openCards;

        public Computer(int len)
        {
            rdm = new Random();
            this.length = len;
            openCards = new bool[length];////////////
        }

        public int DrawCard()
        {
            int n = -1;

            //do
            //{
            //    n = rdm.Next(length);
            //}
            //while (n < 0);

            while (n < 0)
            {
                n = rdm.Next(length);
                if (openCards[n] == true)
                    n = -1;
            }
            openCards[n] = true;
            base.CurrCardIndex = n;
            return n;
        }

        public void ClearCards()
        {
            Array.Clear(openCards, 0, openCards.Length);
        }
    }
}
