namespace SWRPGrc.Views
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPlan = new System.Windows.Forms.Button();
            this.BtnCamp = new System.Windows.Forms.Button();
            this.BtnChar = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(Username)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Time)";
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Location = new System.Drawing.Point(15, 107);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(760, 710);
            this.PanelMain.TabIndex = 4;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(111, 78);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 5;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnPlan
            // 
            this.BtnPlan.Location = new System.Drawing.Point(193, 78);
            this.BtnPlan.Name = "BtnPlan";
            this.BtnPlan.Size = new System.Drawing.Size(75, 23);
            this.BtnPlan.TabIndex = 6;
            this.BtnPlan.Text = "Plan";
            this.BtnPlan.UseVisualStyleBackColor = true;
            this.BtnPlan.Click += new System.EventHandler(this.BtnPlan_Click);
            // 
            // BtnCamp
            // 
            this.BtnCamp.Location = new System.Drawing.Point(274, 78);
            this.BtnCamp.Name = "BtnCamp";
            this.BtnCamp.Size = new System.Drawing.Size(75, 23);
            this.BtnCamp.TabIndex = 7;
            this.BtnCamp.Text = "Campaigns";
            this.BtnCamp.UseVisualStyleBackColor = true;
            this.BtnCamp.Click += new System.EventHandler(this.BtnCamp_Click);
            // 
            // BtnChar
            // 
            this.BtnChar.Location = new System.Drawing.Point(404, 78);
            this.BtnChar.Name = "BtnChar";
            this.BtnChar.Size = new System.Drawing.Size(75, 23);
            this.BtnChar.TabIndex = 8;
            this.BtnChar.Text = "Characters";
            this.BtnChar.UseVisualStyleBackColor = true;
            this.BtnChar.Click += new System.EventHandler(this.BtnChar_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(548, 78);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 23);
            this.BtnSet.TabIndex = 9;
            this.BtnSet.Text = "Settings";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(30, 78);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 23);
            this.BtnHome.TabIndex = 10;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.BtnChar);
            this.Controls.Add(this.BtnCamp);
            this.Controls.Add(this.BtnPlan);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(806, 820);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPlan;
        private System.Windows.Forms.Button BtnCamp;
        private System.Windows.Forms.Button BtnChar;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Button BtnHome;
    }
}
