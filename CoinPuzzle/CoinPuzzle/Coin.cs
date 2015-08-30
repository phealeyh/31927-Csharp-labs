using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinPuzzle
{

    enum CoinSide { HEAD, TAIL };

    class Coin
    {
        private CoinSide sideUp;

        public Coin()
        {
            sideUp = CoinSide.HEAD;
        }

        public CoinSide SideUp()
        {
            return sideUp;
        }

        public void FlipCoin()
        {
            if(sideUp == CoinSide.HEAD)
            {
                sideUp = CoinSide.TAIL;
            }
            else
            {
                sideUp = CoinSide.HEAD;
            }
        }


    }
}
