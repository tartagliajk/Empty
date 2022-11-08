using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empty
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();

            EndArrow2.Visible = false;
            Near.Visible = false;
            Far.Visible = false;

            DeathArrow.Visible = false;
            DeathMessage.Visible = false;

            FarText.Visible = false;
            FarArrow.Visible = false;

            Return.Visible = false;
            Exit.Visible = false;
            FarArrow2.Visible = false;
        }

        private void EndArrow_Click(object sender, EventArgs e)
        {
            EndArrow.Visible = false;

            EndArrow2.Visible = true;

            EndText.Text = ("The player decides to build a bridge towards the island." +
                "\nOne block. Two blocks. Three blocks." +
                "\n“Weird material” it murmurs to itself." +
                "\nAs the player looks up, it’s greeted with 10 obsidian towers with a floating crystal on the top." +
                "\nA dragon is flying in the sky." +
                "\n“It’s probably the ruler in this dimension” the player thought.");
        }

        private void EndArrow2_Click(object sender, EventArgs e)
        {
            EndArrow2.Visible = false;

            Near.Visible = true;
            Far.Visible = true;

            //ranged weapons
            if (Globals.Weapon == 1 || Globals.Weapon == 2)
            {
                EndText.Text = ("The player decides to shoot at the crystals which resulted in them exploding." +
                    "\nOne after one they explode." +
                    "\nUntil there is only one left." +
                    "\nBoom." +
                    "\nDoes the player stand far away from the crystal or near it?");
            }

            if(Globals.Weapon == 3 || Globals.Weapon == 4)
            {
                EndText.Text = ("With the only option building up to destroy the crystals." +
                    "\nAs the player builds up the more the ground gets dimmed." +
                    "\nLast block" +
                    "\nDoes the player stand far away from the crystal or near it?");
            }
        }

        private void Far_Click(object sender, EventArgs e)
        {
            EndImg.Visible = false;
            Near.Visible = false;
            Far.Visible = false;
            EndText.Visible = false;
            EndWhiteBox.Visible = false;
            
            FarText.Visible = true;
            FarArrow.Visible = true;
        }
        
        private void FarArrow_Click(object sender, EventArgs e)
        {
            FarArrow.Visible = false;

            FarArrow2.Visible = true;

            FarText.ForeColor = Color.Teal;

            FarText.Text = ("You are the player, reading words…" +
                "\nSometimes it believed it was in a universe that was made of energy " +
                "that was made of offs and ons; zeros and ones; lines of code." +
                "\nSometimes it believed it was playing a game." +
                "\nSometimes it believed it was reading words on a screen." +
                "\nShush... Sometimes the player read lines of code on a screen." +
                "\nDecoded them into words; decoded words into meaning; decoded meaning " +
                "into feelings, emotions, theories, ideas, and the player started to " +
                "breathe faster and deeper and realised it was alive, it was alive, " +
                "those thousand deaths had not been real, the player was alive." +
                "\nYou. You. You are alive." +
                "\nYou are the player." +
                "\nWake up.");
        }
        private void FarArrow2_Click(object sender, EventArgs e)
        {
            FarText.Visible = false;
            FarArrow2.Visible = false;

            Return.Visible = true;
            Exit.Visible = true;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();

            startMenu.Show();

            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Near_Click(object sender, EventArgs e)
        {
            EndImg.Visible = false;
            Near.Visible = false;
            Far.Visible = false;
            EndText.Visible = false;
            EndWhiteBox.Visible = false;

            DeathMessage.Visible = true;
            DeathArrow.Visible = true;
        }

        private void DeathArrow_Click(object sender, EventArgs e)
        {
            GameOver gameOver = new GameOver();

            gameOver.Show();

            this.Hide();
        }
    }
}
