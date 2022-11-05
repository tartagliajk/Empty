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
    public partial class Nether : Form
    {
        static string wepaonChoice;

        public Nether()
        {
            InitializeComponent();

            ChestImg.Visible = false;
            Arrow.Visible = false;
            SpawnerImg.Visible = false;

            DeathMessage.Visible = false;
            DeathArrow.Visible = false;

            DecisionTextBox.Visible = false;
            DecisionWhiteBox.Visible = false;
            Build.Visible = false;
            Dig.Visible = false;

            Tunnel.Visible = false;
            PigmenText.Visible = false;
            PigmenArrow.Visible = false;
            StrongholdArrow.Visible = false;
        }

        private void Spawner_Click(object sender, EventArgs e)
        {
            NetherImg.Visible = false;
            NetherDecision.Visible = false;
            NetherWhiteBox.Visible = false;
            Spawner.Visible = false;
            Chests.Visible = false;

            SpawnerImg.Visible = true;
            Arrow.Visible = true;

            if (Globals.Weapon == 1)
            {
                wepaonChoice = "Arrow in íts hand." +
                    "\nPutting it next to the bow string." +
                    "\nA sound of arrow swoshing past and into the opponents soul.";
            }
            if (Globals.Weapon == 2)
            {
                wepaonChoice = "The arrow has been loaded." +
                    "\nThe player charge press the fire button.";
            }
            if (Globals.Weapon == 3)
            {
                wepaonChoice = "The player rise its sword and swing it at the enemies.";
            }
            if (Globals.Weapon == 4)
            {
                wepaonChoice = "With a hasty motion the player raises its axe and chops the opponents.";
            }

            NetherTextBox.Text = ("Burning beings." +
                "\nWho gave powders." +
                "\nThe player walks with definite steps." +
                wepaonChoice + "\nLifeless powder on the ground." +
                "\nThe player picks some of it up.");
        }

        private void Chests_Click(object sender, EventArgs e)
        {
            NetherImg.Visible = false;
            NetherDecision.Visible = false;
            NetherWhiteBox.Visible = false;
            Spawner.Visible = false;
            Chests.Visible = false;

            ChestImg.Visible = true;
            Arrow.Visible = true;

            NetherTextBox.Text = ("Chestroom.\nThe player finds gold, diamonds, rubies, emeralds etc." +
                "\nBut nothing useful.\nSo it puts everything back." +
                "\nStill in need of the powder, the player walks towards the spawner." +
                "\n\nThe player has everything in its possession.\nNo more extra time shall be spent in vain." +
                "\nIt decides to go back to the overworld.");
        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            NetherTextBox.Visible = false;
            Arrow.Visible = false;
            ChestImg.Visible = false;
            SpawnerImg.Visible = false;

            DecisionTextBox.Visible = true;
            DecisionWhiteBox.Visible = true;
            Build.Visible = true;
            Dig.Visible = true;
        }

        private void Dig_Click(object sender, EventArgs e)
        {
            DecisionTextBox.Visible = false;
            DecisionWhiteBox.Visible = false;
            Build.Visible = false;
            Dig.Visible = false;

            Tunnel.Visible = true;
            PigmenText.Visible = true;
            PigmenArrow.Visible = true;
        }
        
        private void PigmenArrow_Click(object sender, EventArgs e)
        {
            PigmenArrow.Visible = false;
            StrongholdArrow.Visible = true;

            PigmenText.Text = ("The player walked towards it." +
                "\nIt looked at the player with a smile and it took off its crown." +
                "\nIt held it towards the player.\nThe player bowed and the pigman put the crown on the player's head." +
                "\nIt waved a hand towards the tunnel.\n“Don’t look back,” it said." +
                "\nThe player walked through the tunnel not daring to look back." +
                "\nPurple blue light shines through the tunnel." +
                "\nThe player walks through the portal, it wanted to look back but didn’t have the courage to do it." +
                "\nInstead it took off the brown and held it closer so it could get a better view." +
                "\nOn the band inside the crown there was text.\nIt could not read it." +
                "\nIt put the crown back on its head and looked at the surroundings.");
        }
        
        private void StrongholdArrow_Click(object sender, EventArgs e)
        {
            Stronghold stronghold = new Stronghold();

            stronghold.Show();

            this.Hide();
        }

        private void Build_Click(object sender, EventArgs e)
        {
            DecisionTextBox.Visible = false;
            DecisionWhiteBox.Visible = false;
            Build.Visible = false;
            Dig.Visible = false;

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
