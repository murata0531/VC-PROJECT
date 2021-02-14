using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg091_CardsWar
{
    class Player
    {
        public Player()
        {
            CurrCardIndex = -1;
            PrevCardIndex = -1;
            Score = 0;
        }

        public int PrevCardIndex { get; set; }
        
        public int CurrCardIndex { get; set; }
        // 自分の点数
        public int Score { get; set; }

        
        public void Reset()
        {
            PrevCardIndex = CurrCardIndex;
            PrevCardIndex = -1;
        }
    }
}
