namespace Empty
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            this.EndText = new System.Windows.Forms.Label();
            this.EndWhiteBox = new System.Windows.Forms.Label();
            this.EndImg = new System.Windows.Forms.PictureBox();
            this.EndArrow = new System.Windows.Forms.Button();
            this.EndArrow2 = new System.Windows.Forms.Button();
            this.Far = new System.Windows.Forms.Button();
            this.Near = new System.Windows.Forms.Button();
            this.DeathMessage = new System.Windows.Forms.Label();
            this.DeathArrow = new System.Windows.Forms.Button();
            this.FarText = new System.Windows.Forms.Label();
            this.FarArrow = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.FarArrow2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EndImg)).BeginInit();
            this.SuspendLayout();
            // 
            // EndText
            // 
            this.EndText.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndText.Location = new System.Drawing.Point(604, 245);
            this.EndText.Name = "EndText";
            this.EndText.Size = new System.Drawing.Size(514, 281);
            this.EndText.TabIndex = 0;
            this.EndText.Text = resources.GetString("EndText.Text");
            this.EndText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndWhiteBox
            // 
            this.EndWhiteBox.BackColor = System.Drawing.Color.White;
            this.EndWhiteBox.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndWhiteBox.Location = new System.Drawing.Point(587, 228);
            this.EndWhiteBox.Name = "EndWhiteBox";
            this.EndWhiteBox.Size = new System.Drawing.Size(546, 314);
            this.EndWhiteBox.TabIndex = 1;
            // 
            // EndImg
            // 
            this.EndImg.Image = global::Empty.Properties.Resources.End;
            this.EndImg.Location = new System.Drawing.Point(35, 76);
            this.EndImg.Name = "EndImg";
            this.EndImg.Size = new System.Drawing.Size(535, 262);
            this.EndImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndImg.TabIndex = 88;
            this.EndImg.TabStop = false;
            // 
            // EndArrow
            // 
            this.EndArrow.BackColor = System.Drawing.Color.Black;
            this.EndArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.EndArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndArrow.ForeColor = System.Drawing.Color.Transparent;
            this.EndArrow.Location = new System.Drawing.Point(1040, 545);
            this.EndArrow.Name = "EndArrow";
            this.EndArrow.Size = new System.Drawing.Size(93, 30);
            this.EndArrow.TabIndex = 87;
            this.EndArrow.UseVisualStyleBackColor = false;
            this.EndArrow.Click += new System.EventHandler(this.EndArrow_Click);
            // 
            // EndArrow2
            // 
            this.EndArrow2.BackColor = System.Drawing.Color.Black;
            this.EndArrow2.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.EndArrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndArrow2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndArrow2.ForeColor = System.Drawing.Color.Transparent;
            this.EndArrow2.Location = new System.Drawing.Point(1040, 545);
            this.EndArrow2.Name = "EndArrow2";
            this.EndArrow2.Size = new System.Drawing.Size(93, 30);
            this.EndArrow2.TabIndex = 89;
            this.EndArrow2.UseVisualStyleBackColor = false;
            this.EndArrow2.Click += new System.EventHandler(this.EndArrow2_Click);
            // 
            // Far
            // 
            this.Far.BackColor = System.Drawing.Color.Black;
            this.Far.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Far.ForeColor = System.Drawing.Color.SlateBlue;
            this.Far.Location = new System.Drawing.Point(391, 399);
            this.Far.Name = "Far";
            this.Far.Size = new System.Drawing.Size(150, 47);
            this.Far.TabIndex = 91;
            this.Far.Text = "Far";
            this.Far.UseVisualStyleBackColor = false;
            this.Far.Click += new System.EventHandler(this.Far_Click);
            // 
            // Near
            // 
            this.Near.BackColor = System.Drawing.Color.Black;
            this.Near.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Near.ForeColor = System.Drawing.Color.Teal;
            this.Near.Location = new System.Drawing.Point(52, 399);
            this.Near.Name = "Near";
            this.Near.Size = new System.Drawing.Size(150, 47);
            this.Near.TabIndex = 90;
            this.Near.Text = "Near";
            this.Near.UseVisualStyleBackColor = false;
            this.Near.Click += new System.EventHandler(this.Near_Click);
            // 
            // DeathMessage
            // 
            this.DeathMessage.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathMessage.Location = new System.Drawing.Point(283, 156);
            this.DeathMessage.Name = "DeathMessage";
            this.DeathMessage.Size = new System.Drawing.Size(640, 265);
            this.DeathMessage.TabIndex = 92;
            this.DeathMessage.Text = resources.GetString("DeathMessage.Text");
            this.DeathMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeathArrow
            // 
            this.DeathArrow.BackColor = System.Drawing.Color.Black;
            this.DeathArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.DeathArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeathArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeathArrow.ForeColor = System.Drawing.Color.Transparent;
            this.DeathArrow.Location = new System.Drawing.Point(830, 434);
            this.DeathArrow.Name = "DeathArrow";
            this.DeathArrow.Size = new System.Drawing.Size(93, 30);
            this.DeathArrow.TabIndex = 93;
            this.DeathArrow.UseVisualStyleBackColor = false;
            this.DeathArrow.Click += new System.EventHandler(this.DeathArrow_Click);
            // 
            // FarText
            // 
            this.FarText.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarText.Location = new System.Drawing.Point(300, 30);
            this.FarText.Name = "FarText";
            this.FarText.Size = new System.Drawing.Size(641, 479);
            this.FarText.TabIndex = 94;
            this.FarText.Text = resources.GetString("FarText.Text");
            // 
            // FarArrow
            // 
            this.FarArrow.BackColor = System.Drawing.Color.Black;
            this.FarArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.FarArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FarArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FarArrow.ForeColor = System.Drawing.Color.Transparent;
            this.FarArrow.Location = new System.Drawing.Point(848, 512);
            this.FarArrow.Name = "FarArrow";
            this.FarArrow.Size = new System.Drawing.Size(93, 30);
            this.FarArrow.TabIndex = 95;
            this.FarArrow.UseVisualStyleBackColor = false;
            this.FarArrow.Click += new System.EventHandler(this.FarArrow_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Black;
            this.Return.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.Teal;
            this.Return.Location = new System.Drawing.Point(288, 285);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(190, 63);
            this.Return.TabIndex = 96;
            this.Return.Text = "Main Menu";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Font = new System.Drawing.Font("Determination Mono Web", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.Exit.Location = new System.Drawing.Point(751, 285);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 63);
            this.Exit.TabIndex = 97;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FarArrow2
            // 
            this.FarArrow2.BackColor = System.Drawing.Color.Black;
            this.FarArrow2.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.FarArrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FarArrow2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FarArrow2.ForeColor = System.Drawing.Color.Transparent;
            this.FarArrow2.Location = new System.Drawing.Point(848, 512);
            this.FarArrow2.Name = "FarArrow2";
            this.FarArrow2.Size = new System.Drawing.Size(93, 30);
            this.FarArrow2.TabIndex = 98;
            this.FarArrow2.UseVisualStyleBackColor = false;
            this.FarArrow2.Click += new System.EventHandler(this.FarArrow2_Click);
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.FarArrow2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.FarArrow);
            this.Controls.Add(this.FarText);
            this.Controls.Add(this.DeathArrow);
            this.Controls.Add(this.DeathMessage);
            this.Controls.Add(this.Far);
            this.Controls.Add(this.Near);
            this.Controls.Add(this.EndArrow2);
            this.Controls.Add(this.EndImg);
            this.Controls.Add(this.EndArrow);
            this.Controls.Add(this.EndText);
            this.Controls.Add(this.EndWhiteBox);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "End";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.EndImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EndText;
        private System.Windows.Forms.Label EndWhiteBox;
        private System.Windows.Forms.Button EndArrow;
        private System.Windows.Forms.PictureBox EndImg;
        private System.Windows.Forms.Button EndArrow2;
        private System.Windows.Forms.Button Far;
        private System.Windows.Forms.Button Near;
        private System.Windows.Forms.Label DeathMessage;
        private System.Windows.Forms.Button DeathArrow;
        private System.Windows.Forms.Label FarText;
        private System.Windows.Forms.Button FarArrow;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button FarArrow2;
    }
}