using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Empty
{
    public partial class IntroScreen : Form
    {
        public IntroScreen()
        {
            InitializeComponent();
            ArrowNext.Visible = false;
            SpawnArrow1.Visible = false;
            SpawnArrow2.Visible = false;
            SpawnTextBox.Visible = false;
            SpawnWhiteBox.Visible = false;
            SunRise.Visible = false;

            Forest.Visible = false;
            ForestTextBox.Visible = false;
            ForestWhiteBox.Visible = false;
            Village.Visible = false;
            Trees.Visible = false;

            BirchTextBox.Visible = false;
            BirchTrees.Visible = false;
            BirchTreesText.Visible = false;
            BirchWhiteBox.Visible = false;
            Tools.Visible = false;
            VillageButton.Visible = false;
        }

        private void ArrowText_Click(object sender, EventArgs e)
        {
            IntroTextBox.Text = "Everything is simply being built up." +
                "Now it's the player's time to either set the player's footprint or to be forgotten.";
            
            ArrowText.Visible = false;
            ArrowNext.Visible = true;
        }

        private void ArrowNext_Click(object sender, EventArgs e)
        {
            IntroTextBox.Visible = false;
            ArrowNext.Visible = false;
            Intro.Visible = false;
            IntroWhiteBox.Visible = false;

            SpawnArrow1.Visible = true;
            SpawnTextBox.Visible = true;
            SpawnWhiteBox.Visible = true;
            SunRise.Visible = true;
        }

        private void SpawnArrow_Click(object sender, EventArgs e)
        {
            SpawnTextBox.Text = "The player looks around.\nThe player spots a village from a distance.";
            SpawnArrow1.Visible = false;

            SpawnArrow2.Visible = true;
        }

        private void SpawnArrow2_Click(object sender, EventArgs e)
        {
            SpawnArrow2.Visible = false;
            SpawnTextBox.Visible = false;
            SpawnWhiteBox.Visible = false;
            SunRise.Visible = false;

            Forest.Visible = true;
            ForestTextBox.Visible = true;
            ForestWhiteBox.Visible = true;
            Village.Visible = true;
            Trees.Visible = true;
        }

        private void Forest_Click(object sender, EventArgs e)
        {
            Forest.Visible = false;
            ForestTextBox.Visible = false;
            ForestWhiteBox.Visible = false;
            Village.Visible = false;
            Trees.Visible = false;

            BirchTextBox.Visible = true;
            BirchTrees.Visible = true;
            BirchTreesText.Visible = true;
            BirchWhiteBox.Visible = true;
            Tools.Visible = true;
            VillageButton.Visible = true;
        }

        private void Village_Click(object sender, EventArgs e)
        {
            Village village = new Village();

            village.Show();

            this.Hide();
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            Tools.Visible = false;

            BirchTreesText.Text = "Picaxe? Shovel? Hoe?" +
                "\nSomehow the player still remembers how to create them.\nThe player looks at the creation…" +
                "\nTurns it…\nThe player decides to explore a bit but it doesn't find anything useful." +
                "\nIt looks up to the sky.\nIt’s getting late.\nHeads towards the village.";

        }

        private void VillageButton_Click(object sender, EventArgs e)
        {
            Village village = new Village();

            village.Show();

            this.Hide();
        }
    }
}
