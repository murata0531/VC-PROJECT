using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg090_Palmanism
{
    class Player
    {

        private int presentOpenCardIndex1;
        private int presentOpenCardIndex2;


        public Player()
        {
            PresentOpenCardIndex1 = PresentOpenCardIndex2 = -1;
            PreviousOpenCardIndex1 = PreviousOpenCardIndex2 = -1;
            OpenCounter = 0;
        }

        public int PresentOpenCardIndex1
        {
            get { return presentOpenCardIndex1; }
            set
            {
                presentOpenCardIndex1 = value;
                OpenCounter++;
            }
        }

        public int PresentOpenCardIndex2
        {
            get { return presentOpenCardIndex2; }
            set
            {
                presentOpenCardIndex2 = value;
                OpenCounter++;
            }
        }

        public int PreviousOpenCardIndex1 { get; set; }
        public int PreviousOpenCardIndex2 { get; set; }

        public int OpenCounter { get; set; }

        public void Reset()
        {
            PreviousOpenCardIndex1 = PresentOpenCardIndex1;
            PreviousOpenCardIndex2 = PresentOpenCardIndex2;
            PresentOpenCardIndex1 = -1;
            PresentOpenCardIndex2 = -1;
            OpenCounter = 0;
        }
    }
}
