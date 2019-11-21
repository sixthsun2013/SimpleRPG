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
            this.label1 = new System.Windows.Forms.Label();
            this.weaponsComboBox = new System.Windows.Forms.ComboBox();
            this.potionsComboBox = new System.Windows.Forms.ComboBox();
            this.useWeaponButton = new System.Windows.Forms.Button();
            this.usePotionButton = new System.Windows.Forms.Button();
            this.northButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.locationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.questsDataGridView = new System.Windows.Forms.DataGridView();
            this.InventoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.questsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Action";
            // 
            // weaponsComboBox
            // 
            this.weaponsComboBox.FormattingEnabled = true;
            this.weaponsComboBox.Location = new System.Drawing.Point(525, 556);
            this.weaponsComboBox.Name = "weaponsComboBox";
            this.weaponsComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponsComboBox.TabIndex = 9;
            // 
            // potionsComboBox
            // 
            this.potionsComboBox.FormattingEnabled = true;
            this.potionsComboBox.Location = new System.Drawing.Point(525, 585);
            this.potionsComboBox.Name = "potionsComboBox";
            this.potionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.potionsComboBox.TabIndex = 10;
            // 
            // useWeaponButton
            // 
            this.useWeaponButton.Location = new System.Drawing.Point(403, 554);
            this.useWeaponButton.Name = "useWeaponButton";
            this.useWeaponButton.Size = new System.Drawing.Size(113, 23);
            this.useWeaponButton.TabIndex = 11;
            this.useWeaponButton.Text = "Use Weapon";
            this.useWeaponButton.UseVisualStyleBackColor = true;
            this.useWeaponButton.Click += new System.EventHandler(this.useWeaponButton_Click);
            // 
            // usePotionButton
            // 
            this.usePotionButton.Location = new System.Drawing.Point(403, 583);
            this.usePotionButton.Name = "usePotionButton";
            this.usePotionButton.Size = new System.Drawing.Size(113, 23);
            this.usePotionButton.TabIndex = 12;
            this.usePotionButton.Text = "Use Potion";
            this.usePotionButton.UseVisualStyleBackColor = true;
            this.usePotionButton.Click += new System.EventHandler(this.usePotionButton_Click);
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(459, 442);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(113, 23);
            this.northButton.TabIndex = 13;
            this.northButton.Text = "North";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.northButton_Click);
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(533, 474);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(113, 23);
            this.eastButton.TabIndex = 14;
            this.eastButton.Text = "East";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.eastButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(459, 503);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(113, 23);
            this.southButton.TabIndex = 15;
            this.southButton.Text = "South";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.southButton_Click);
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(403, 474);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(113, 23);
            this.westButton.TabIndex = 16;
            this.westButton.Text = "West";
            this.westButton.UseVisualStyleBackColor = true;
            this.westButton.Click += new System.EventHandler(this.westButton_Click);
            // 
            // locationRichTextBox
            // 
            this.locationRichTextBox.Location = new System.Drawing.Point(296, 38);
            this.locationRichTextBox.Name = "locationRichTextBox";
            this.locationRichTextBox.ReadOnly = true;
            this.locationRichTextBox.Size = new System.Drawing.Size(350, 96);
            this.locationRichTextBox.TabIndex = 17;
            this.locationRichTextBox.Text = "";
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(296, 175);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.ReadOnly = true;
            this.messagesRichTextBox.Size = new System.Drawing.Size(350, 199);
            this.messagesRichTextBox.TabIndex = 18;
            this.messagesRichTextBox.Text = "";
            // 
            // questsDataGridView
            // 
            this.questsDataGridView.AllowUserToAddRows = false;
            this.questsDataGridView.AllowUserToDeleteRows = false;
            this.questsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.questsDataGridView.Location = new System.Drawing.Point(31, 427);
            this.questsDataGridView.MultiSelect = false;
            this.questsDataGridView.Name = "questsDataGridView";
            this.questsDataGridView.ReadOnly = true;
            this.questsDataGridView.Size = new System.Drawing.Size(240, 179);
            this.questsDataGridView.TabIndex = 19;
            // 
            // InventoryDataGridView
            // 
            this.InventoryDataGridView.AllowUserToAddRows = false;
            this.InventoryDataGridView.AllowUserToDeleteRows = false;
            this.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryDataGridView.Location = new System.Drawing.Point(31, 175);
            this.InventoryDataGridView.MultiSelect = false;
            this.InventoryDataGridView.Name = "InventoryDataGridView";
            this.InventoryDataGridView.ReadOnly = true;
            this.InventoryDataGridView.Size = new System.Drawing.Size(240, 199);
            this.InventoryDataGridView.TabIndex = 20;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.InventoryDataGridView);
            this.Controls.Add(this.questsDataGridView);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.locationRichTextBox);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.usePotionButton);
            this.Controls.Add(this.useWeaponButton);
            this.Controls.Add(this.potionsComboBox);
            this.Controls.Add(this.weaponsComboBox);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.questsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox weaponsComboBox;
        private System.Windows.Forms.ComboBox potionsComboBox;
        private System.Windows.Forms.Button useWeaponButton;
        private System.Windows.Forms.Button usePotionButton;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.RichTextBox locationRichTextBox;
        private System.Windows.Forms.RichTextBox messagesRichTextBox;
        private System.Windows.Forms.DataGridView questsDataGridView;
        private System.Windows.Forms.DataGridView InventoryDataGridView;
    }
}

