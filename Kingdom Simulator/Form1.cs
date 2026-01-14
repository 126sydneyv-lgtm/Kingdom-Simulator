using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Kingdom_Simulator
{
    public partial class Form1 : Form
    {
        //global variables
        string kingdomName;

        int resources;
        int riches;
        int population;
        int happiness;

        List<string> requestDescriptions = new List<string>();
        int currentRequest;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        //sets up game at the start of the game
        private void InitializeGame()
        {

            resources = 100;
            riches = 100;
            population = 50;
            happiness = 50;

            requestDescriptions.Add("Farmers ask to clear land for more crops.");
            requestDescriptions.Add("Merchants want lower taxes.");
            requestDescriptions.Add("Villagers request a festival.");
            requestDescriptions.Add("Builders ask for resources to repair the city walls.");
            requestDescriptions.Add("Builders want to construct new homes for incoming citizens");
            requestDescriptions.Add("Refugees from a nearby land ask to settle in your kingdom");
            requestDescriptions.Add("A drought threatens crops. Farmers ask for emergency aid");

            endScreenPanel.Visible = false;
            startScreenPanel.Visible = true;
            namePromptLabel.Text = "Enter your kingdom name and press Start.";
            UpdateStatus();
            EnableRequestButtons(false);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            kingdomName = kingdomTextBox.Text;

            if (kingdomName == "")
            {
                MessageBox.Show("Please enter a kingdom name.");
                return;
            }

            namePromptLabel.Text = $"Welcome, ruler of {kingdomName}!";
            Refresh();
            Thread.Sleep(1500);
            startScreenPanel.Visible = false;
            EnableRequestButtons(true);
            ShowNewRequest();
            UpdateStatus();
        }

        //show random request
        private void ShowNewRequest()
        {
            currentRequest = rand.Next(requestDescriptions.Count);
            outputLabel.Text = requestDescriptions[currentRequest];
        }
        //approve request
        private void approveButton_Click(object sender, EventArgs e)
        {
            switch (currentRequest)
            {
                case 0:
                    resources += 20;
                    population -= 10;
                    break;
                case 1:
                    riches -= 10;
                    happiness += 15;
                    break;
                case 2:
                    resources -= 15;
                    happiness += 10;
                    break;
                case 3:
                    resources -= 25;
                    population += 5;
                    happiness += 5;
                    break;
                case 4:
                    resources -= 25;
                    population -= 10;
                    break;
                case 5:
                    resources -= 10;
                    population += 15;
                    break;
                case 6:
                    riches -= 15;
                    happiness += 5;
                    resources += 15;
                    break;
            }
            outputLabel.Text = "You approved the request";
            EndOfAction();
            ShowNewRequest();
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            switch (currentRequest)
            {
                case 0:
                    resources += 20;
                    happiness -= 10;
                    break;
                case 1:
                    riches += 15;
                    happiness -= 10;
                    break;
                case 2:
                    happiness -= 10;
                    break;
                case 3:
                    population -= 5;
                    happiness -= 5;
                    resources += 5;
                    break;
                case 4:
                    population -= 5;
                    break;
                case 5:
                    happiness -= 10;
                    break;
                case 6:
                    resources -= 25;
                    happiness -= 15;
                    population -= 5;
                    break;
            }
            outputLabel.Text = "You denied the request";
            EndOfAction();
            ShowNewRequest();
        }

        //methods

        private void UpdateStatus()
        {
            statusLabel.Text = $"Resources: {resources}\n" + $"Riches: {riches}\n" + $"Population: {population}\n" + $"Happiness: {happiness}\n";

        }
        private void EnableRequestButtons(bool enable)
        {
            approveButton.Enabled = enable;
            denyButton.Enabled = enable;
        }

        private void EndOfAction()
        {
            UpdateStatus();
            CheckGameOver();

        }

        private void CheckGameOver()
        {
            if (population <= 0)
            {
                EndGame("Everyone fled because of your poor ruling :(");
            }
            else if (happiness <= 0)
            {
                EndGame("The people revolted against you");
            }
            else if (resources <= 0 || riches <= 0)
            {
                EndGame("Your kingdom went bankrupt");
            }
        }

        private void EndGame(string endingMessage)
        {
            endLabel.Text = "Your Reign Has Ended";
            summaryLabel.Text = endingMessage + $"\n\nFinal Stats:\n" + $"Population: {population}\n" + $"Happiness: {happiness}\n" + $"Riches: {riches}\n" + $"Resources: {resources}\n";

            endScreenPanel.Visible = true;
        }
    }





}
