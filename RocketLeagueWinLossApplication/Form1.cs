using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketLeagueWinLossApplication
{
    public partial class Form1 : Form
    {
        private int winCount, lossCount, difference;
        private double winLossRatio;

        public Form1()
        {
            //component initialization
            InitializeComponent();

            //variable initializers
            winCount = 0;
            lossCount = 0;
            difference = 0;
            winLossRatio = 0.0;

            //method calls
            updateAll();
            //SetWinCount(winCount);
            //SetLossCount(lossCount);
            //SetDifferenceLabel(difference);
            //SetRatioLabel(winLossRatio);

        }

        private void SetDifferenceLabel(int difference)
        {
            DifferenceLabel.Text = difference.ToString();
        }

        private void SetWinCount(int numberOfWins)
        {
            WinCountLabel.Text = numberOfWins.ToString();
        }

        private void SetLossCount(int numberOfLosses)
        {
            LossCountLabel.Text = numberOfLosses.ToString();
        }

        private void SetRatioLabel(double wLRatio)
        {           
            RatioLabel.Text = string.Format("{0:N2}%",wLRatio);
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
            
            SetRatioLabel(winLossRatio);            
        }

        private void updateDifference()
        {
            difference = winCount - lossCount;
            SetDifferenceLabel(difference);
        }

        private void incrementWinCount()
        {
            winCount++;
            updateAll();
        }

        private void incrementLossCount()
        {
            lossCount++;
            updateAll();
        }

        private void ResetAndUpdateStats()
        {
            winCount = 0;
            lossCount = 0;
            updateAll();
        }

        private void updateAll()
        {
            SetWinCount(winCount);
            SetLossCount(lossCount);
            updateWinLossRatio();
            updateDifference();
        }

        private void WinButton_Click(object sender, EventArgs e)
        {
            incrementWinCount();
        }

        private void LossButton_Click(object sender, EventArgs e)
        {
            incrementLossCount();
        }

        //Reset button forgot to change the name
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetAndUpdateStats();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
