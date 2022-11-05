namespace Empty
{
    partial class Nether
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nether));
            this.NetherImg = new System.Windows.Forms.PictureBox();
            this.NetherDecision = new System.Windows.Forms.Label();
            this.Chests = new System.Windows.Forms.Button();
            this.Spawner = new System.Windows.Forms.Button();
            this.NetherWhiteBox = new System.Windows.Forms.Label();
            this.NetherTextBox = new System.Windows.Forms.Label();
            this.ChestImg = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.Button();
            this.SpawnerImg = new System.Windows.Forms.PictureBox();
            this.DecisionTextBox = new System.Windows.Forms.Label();
            this.Build = new System.Windows.Forms.Button();
            this.Dig = new System.Windows.Forms.Button();
            this.DecisionWhiteBox = new System.Windows.Forms.Label();
            this.DeathMessage = new System.Windows.Forms.Label();
            this.DeathArrow = new System.Windows.Forms.Button();
            this.Tunnel = new System.Windows.Forms.PictureBox();
            this.PigmenText = new System.Windows.Forms.Label();
            this.PigmenArrow = new System.Windows.Forms.Button();
            this.StrongholdArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NetherImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnerImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tunnel)).BeginInit();
            this.SuspendLayout();
            // 
            // NetherImg
            // 
            this.NetherImg.Image = global::Empty.Properties.Resources.Nether;
            this.NetherImg.Location = new System.Drawing.Point(55, 52);
            this.NetherImg.Name = "NetherImg";
            this.NetherImg.Size = new System.Drawing.Size(508, 279);
            this.NetherImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NetherImg.TabIndex = 53;
            this.NetherImg.TabStop = false;
            // 
            // NetherDecision
            // 
            this.NetherDecision.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetherDecision.Location = new System.Drawing.Point(65, 387);
            this.NetherDecision.Name = "NetherDecision";
            this.NetherDecision.Size = new System.Drawing.Size(487, 115);
            this.NetherDecision.TabIndex = 56;
            this.NetherDecision.Text = "Does the player go to the weapon smith or the archer range?";
            this.NetherDecision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chests
            // 
            this.Chests.BackColor = System.Drawing.Color.Black;
            this.Chests.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chests.ForeColor = System.Drawing.Color.Crimson;
            this.Chests.Location = new System.Drawing.Point(383, 538);
            this.Chests.Name = "Chests";
            this.Chests.Size = new System.Drawing.Size(150, 47);
            this.Chests.TabIndex = 55;
            this.Chests.Text = "Chests";
            this.Chests.UseVisualStyleBackColor = false;
            this.Chests.Click += new System.EventHandler(this.Chests_Click);
            // 
            // Spawner
            // 
            this.Spawner.BackColor = System.Drawing.Color.Black;
            this.Spawner.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spawner.ForeColor = System.Drawing.Color.SlateGray;
            this.Spawner.Location = new System.Drawing.Point(85, 538);
            this.Spawner.Name = "Spawner";
            this.Spawner.Size = new System.Drawing.Size(150, 47);
            this.Spawner.TabIndex = 54;
            this.Spawner.Text = "Spawner";
            this.Spawner.UseVisualStyleBackColor = false;
            this.Spawner.Click += new System.EventHandler(this.Spawner_Click);
            // 
            // NetherWhiteBox
            // 
            this.NetherWhiteBox.BackColor = System.Drawing.Color.White;
            this.NetherWhiteBox.Location = new System.Drawing.Point(54, 376);
            this.NetherWhiteBox.Name = "NetherWhiteBox";
            this.NetherWhiteBox.Size = new System.Drawing.Size(508, 138);
            this.NetherWhiteBox.TabIndex = 57;
            // 
            // NetherTextBox
            // 
            this.NetherTextBox.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetherTextBox.Location = new System.Drawing.Point(654, 86);
            this.NetherTextBox.Name = "NetherTextBox";
            this.NetherTextBox.Size = new System.Drawing.Size(463, 428);
            this.NetherTextBox.TabIndex = 58;
            this.NetherTextBox.Text = resources.GetString("NetherTextBox.Text");
            this.NetherTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChestImg
            // 
            this.ChestImg.Image = global::Empty.Properties.Resources.Chests;
            this.ChestImg.Location = new System.Drawing.Point(54, 148);
            this.ChestImg.Name = "ChestImg";
            this.ChestImg.Size = new System.Drawing.Size(508, 279);
            this.ChestImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChestImg.TabIndex = 59;
            this.ChestImg.TabStop = false;
            // 
            // Arrow
            // 
            this.Arrow.BackColor = System.Drawing.Color.Black;
            this.Arrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.Arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Arrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Arrow.ForeColor = System.Drawing.Color.Transparent;
            this.Arrow.Location = new System.Drawing.Point(987, 517);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(93, 24);
            this.Arrow.TabIndex = 60;
            this.Arrow.UseVisualStyleBackColor = false;
            this.Arrow.Click += new System.EventHandler(this.Arrow_Click);
            // 
            // SpawnerImg
            // 
            this.SpawnerImg.Image = global::Empty.Properties.Resources.Spawner;
            this.SpawnerImg.Location = new System.Drawing.Point(55, 148);
            this.SpawnerImg.Name = "SpawnerImg";
            this.SpawnerImg.Size = new System.Drawing.Size(508, 279);
            this.SpawnerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpawnerImg.TabIndex = 61;
            this.SpawnerImg.TabStop = false;
            // 
            // DecisionTextBox
            // 
            this.DecisionTextBox.Font = new System.Drawing.Font("Determination Mono Web", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionTextBox.Location = new System.Drawing.Point(368, 243);
            this.DecisionTextBox.Name = "DecisionTextBox";
            this.DecisionTextBox.Size = new System.Drawing.Size(487, 115);
            this.DecisionTextBox.TabIndex = 64;
            this.DecisionTextBox.Text = "Does it bridge over the lava or does the player dig its way through?";
            this.DecisionTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Build
            // 
            this.Build.BackColor = System.Drawing.Color.Black;
            this.Build.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build.ForeColor = System.Drawing.Color.Crimson;
            this.Build.Location = new System.Drawing.Point(686, 394);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(150, 47);
            this.Build.TabIndex = 63;
            this.Build.Text = "Build";
            this.Build.UseVisualStyleBackColor = false;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // Dig
            // 
            this.Dig.BackColor = System.Drawing.Color.Black;
            this.Dig.Font = new System.Drawing.Font("Determination Mono Web", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dig.ForeColor = System.Drawing.Color.SlateGray;
            this.Dig.Location = new System.Drawing.Point(388, 394);
            this.Dig.Name = "Dig";
            this.Dig.Size = new System.Drawing.Size(150, 47);
            this.Dig.TabIndex = 62;
            this.Dig.Text = "Dig";
            this.Dig.UseVisualStyleBackColor = false;
            this.Dig.Click += new System.EventHandler(this.Dig_Click);
            // 
            // DecisionWhiteBox
            // 
            this.DecisionWhiteBox.BackColor = System.Drawing.Color.White;
            this.DecisionWhiteBox.Location = new System.Drawing.Point(357, 232);
            this.DecisionWhiteBox.Name = "DecisionWhiteBox";
            this.DecisionWhiteBox.Size = new System.Drawing.Size(508, 138);
            this.DecisionWhiteBox.TabIndex = 65;
            // 
            // DeathMessage
            // 
            this.DeathMessage.Font = new System.Drawing.Font("Determination Mono Web", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathMessage.Location = new System.Drawing.Point(336, 172);
            this.DeathMessage.Name = "DeathMessage";
            this.DeathMessage.Size = new System.Drawing.Size(577, 269);
            this.DeathMessage.TabIndex = 66;
            this.DeathMessage.Text = "One block, Two blocks, Three blocks, Four blocks.\r\nMisplaced. \r\nIt falls from its" +
    " own creation. \r\n“Failure” it thought as the lava wrapped around it. \r\n“Back to " +
    "black”\r\nDeath";
            this.DeathMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeathArrow
            // 
            this.DeathArrow.BackColor = System.Drawing.Color.Black;
            this.DeathArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.DeathArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeathArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeathArrow.ForeColor = System.Drawing.Color.Transparent;
            this.DeathArrow.Location = new System.Drawing.Point(820, 444);
            this.DeathArrow.Name = "DeathArrow";
            this.DeathArrow.Size = new System.Drawing.Size(93, 24);
            this.DeathArrow.TabIndex = 67;
            this.DeathArrow.UseVisualStyleBackColor = false;
            this.DeathArrow.Click += new System.EventHandler(this.DeathArrow_Click);
            // 
            // Tunnel
            // 
            this.Tunnel.Image = global::Empty.Properties.Resources.Tunnel;
            this.Tunnel.Location = new System.Drawing.Point(620, 159);
            this.Tunnel.Name = "Tunnel";
            this.Tunnel.Size = new System.Drawing.Size(508, 279);
            this.Tunnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tunnel.TabIndex = 68;
            this.Tunnel.TabStop = false;
            // 
            // PigmenText
            // 
            this.PigmenText.Font = new System.Drawing.Font("Determination Mono Web", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PigmenText.Location = new System.Drawing.Point(12, 89);
            this.PigmenText.Name = "PigmenText";
            this.PigmenText.Size = new System.Drawing.Size(577, 446);
            this.PigmenText.TabIndex = 69;
            this.PigmenText.Text = resources.GetString("PigmenText.Text");
            this.PigmenText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PigmenArrow
            // 
            this.PigmenArrow.BackColor = System.Drawing.Color.Black;
            this.PigmenArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.PigmenArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PigmenArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PigmenArrow.ForeColor = System.Drawing.Color.Transparent;
            this.PigmenArrow.Location = new System.Drawing.Point(1035, 444);
            this.PigmenArrow.Name = "PigmenArrow";
            this.PigmenArrow.Size = new System.Drawing.Size(93, 24);
            this.PigmenArrow.TabIndex = 70;
            this.PigmenArrow.UseVisualStyleBackColor = false;
            this.PigmenArrow.Click += new System.EventHandler(this.PigmenArrow_Click);
            // 
            // StrongholdArrow
            // 
            this.StrongholdArrow.BackColor = System.Drawing.Color.Black;
            this.StrongholdArrow.BackgroundImage = global::Empty.Properties.Resources.Arrow;
            this.StrongholdArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StrongholdArrow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StrongholdArrow.ForeColor = System.Drawing.Color.Transparent;
            this.StrongholdArrow.Location = new System.Drawing.Point(1035, 444);
            this.StrongholdArrow.Name = "StrongholdArrow";
            this.StrongholdArrow.Size = new System.Drawing.Size(93, 24);
            this.StrongholdArrow.TabIndex = 71;
            this.StrongholdArrow.UseVisualStyleBackColor = false;
            this.StrongholdArrow.Click += new System.EventHandler(this.StrongholdArrow_Click);
            // 
            // Nether
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.StrongholdArrow);
            this.Controls.Add(this.PigmenArrow);
            this.Controls.Add(this.PigmenText);
            this.Controls.Add(this.Tunnel);
            this.Controls.Add(this.DeathArrow);
            this.Controls.Add(this.DeathMessage);
            this.Controls.Add(this.DecisionTextBox);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Dig);
            this.Controls.Add(this.DecisionWhiteBox);
            this.Controls.Add(this.SpawnerImg);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.ChestImg);
            this.Controls.Add(this.NetherTextBox);
            this.Controls.Add(this.NetherDecision);
            this.Controls.Add(this.Chests);
            this.Controls.Add(this.Spawner);
            this.Controls.Add(this.NetherWhiteBox);
            this.Controls.Add(this.NetherImg);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Nether";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty";
            ((System.ComponentModel.ISupportInitialize)(this.NetherImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpawnerImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tunnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox NetherImg;
        private System.Windows.Forms.Label NetherDecision;
        private System.Windows.Forms.Button Chests;
        private System.Windows.Forms.Button Spawner;
        private System.Windows.Forms.Label NetherWhiteBox;
        private System.Windows.Forms.Label NetherTextBox;
        private System.Windows.Forms.PictureBox ChestImg;
        private System.Windows.Forms.Button Arrow;
        private System.Windows.Forms.PictureBox SpawnerImg;
        private System.Windows.Forms.Label DecisionTextBox;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Button Dig;
        private System.Windows.Forms.Label DecisionWhiteBox;
        private System.Windows.Forms.Label DeathMessage;
        private System.Windows.Forms.Button DeathArrow;
        private System.Windows.Forms.PictureBox Tunnel;
        private System.Windows.Forms.Label PigmenText;
        private System.Windows.Forms.Button PigmenArrow;
        private System.Windows.Forms.Button StrongholdArrow;
    }
}