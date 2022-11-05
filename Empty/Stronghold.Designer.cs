namespace Empty
{
    partial class Stronghold
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stronghold));
            this.Right = new System.Windows.Forms.Button();
            this.ShTextBox = new System.Windows.Forms.Label();
            this.ShWhiteBox = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Button();
            this.Cave = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.DeathMessage = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.LibraryTextBox = new System.Windows.Forms.Label();
            this.BookText1 = new System.Windows.Forms.Label();
            this.BookText2 = new System.Windows.Forms.Label();
            this.Storage = new System.Windows.Forms.Button();
            this.Strange = new System.Windows.Forms.Button();
            this.StorageText = new System.Windows.Forms.Label();
            this.PortalImg = new System.Windows.Forms.PictureBox();
            this.StorageImg = new System.Windows.Forms.PictureBox();
            this.PortalRoomArrow = new System.Windows.Forms.Button();
            this.LibraryImg = new System.Windows.Forms.PictureBox();
            this.DeathArrow = new System.Windows.Forms.Button();
            this.PortalText = new System.Windows.Forms.Label();
            this.PortalArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortalImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Black;
            this.Right.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.Color.SlateBlue;
            this.Right.Location = new System.Drawing.Point(639, 398);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(150, 47);
            this.Right.TabIndex = 45;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // ShTextBox
            // 
            this.ShTextBox.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShTextBox.ForeColor = System.Drawing.Color.White;
            this.ShTextBox.Location = new System.Drawing.Point(347, 156);
            this.ShTextBox.Name = "ShTextBox";
            this.ShTextBox.Size = new System.Drawing.Size(487, 204);
            this.ShTextBox.TabIndex = 46;
            this.ShTextBox.Text = "Stone. Stone bricks. Stonewalls.\r\nTwo paths. Left. Right.\r\nDoes the player take t" +
    "he right path or the left?\r\n";
            this.ShTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShWhiteBox
            // 
            this.ShWhiteBox.BackColor = System.Drawing.Color.White;
            this.ShWhiteBox.Location = new System.Drawing.Point(336, 145);
            this.ShWhiteBox.Name = "ShWhiteBox";
            this.ShWhiteBox.Size = new System.Drawing.Size(508, 227);
            this.ShWhiteBox.TabIndex = 47;
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Black;
            this.Left.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.Color.Teal;
            this.Left.Location = new System.Drawing.Point(391, 398);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(150, 47);
            this.Left.TabIndex = 48;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Cave
            // 
            this.Cave.BackColor = System.Drawing.Color.Black;
            this.Cave.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cave.ForeColor = System.Drawing.Color.Teal;
            this.Cave.Location = new System.Drawing.Point(391, 398);
            this.Cave.Name = "Cave";
            this.Cave.Size = new System.Drawing.Size(150, 47);
            this.Cave.TabIndex = 49;
            this.Cave.Text = "Cave";
            this.Cave.UseVisualStyleBackColor = false;
            this.Cave.Click += new System.EventHandler(this.Cave_Click);
            // 
            // Library
            // 
            this.Library.BackColor = System.Drawing.Color.Black;
            this.Library.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.ForeColor = System.Drawing.Color.SlateBlue;
            this.Library.Location = new System.Drawing.Point(639, 398);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(150, 47);
            this.Library.TabIndex = 50;
            this.Library.Text = "Library";
            this.Library.UseVisualStyleBackColor = false;
            this.Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // DeathMessage
            // 
            this.DeathMessage.Font = new System.Drawing.Font("Determination Mono Web", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathMessage.Location = new System.Drawing.Point(293, 90);
            this.DeathMessage.Name = "DeathMessage";
            this.DeathMessage.Size = new System.Drawing.Size(606, 399);
            this.DeathMessage.TabIndex = 68;
            this.DeathMessage.Text = resources.GetString("DeathMessage.Text");
            this.DeathMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Black;
            this.No.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.ForeColor = System.Drawing.Color.SlateBlue;
            this.No.Location = new System.Drawing.Point(947, 469);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(150, 47);
            this.No.TabIndex = 74;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Black;
            this.Yes.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.ForeColor = System.Drawing.Color.Teal;
            this.Yes.Location = new System.Drawing.Point(614, 469);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(150, 47);
            this.Yes.TabIndex = 73;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // LibraryTextBox
            // 
            this.LibraryTextBox.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryTextBox.ForeColor = System.Drawing.Color.White;
            this.LibraryTextBox.Location = new System.Drawing.Point(610, 98);
            this.LibraryTextBox.Name = "LibraryTextBox";
            this.LibraryTextBox.Size = new System.Drawing.Size(487, 347);
            this.LibraryTextBox.TabIndex = 71;
            this.LibraryTextBox.Text = "Books upon books.\r\nTaller than the player could reach. \r\nIn the middle of the roo" +
    "m there is a book.\r\nShining a red flame. \r\nThe player senses a feeling of famili" +
    "arity.\r\nDoes the player open the book?";
            this.LibraryTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookText1
            // 
            this.BookText1.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookText1.ForeColor = System.Drawing.Color.White;
            this.BookText1.Location = new System.Drawing.Point(31, 46);
            this.BookText1.Name = "BookText1";
            this.BookText1.Size = new System.Drawing.Size(408, 208);
            this.BookText1.TabIndex = 76;
            this.BookText1.Text = "It walks up to the book.\r\nTake a closer look.\r\n“Art of war” the book says. \r\nThe " +
    "player opens the book.\r\nSkips a few pages until it stops.\r\nThe player can’t cont" +
    "inue. \r\nWith golden letters it says:";
            this.BookText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookText2
            // 
            this.BookText2.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookText2.ForeColor = System.Drawing.Color.Gold;
            this.BookText2.Location = new System.Drawing.Point(31, 254);
            this.BookText2.Name = "BookText2";
            this.BookText2.Size = new System.Drawing.Size(521, 317);
            this.BookText2.TabIndex = 77;
            this.BookText2.Text = resources.GetString("BookText2.Text");
            this.BookText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Storage
            // 
            this.Storage.BackColor = System.Drawing.Color.Black;
            this.Storage.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Storage.ForeColor = System.Drawing.Color.SlateBlue;
            this.Storage.Location = new System.Drawing.Point(670, 389);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(150, 47);
            this.Storage.TabIndex = 81;
            this.Storage.Text = "Storage";
            this.Storage.UseVisualStyleBackColor = false;
            this.Storage.Click += new System.EventHandler(this.Storage_Click);
            // 
            // Strange
            // 
            this.Strange.BackColor = System.Drawing.Color.Black;
            this.Strange.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strange.ForeColor = System.Drawing.Color.Teal;
            this.Strange.Location = new System.Drawing.Point(337, 389);
            this.Strange.Name = "Strange";
            this.Strange.Size = new System.Drawing.Size(150, 47);
            this.Strange.TabIndex = 80;
            this.Strange.Text = "Strange";
            this.Strange.UseVisualStyleBackColor = false;
            this.Strange.Click += new System.EventHandler(this.Strange_Click);
            // 
            // StorageText
            // 
            this.StorageText.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageText.ForeColor = System.Drawing.Color.White;
            this.StorageText.Location = new System.Drawing.Point(634, 137);
            this.StorageText.Name = "StorageText";
            this.StorageText.Size = new System.Drawing.Size(487, 308);
            this.StorageText.TabIndex = 82;
            this.StorageText.Text = resources.GetString("StorageText.Text");
            this.StorageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortalImg
            // 
            this.PortalImg.Image = global::Empty.Properties.Resources.PortalRoom;
            this.PortalImg.Location = new System.Drawing.Point(59, 160);
            this.PortalImg.Name = "PortalImg";
            this.PortalImg.Size = new System.Drawing.Size(482, 266);
            this.PortalImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PortalImg.TabIndex = 84;
            this.PortalImg.TabStop = false;
            // 
            // StorageImg
            // 
            this.StorageImg.Image = global::Empty.Properties.Resources.Storage;
            this.StorageImg.Location = new System.Drawing.Point(59, 160);
            this.StorageImg.Name = "StorageImg";
            this.StorageImg.Size = new System.Drawing.Size(482, 266);
            this.StorageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StorageImg.TabIndex = 83;
            this.StorageImg.TabStop = false;
            // 
            // PortalRoomArrow
            // 
            this.PortalRoomArrow.BackColor = System.Drawing.Color.Black;
            this.PortalRoomArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.PortalRoomArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PortalRoomArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortalRoomArrow.ForeColor = System.Drawing.Color.Transparent;
            this.PortalRoomArrow.Location = new System.Drawing.Point(1004, 522);
            this.PortalRoomArrow.Name = "PortalRoomArrow";
            this.PortalRoomArrow.Size = new System.Drawing.Size(93, 24);
            this.PortalRoomArrow.TabIndex = 75;
            this.PortalRoomArrow.UseVisualStyleBackColor = false;
            this.PortalRoomArrow.Click += new System.EventHandler(this.PortalRoomArrow_Click);
            // 
            // LibraryImg
            // 
            this.LibraryImg.Image = global::Empty.Properties.Resources.Library;
            this.LibraryImg.Location = new System.Drawing.Point(36, 156);
            this.LibraryImg.Name = "LibraryImg";
            this.LibraryImg.Size = new System.Drawing.Size(482, 270);
            this.LibraryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LibraryImg.TabIndex = 70;
            this.LibraryImg.TabStop = false;
            // 
            // DeathArrow
            // 
            this.DeathArrow.BackColor = System.Drawing.Color.Black;
            this.DeathArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.DeathArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeathArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeathArrow.ForeColor = System.Drawing.Color.Transparent;
            this.DeathArrow.Location = new System.Drawing.Point(806, 492);
            this.DeathArrow.Name = "DeathArrow";
            this.DeathArrow.Size = new System.Drawing.Size(93, 24);
            this.DeathArrow.TabIndex = 69;
            this.DeathArrow.UseVisualStyleBackColor = false;
            this.DeathArrow.Click += new System.EventHandler(this.DeathArrow_Click);
            // 
            // PortalText
            // 
            this.PortalText.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortalText.ForeColor = System.Drawing.Color.White;
            this.PortalText.Location = new System.Drawing.Point(634, 110);
            this.PortalText.Name = "PortalText";
            this.PortalText.Size = new System.Drawing.Size(487, 379);
            this.PortalText.TabIndex = 85;
            this.PortalText.Text = resources.GetString("PortalText.Text");
            this.PortalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortalArrow
            // 
            this.PortalArrow.BackColor = System.Drawing.Color.Black;
            this.PortalArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.PortalArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PortalArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortalArrow.ForeColor = System.Drawing.Color.Transparent;
            this.PortalArrow.Location = new System.Drawing.Point(1004, 492);
            this.PortalArrow.Name = "PortalArrow";
            this.PortalArrow.Size = new System.Drawing.Size(93, 24);
            this.PortalArrow.TabIndex = 86;
            this.PortalArrow.UseVisualStyleBackColor = false;
            this.PortalArrow.Click += new System.EventHandler(this.PortalArrow_Click);
            // 
            // Stronghold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.PortalArrow);
            this.Controls.Add(this.PortalText);
            this.Controls.Add(this.PortalImg);
            this.Controls.Add(this.StorageImg);
            this.Controls.Add(this.StorageText);
            this.Controls.Add(this.ShTextBox);
            this.Controls.Add(this.ShWhiteBox);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Strange);
            this.Controls.Add(this.BookText2);
            this.Controls.Add(this.BookText1);
            this.Controls.Add(this.PortalRoomArrow);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.LibraryTextBox);
            this.Controls.Add(this.LibraryImg);
            this.Controls.Add(this.DeathArrow);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.Cave);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.DeathMessage);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Stronghold";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.PortalImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Label ShTextBox;
        private System.Windows.Forms.Label ShWhiteBox;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Cave;
        private System.Windows.Forms.Button Library;
        private System.Windows.Forms.Button DeathArrow;
        private System.Windows.Forms.Label DeathMessage;
        private System.Windows.Forms.PictureBox LibraryImg;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Label LibraryTextBox;
        private System.Windows.Forms.Button PortalRoomArrow;
        private System.Windows.Forms.Label BookText1;
        private System.Windows.Forms.Label BookText2;
        private System.Windows.Forms.Button Storage;
        private System.Windows.Forms.Button Strange;
        private System.Windows.Forms.Label StorageText;
        private System.Windows.Forms.PictureBox StorageImg;
        private System.Windows.Forms.PictureBox PortalImg;
        private System.Windows.Forms.Label PortalText;
        private System.Windows.Forms.Button PortalArrow;
    }
}