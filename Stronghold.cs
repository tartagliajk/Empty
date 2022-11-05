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
    public partial class Stronghold : Form
    {
        public Stronghold()
        {
            InitializeComponent();

            Cave.Visible = false;
            Library.Visible = false;
            
            DeathArrow.Visible = false;
            DeathMessage.Visible = false;

            LibraryImg.Visible = false;
            LibraryTextBox.Visible = false;
            Yes.Visible = false;
            No.Visible = false;
            PortalRoomArrow.Visible = false;
            BookText1.Visible = false;
            BookText2.Visible = false;

            Strange.Visible = false;
            Storage.Visible = false;

            StorageImg.Visible = false;
            StorageText.Visible = false;

            PortalText.Visible = false;
            PortalImg.Visible = false;
            PortalArrow.Visible = false;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            Left.Visible = false;
            Right.Visible = false;

            Cave.Visible = true;
            Library.Visible = true;

            ShTextBox.Text = ("At the end of the path there are two ways." +
                "\nThe left one leads to a cave and the other to a library.");
        }
        
        private void Cave_Click(object sender, EventArgs e)
        {
            Cave.Visible = false;
            Library.Visible = false;
            ShTextBox.Visible = false;
            ShWhiteBox.Visible = false;

            DeathMessage.Visible = true;
            DeathArrow.Visible = true;
        }
        private void DeathArrow_Click(object sender, EventArgs e)
        {
            GameOver gameOver = new GameOver();

            gameOver.Show();

            this.Hide();
        }
        private void Library_Click(object sender, EventArgs e)
        {
            Cave.Visible = false;
            Library.Visible = false;
            ShTextBox.Visible = false;
            ShWhiteBox.Visible = false;

            LibraryImg.Visible = true;
            LibraryTextBox.Visible = true;
            Yes.Visible = true;
            No.Visible = true;
        }
        
        private void Yes_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;
            LibraryImg.Visible = false;

            BookText1.Visible = true;
            BookText2.Visible = true;
            PortalRoomArrow.Visible = true;

            LibraryTextBox.Text = ("The player takes off the crown once again." +
                "\nIt looks inside the crown where the text once was." +
                "\nThe golden text starts to change form and now the player can read it." +
                "\n“Emperor T.”\nA tear drops as the player puts the crown back on its head.");
        }

        private void No_Click(object sender, EventArgs e)
        {
            Yes.Visible = false;
            No.Visible = false;

            PortalRoomArrow.Visible = true;

            LibraryTextBox.Text = ("Maybe it's best to let it be.");
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Left.Visible = false;
            Right.Visible = false;

            Strange.Visible = true;
            Storage.Visible = true;

            ShTextBox.Text = ("At the end of the path there are two ways." +
                "\nThe left one leads to a strange room and the other to a storage room." +
                "\nDoes the player go to the strange room or the storage?");
        }

        private void Strange_Click(object sender, EventArgs e)
        {
            Strange.Visible = false;
            Storage.Visible = false;
            ShTextBox.Visible = false;
            ShWhiteBox.Visible = false;

            PortalArrow.Visible = true;
            PortalImg.Visible = true;
            PortalText.Visible = true;
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            Strange.Visible = false;
            Storage.Visible = false;
            ShTextBox.Visible = false;
            ShWhiteBox.Visible = false;

            StorageImg.Visible = true;
            StorageText.Visible = true;
            PortalRoomArrow.Visible = true;
        }

        private void PortalRoomArrow_Click(object sender, EventArgs e)
        {
            BookText1.Visible = false;
            BookText2.Visible = false;
            PortalRoomArrow.Visible = false;
            LibraryTextBox.Visible = false;
            LibraryImg.Visible = false;
            StorageImg.Visible = false;
            StorageText.Visible = false;

            PortalArrow.Visible = true;
            PortalImg.Visible = true;
            PortalText.Visible = true;
        }

        private void PortalArrow_Click(object sender, EventArgs e)
        {
            End end = new End();

            end.Show();

            this.Hide();
        }
    }
}
