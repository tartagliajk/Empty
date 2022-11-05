namespace Empty
{
    partial class GameOver
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
            this.Exit = new System.Windows.Forms.Button();
            this.StartOver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Font = new System.Drawing.Font("Determination Mono Web", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(132, 264);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(307, 71);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.end_Click);
            // 
            // StartOver
            // 
            this.StartOver.AutoSize = true;
            this.StartOver.BackColor = System.Drawing.Color.Black;
            this.StartOver.Font = new System.Drawing.Font("Determination Mono Web", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartOver.ForeColor = System.Drawing.Color.Red;
            this.StartOver.Location = new System.Drawing.Point(683, 264);
            this.StartOver.Name = "StartOver";
            this.StartOver.Size = new System.Drawing.Size(307, 71);
            this.StartOver.TabIndex = 2;
            this.StartOver.Text = "Home Menu";
            this.StartOver.UseVisualStyleBackColor = false;
            this.StartOver.Click += new System.EventHandler(this.StartOver_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.StartOver);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Determination Mono Web", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME OVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button StartOver;
    }
}