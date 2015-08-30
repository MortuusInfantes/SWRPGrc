namespace SWRPGrc.Views.CharcterMain.NewCharacter.ScoreClassSpecies.Score
{
    partial class ScoreMain
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
            this.RadButRandom = new System.Windows.Forms.RadioButton();
            this.RadButPlanGen = new System.Windows.Forms.RadioButton();
            this.RadButStandScor = new System.Windows.Forms.RadioButton();
            this.TxtBxSelect = new System.Windows.Forms.Button();
            this.PnlScoreInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // RadButRandom
            // 
            this.RadButRandom.AutoSize = true;
            this.RadButRandom.Location = new System.Drawing.Point(25, 3);
            this.RadButRandom.Name = "RadButRandom";
            this.RadButRandom.Size = new System.Drawing.Size(65, 17);
            this.RadButRandom.TabIndex = 0;
            this.RadButRandom.TabStop = true;
            this.RadButRandom.Text = "Random";
            this.RadButRandom.UseVisualStyleBackColor = true;
            this.RadButRandom.CheckedChanged += new System.EventHandler(this.RadButRandom_CheckedChanged);
            // 
            // RadButPlanGen
            // 
            this.RadButPlanGen.AutoSize = true;
            this.RadButPlanGen.Location = new System.Drawing.Point(124, 3);
            this.RadButPlanGen.Name = "RadButPlanGen";
            this.RadButPlanGen.Size = new System.Drawing.Size(119, 17);
            this.RadButPlanGen.TabIndex = 1;
            this.RadButPlanGen.TabStop = true;
            this.RadButPlanGen.Text = "Planned Generation";
            this.RadButPlanGen.UseVisualStyleBackColor = true;
            this.RadButPlanGen.CheckedChanged += new System.EventHandler(this.RadButPlanGen_CheckedChanged);
            // 
            // RadButStandScor
            // 
            this.RadButStandScor.AutoSize = true;
            this.RadButStandScor.Location = new System.Drawing.Point(261, 3);
            this.RadButStandScor.Name = "RadButStandScor";
            this.RadButStandScor.Size = new System.Drawing.Size(145, 17);
            this.RadButStandScor.TabIndex = 2;
            this.RadButStandScor.TabStop = true;
            this.RadButStandScor.Text = "Standard Score Package";
            this.RadButStandScor.UseVisualStyleBackColor = true;
            this.RadButStandScor.CheckedChanged += new System.EventHandler(this.RadButStandScor_CheckedChanged);
            // 
            // TxtBxSelect
            // 
            this.TxtBxSelect.Location = new System.Drawing.Point(124, 170);
            this.TxtBxSelect.Name = "TxtBxSelect";
            this.TxtBxSelect.Size = new System.Drawing.Size(130, 25);
            this.TxtBxSelect.TabIndex = 3;
            this.TxtBxSelect.Text = "Select";
            this.TxtBxSelect.UseVisualStyleBackColor = true;
            this.TxtBxSelect.Click += new System.EventHandler(this.TxtBxSelect_Click);
            // 
            // PnlScoreInfo
            // 
            this.PnlScoreInfo.Location = new System.Drawing.Point(7, 22);
            this.PnlScoreInfo.Name = "PnlScoreInfo";
            this.PnlScoreInfo.Size = new System.Drawing.Size(398, 142);
            this.PnlScoreInfo.TabIndex = 4;
            // 
            // ScoreMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlScoreInfo);
            this.Controls.Add(this.TxtBxSelect);
            this.Controls.Add(this.RadButStandScor);
            this.Controls.Add(this.RadButPlanGen);
            this.Controls.Add(this.RadButRandom);
            this.Name = "ScoreMain";
            this.Size = new System.Drawing.Size(409, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadButRandom;
        private System.Windows.Forms.RadioButton RadButPlanGen;
        private System.Windows.Forms.RadioButton RadButStandScor;
        private System.Windows.Forms.Button TxtBxSelect;
        private System.Windows.Forms.Panel PnlScoreInfo;
    }
}
