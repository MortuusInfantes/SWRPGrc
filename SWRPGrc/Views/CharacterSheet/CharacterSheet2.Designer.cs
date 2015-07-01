namespace SWRPGrc.Views
{
    partial class CharacterSheet2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CampaignTextBox = new System.Windows.Forms.TextBox();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.CampaignLabel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CampaignTextBox);
            this.groupBox1.Controls.Add(this.PlayerNameTextBox);
            this.groupBox1.Controls.Add(this.CharacterNameTextBox);
            this.groupBox1.Controls.Add(this.CampaignLabel);
            this.groupBox1.Controls.Add(this.PlayerNameLabel);
            this.groupBox1.Controls.Add(this.CharacterNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Info";
            // 
            // CampaignTextBox
            // 
            this.CampaignTextBox.Location = new System.Drawing.Point(456, 21);
            this.CampaignTextBox.Name = "CampaignTextBox";
            this.CampaignTextBox.Size = new System.Drawing.Size(100, 20);
            this.CampaignTextBox.TabIndex = 40;
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(280, 21);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlayerNameTextBox.TabIndex = 39;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(96, 21);
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CharacterNameTextBox.TabIndex = 38;
            // 
            // CampaignLabel
            // 
            this.CampaignLabel.AutoSize = true;
            this.CampaignLabel.Location = new System.Drawing.Point(396, 24);
            this.CampaignLabel.Name = "CampaignLabel";
            this.CampaignLabel.Size = new System.Drawing.Size(54, 13);
            this.CampaignLabel.TabIndex = 37;
            this.CampaignLabel.Text = "Campaign";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(207, 24);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.PlayerNameLabel.TabIndex = 36;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.AutoSize = true;
            this.CharacterNameLabel.Location = new System.Drawing.Point(6, 24);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(84, 13);
            this.CharacterNameLabel.TabIndex = 35;
            this.CharacterNameLabel.Text = "Character Name";
            // 
            // CharacterSheet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CharacterSheet2";
            this.Size = new System.Drawing.Size(592, 471);
            this.Load += new System.EventHandler(this.CharacterSheet2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CampaignTextBox;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label CampaignLabel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label CharacterNameLabel;

    }
}
