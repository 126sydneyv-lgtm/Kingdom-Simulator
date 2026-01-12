using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kingdom_Simulator
{
    public partial class Form1 : Form
    {
        //global variables
        string kingdomName;

        int year;
        int resources;
        int riches;
        int population;
        int happiness;

        List<string> decisionHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        //sets up game at the start of the game
        private void InitializeGame()
        {

            year = 0;
            resources = 100;
            riches = 100;
            population = 50;
            happiness = 50;

            outputLabel.Text = "Enter your kingdom name and press Start,";
            UpdateStatus();
            EnableDecisionButtons(false);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            kingdomName = kingdomTextBox.Text;

            if (kingdomName == "")
            {
                MessageBox.Show("Please enter a kingdom name.");
                return;
            }

            year = 1;
            outputLabel.Text = $"Welcome, ruler of {kingdomName}!";
            EnableDecisionButtons(true);
            UpdateStatus();
        }

        //decision buttons
        private void decision1Button_Click(object sender, EventArgs e)
        {
            //collect taxes
            riches += 20;
            happiness -= 10;

            decisionHistory.Add("Collected Taxes");
            outputLabel.Text = "You collected taxes. Riches increased, happiness decreased";

            EndOfAction();
        }

        private void decision2Button_Click(object sender, EventArgs e)
        {
            //build housing
            resources -= 20;
            population += 10;
            happiness += 5;

            decisionHistory.Add("Built Housing");
            outputLabel.Text = "New homes were built. Population increased";

            EndOfAction();
        }
        private void decision3Button_Click(object sender, EventArgs e)
        {
            //host festival
            riches -= 15;
            happiness += 15;

            decisionHistory.Add("Hosted Festival");
            outputLabel.Text = "A festival was held. People are happier.";

            EndOfAction();
        }

        //end turn
        private void endTurnButton_Click(object sender, EventArgs e)
        {

        }

        //methods

        private void UpdateStatus()
        {
        statusLabel.Text = $"Year: {year}\n" + $"Resources: {resources}\n" + $"Riches: {riches }\n" + $"Population: {population}\n" + $"Happiness: {happiness}\n";

        }
    private void EnableDecisionButtons(bool enable)
        {
            decision1Button.Enabled = enable;
            decision2Button.Enabled = enable;
            decision3Button.Enabled = enable;
            endTurnButton.Enabled = enable;

        }

        private void EndOfAction()
        {
            UpdateStatus();
            CheckGameOver();

        }

        private void CheckGameOver()
        {

        }
    }

    


   
}
