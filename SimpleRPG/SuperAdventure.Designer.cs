namespace SimpleRPG
{
    partial class SuperAdventure
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
            this.hitPointsLabel = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.hitPointsTextBox = new System.Windows.Forms.TextBox();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hitPointsLabel
            // 
            this.hitPointsLabel.AutoSize = true;
            this.hitPointsLabel.Location = new System.Drawing.Point(28, 26);
            this.hitPointsLabel.Name = "hitPointsLabel";
            this.hitPointsLabel.Size = new System.Drawing.Size(55, 13);
            this.hitPointsLabel.TabIndex = 0;
            this.hitPointsLabel.Text = "Hit Points:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Location = new System.Drawing.Point(28, 58);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(32, 13);
            this.goldLabel.TabIndex = 1;
            this.goldLabel.Text = "Gold:";
            // 
            // experienceLabel
            // 
            this.experienceLabel.AutoSize = true;
            this.experienceLabel.Location = new System.Drawing.Point(28, 90);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(63, 13);
            this.experienceLabel.TabIndex = 2;
            this.experienceLabel.Text = "Experience:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(31, 121);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Level:";
            // 
            // hitPointsTextBox
            // 
            this.hitPointsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hitPointsTextBox.Location = new System.Drawing.Point(121, 26);
            this.hitPointsTextBox.Name = "hitPointsTextBox";
            this.hitPointsTextBox.Size = new System.Drawing.Size(100, 13);
            this.hitPointsTextBox.TabIndex = 4;
            // 
            // goldTextBox
            // 
            this.goldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goldTextBox.Location = new System.Drawing.Point(121, 58);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.Size = new System.Drawing.Size(100, 13);
            this.goldTextBox.TabIndex = 5;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.experienceTextBox.Location = new System.Drawing.Point(121, 90);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(100, 13);
            this.experienceTextBox.TabIndex = 6;
            // 
            // levelTextBox
            // 
            this.levelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelTextBox.Location = new System.Drawing.Point(121, 121);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 13);
            this.levelTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(this.goldTextBox);
            this.Controls.Add(this.hitPointsTextBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.experienceLabel);
            this.Controls.Add(this.goldLabel);
            this.Controls.Add(this.hitPointsLabel);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hitPointsLabel;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox hitPointsTextBox;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Button button1;
    }
}

