using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RocketLeagueWinLossApplication.src;


namespace RocketLeagueWinLossApplication
{
    public partial class Form1 : Form
    {

        private MatchHistory matchHistory;

        public Form1()
        {
            //component initialization
            InitializeComponent();

            //variable initializers
            matchHistory = new MatchHistory();


            //method calls
            updateAll();
            //SetWinCount(winCount);
            //SetLossCount(lossCount);
            //SetDifferenceLabel(difference);
            //SetRatioLabel(winLossRatio);

        }

        //text setters
        private void SetDifferenceLabel()
        {
            DifferenceLabel.Text = matchHistory.getDifference().ToString();
        }

        private void SetWinCount()
        {
            WinCountLabel.Text = matchHistory.getNumberOfWins().ToString();
        }

        private void SetLossCount()
        {
            LossCountLabel.Text = matchHistory.getNumberOfLosses().ToString();
        }

        private void SetRatioLabel()
        {           
            RatioLabel.Text = string.Format("{0:N2}%",matchHistory.getWinLossRatio());
        }

        //updates all labels and button text's *needs to be called every time a button that changes stats is called*
        private void updateAll()
        {
            SetWinCount();
            SetLossCount();
            SetRatioLabel();
            SetDifferenceLabel();
            //updateWinLossRatio();
            //updateDifference();
        }

        //event handlers
        private void WinButton_Click(object sender, EventArgs e)
        {
            matchHistory.incrementWinCount();
            updateAll();
        }

        private void LossButton_Click(object sender, EventArgs e)
        {
            matchHistory.incrementLossCount();
            updateAll();
        }

        //Reset button forgot to change the name
        private void ResetButton_Click(object sender, EventArgs e)
        {
            matchHistory.ResetAndUpdateStats();
            updateAll();
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
