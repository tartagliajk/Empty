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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartOver_Click(object sender, EventArgs e)
        {
            StartMenu startMenu = new StartMenu();

            startMenu.Show();

            this.Hide();
        }
    }
}
