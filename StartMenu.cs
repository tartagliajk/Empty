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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            DuckPicture.Visible = false;
            CreditPictureText.Visible = false;
            CreditText.Visible = false;
            ReturnButton.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            IntroScreen introScreen = new IntroScreen();

            introScreen.Show();

            this.Hide();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            Empty.Visible = false;
            StartButton.Visible = false;
            CreditsButton.Visible = false;

            DuckPicture.Visible = true;
            CreditPictureText.Visible = true;
            CreditText.Visible = true;
            ReturnButton.Visible = true;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            DuckPicture.Visible = false;
            CreditPictureText.Visible = false;
            CreditText.Visible = false;
            ReturnButton.Visible = false;

            Empty.Visible = true;
            StartButton.Visible = true;
            CreditsButton.Visible = true;
        }
    }
}

public static class Globals
{
    public static int Weapon;

    /*
    1 - Bow
    2 - CrossBow
    3 - sword
    4 - axe
    */
}
