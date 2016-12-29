using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLeagueWinLossApplication.src
{
    class MatchHistory
    {
        private int winCount, lossCount, difference;
        private double winLossRatio;
        public MatchHistory()
        {
            winCount = 0;
            lossCount = 0;
            difference = 0;
            winLossRatio = 0.0;
        }

        private void updateWinLossRatio()
        {
            try
            {
                winLossRatio = (double)winCount / (double)lossCount;
            }
            catch (DivideByZeroException)
            {
                winLossRatio = (double)winCount;
            }

        }

        private void updateDifference()
        {
            difference = winCount - lossCount;
        }

        public void incrementWinCount()
        {
            winCount++;
            updateAll();
        }

        public int getDifference()
        {
            return difference;
        }

        public int getNumberOfWins()
        {
            return winCount;
        }

        public int getNumberOfLosses()
        {
            return lossCount;
        }

        public double getWinLossRatio()
        {
            return winLossRatio;
        }

        public void incrementLossCount()
        {
            lossCount++;
            updateAll();
        }

        public void ResetAndUpdateStats()
        {
            winCount = 0;
            lossCount = 0;
            updateAll();
        }

        private void updateAll()
        {
            updateWinLossRatio();
            updateDifference();
        }

    }
}
