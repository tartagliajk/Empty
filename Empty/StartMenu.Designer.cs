namespace Empty
{
    partial class StartMenu
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
            this.Empty = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.DuckPicture = new System.Windows.Forms.PictureBox();
            this.CreditText = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.CreditPictureText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DuckPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Empty
            // 
            this.Empty.Dock = System.Windows.Forms.DockStyle.Top;
            this.Empty.Font = new System.Drawing.Font("Determination Mono Web", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empty.Location = new System.Drawing.Point(0, 0);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(1164, 304);
            this.Empty.TabIndex = 0;
            this.Empty.Text = "Empty";
            this.Empty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.Font = new System.Drawing.Font("Determination Mono Web", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartButton.Location = new System.Drawing.Point(490, 285);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(155, 48);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "start !";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.AutoSize = true;
            this.CreditsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreditsButton.BackColor = System.Drawing.Color.Black;
            this.CreditsButton.Font = new System.Drawing.Font("Determination Mono Web", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreditsButton.Location = new System.Drawing.Point(491, 397);
            this.CreditsButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(154, 48);
            this.CreditsButton.TabIndex = 7;
            this.CreditsButton.Text = "credits";
            this.CreditsButton.UseVisualStyleBackColor = false;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // DuckPicture
            // 
            this.DuckPicture.Image = global::Empty.Properties.Resources.DetectiveGoose;
            this.DuckPicture.InitialImage = null;
            this.DuckPicture.Location = new System.Drawing.Point(46, 99);
            this.DuckPicture.Name = "DuckPicture";
            this.DuckPicture.Size = new System.Drawing.Size(399, 397);
            this.DuckPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DuckPicture.TabIndex = 8;
            this.DuckPicture.TabStop = false;
            // 
            // CreditText
            // 
            this.CreditText.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditText.Location = new System.Drawing.Point(568, 157);
            this.CreditText.Name = "CreditText";
            this.CreditText.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.CreditText.Size = new System.Drawing.Size(555, 296);
            this.CreditText.TabIndex = 9;
            this.CreditText.Text = "A game by: Nina\r\n\r\nInspired by Minecraft && Undertale\r\n\r\nSpecial thanks to \r\n- Te" +
    "chnoblade ♛\r\n- Dottore (for exprementing on kids)\r\n- Tartaglia (for the funds :D" +
    ")";
            this.CreditText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Black;
            this.ReturnButton.Font = new System.Drawing.Font("Determination Mono Web", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(797, 486);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(103, 39);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CreditPictureText
            // 
            this.CreditPictureText.AutoSize = true;
            this.CreditPictureText.Font = new System.Drawing.Font("Determination Mono Web", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditPictureText.Location = new System.Drawing.Point(31, 504);
            this.CreditPictureText.Name = "CreditPictureText";
            this.CreditPictureText.Size = new System.Drawing.Size(449, 21);
            this.CreditPictureText.TabIndex = 12;
            this.CreditPictureText.Text = "Picture credits goes to the original artist\r\n";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.CreditPictureText);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.CreditText);
            this.Controls.Add(this.DuckPicture);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Empty);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.DuckPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Empty;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.PictureBox DuckPicture;
        private System.Windows.Forms.Label CreditText;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label CreditPictureText;
    }
}

