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
    public partial class Village : Form
    {
        public Village()
        {
            InitializeComponent();

            DecisionText.Visible = false;
            DecisionWhiteBox.Visible = false;
            Smith.Visible = false;
            Range.Visible = false;
            
            SmithImg.Visible = false;
            Axe.Visible = false;
            Sword.Visible = false;
            SmithText.Visible = false;
            SmithWhiteBox.Visible = false;

            RangeImg.Visible = false;
            RangeText.Visible = false;
            RangeWhiteBox.Visible = false;
            Bow.Visible = false;
            Crossbow.Visible = false;

            NetherArrow.Visible = false;
            PortalArrow.Visible = false;
            PortalTextArrow.Visible = false;
            PortalImg.Visible = false;
            PortalText.Visible = false;
            PortalWhiteBox.Visible = false;
        }

        private void SunriseArrow_Click(object sender, EventArgs e)
        {
            Sunrise.Visible = false;
            SunriseText.Visible = false;
            SunriseText2.Visible = false;
            SunRiseWhiteBox.Visible = false;
            SunriseWhiteBox2.Visible = false;
            SunriseArrow.Visible = false;

            DecisionText.Visible = true;
            DecisionWhiteBox.Visible = true;
            Smith.Visible = true;
            Range.Visible = true;
        }

        private void Smith_Click(object sender, EventArgs e)
        {
            DecisionText.Visible = false;
            DecisionWhiteBox.Visible = false;
            Smith.Visible = false;
            Range.Visible = false;

            SmithImg.Visible = true;
            Axe.Visible = true;
            Sword.Visible = true;
            SmithText.Visible = true;
            SmithWhiteBox.Visible = true;
        }

        private void Sword_Click(object sender, EventArgs e)
        {
            Sword.Visible = false;
            Axe.Visible = false;

            PortalArrow.Visible = true;

            SmithText.Text = ("Sharp.\nHandle.\nEasy to cut.\nBut yet so weak.");

            Globals.Weapon = 3;
        }

        private void Axe_Click(object sender, EventArgs e)
        {
            Sword.Visible = false;
            Axe.Visible = false;

            PortalArrow.Visible = true;

            SmithText.Text = ("Heavy.\nSlow.\nGreat damage.");
            
            Globals.Weapon = 4;
        }

        private void Range_Click(object sender, EventArgs e)
        {
            DecisionText.Visible = false;
            DecisionWhiteBox.Visible = false;
            Smith.Visible = false;
            Range.Visible = false;

            RangeImg.Visible = true;
            RangeText.Visible = true;
            RangeWhiteBox.Visible = true;
            Bow.Visible = true;
            Crossbow.Visible = true;
        }

        private void Bow_Click(object sender, EventArgs e)
        {
            Bow.Visible = false;
            Crossbow.Visible = false;

            PortalArrow.Visible = true;

            RangeText.Text = ("Quick.\nEasy to use.\nPrecise.");

            Globals.Weapon = 1;

        }

        private void Crossbow_Click(object sender, EventArgs e)
        {
            Bow.Visible = false;
            Crossbow.Visible = false;

            PortalArrow.Visible = true;

            RangeText.Text = ("Slow.\nUntrustworthy.");

            Globals.Weapon = 2;
        }

        private void PortalArrow_Click(object sender, EventArgs e)
        {
            RangeImg.Visible = false;
            RangeText.Visible = false;
            RangeWhiteBox.Visible = false;
            SmithImg.Visible = false;
            SmithText.Visible = false;
            SmithWhiteBox.Visible = false;
            PortalArrow.Visible = false;

            PortalImg.Visible = true;
            PortalText.Visible = true;
            PortalWhiteBox.Visible = true;
            PortalTextArrow.Visible = true;

        }

        private void PortalTextArrow_Click(object sender, EventArgs e)
        {
            PortalTextArrow.Visible = false;

            NetherArrow.Visible = true;

            PortalText.Text = ("'Risk? Yes.'\nThe player runs towards the portal." +
                "\nOver the guards it goes.\nInto the portal it goes.");
        }
        
        private void NetherArrow_Click(object sender, EventArgs e)
        {
            Nether nether = new Nether();

            nether.Show();

            this.Hide();
        }
    }
}
