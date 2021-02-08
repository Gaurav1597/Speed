using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
    public partial class Form1 : Form
    {
        readonly Dog[] Dogs = new Dog[4];

        readonly Bettor[] Bettors = new Bettor[3];

        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Dog.StartingPosition1 = Dog1.Right - Racetrack.Left;
            Dog.RacetrackLength1 = Racetrack.Size.Width - 70; //connect the length of race - upto ending line

            Dogs[0] = new Dog() {DogPictureBox  = Dog1 };
            Dogs[1] = new Dog() { DogPictureBox = Dog2 };
            Dogs[2] = new Dog() { DogPictureBox = Dog3 };
            Dogs[3] = new Dog() { DogPictureBox = Dog4 };

            Bettors[0] = PlayerFactory.GetBettor("Amrit", MaximumBet, AviBet); //obtaing  amrit object from factory class
            Bettors[1] = PlayerFactory.GetBettor("Anmol", MaximumBet, AnmolBet); //obtaing anmol object from factory class
            Bettors[2] = PlayerFactory.GetBettor("Vicky", MaximumBet, VickyBet); //obtaing vicky object from factory class

            //Debug.WriteLine(Bettors[0].Title);

            foreach (Bettor bettor in Bettors)
            {
                bettor.UpdateLabels();
            }
        }

        private void AmritButton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[0].money);
        }

        private void Antton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[1].money);
        }

        private void VickyButton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[2].money);
        }

        private void SetMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Bettor and updating labels respectively
        private void Bets_Click(object sender, EventArgs e)
        {
            
            int BettorNum = 0;

            if (AviButton.Checked)
            {
                BettorNum = 0;
            }
            if (AnmolButton.Checked)
            {
                BettorNum = 1;
            }
            if (VickyButton.Checked)
            {
                BettorNum = 2;
            }

            Bettors[BettorNum].PlaceBet((int)BettingAmount.Value, (int)DogNumber.Value);
            Bettors[BettorNum].UpdateLabels();
        }

        private void Race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDog;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Dogs.Length; i++)
                {
                    if (Dog.Run(Dogs[i]))
                    {
                        winningDog = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a defeater -  # Dog #" + winningDog);
                        foreach (Bettor bettor in Bettors)
                        {
                            if (bettor.gamble != null)
                            {
                                bettor.Collect(winningDog); //give double sum to all who have achieve or conclued betted sum
                                bettor.gamble = null;
                                bettor.UpdateLabels();
                            }
                        }
                        foreach (Dog Dog in Dogs)
                        {
                            Dog.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (Bettors[0].busted && Bettors[1].busted && Bettors[2].busted)
            {  //stop bettors from betting if they run out of cash
                string message = "Do you want to play this game once more time?";
                string title = "Game Finished!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void Racetrack_Click(object sender, EventArgs e)
        {

        }

        private void Dog4_Click(object sender, EventArgs e)
        {

        }

        private void AnmolBet_Click(object sender, EventArgs e)
        {

        }

        private void VickyBet_Click(object sender, EventArgs e)
        {

        }

        private void BettingAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dog3_Click(object sender, EventArgs e)
        {

        }

        private void Dog1_Click(object sender, EventArgs e)
        {

        }

        private void Dog2_Click(object sender, EventArgs e)
        {

        }

        private void DogNumber_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}