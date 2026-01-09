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
        //kingdom stats
        int resources = 100;
        int riches = 100;
        int population = 100;
        int happiness = 100;

        //game control
        int currentYear = 1;
        int maxYears = 10;
        bool gameOver = false;

        //lists

        public Form1()
        {
            InitializeComponent();
        }

       void Main(string[] args)
        {
           

            DisplayTitleScreen();
            InitializeKingdom();

            //main game loop
            while (!gameOver && currentYear <= maxYears)
            {

            }
        }
        //methods

        //displays "title screen" of the program.
        void DisplayTitleScreen()
        {
            label1.Text = "KINGDOM SIMULATOR";
            
        }

        //sets up kingdom at the start of the game
        void InitializeKingdom()
        {
           
            label1.Text = "Enter the name of your kingdom: ";
            string kingdomName = Convert.ToString(textBox1.Text);

            label1.Text = "\n" + "Welcome, ruler of " + kingdomName + "!";
            label1.Text = "Your reign begins now...";
        }
    }
}
