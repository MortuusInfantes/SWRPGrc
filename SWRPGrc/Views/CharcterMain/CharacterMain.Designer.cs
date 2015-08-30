namespace SWRPGrc.Views.CharcterMain
{
    partial class CharacterMain
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
            this.BtnNewChar = new System.Windows.Forms.Button();
            this.BtnCharTemp = new System.Windows.Forms.Button();
            this.PnlCharMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnNewChar
            // 
            this.BtnNewChar.Location = new System.Drawing.Point(27, 3);
            this.BtnNewChar.Name = "BtnNewChar";
            this.BtnNewChar.Size = new System.Drawing.Size(134, 23);
            this.BtnNewChar.TabIndex = 0;
            this.BtnNewChar.Text = "New Character";
            this.BtnNewChar.UseVisualStyleBackColor = true;
            this.BtnNewChar.Click += new System.EventHandler(this.BtnNewChar_Click);
            // 
            // BtnCharTemp
            // 
            this.BtnCharTemp.Location = new System.Drawing.Point(571, 3);
            this.BtnCharTemp.Name = "BtnCharTemp";
            this.BtnCharTemp.Size = new System.Drawing.Size(134, 23);
            this.BtnCharTemp.TabIndex = 1;
            this.BtnCharTemp.Text = "Character Templete";
            this.BtnCharTemp.UseVisualStyleBackColor = true;
            this.BtnCharTemp.Click += new System.EventHandler(this.BtnCharTemp_Click);
            // 
            // PnlCharMain
            // 
            this.PnlCharMain.Location = new System.Drawing.Point(14, 32);
            this.PnlCharMain.Name = "PnlCharMain";
            this.PnlCharMain.Size = new System.Drawing.Size(727, 675);
            this.PnlCharMain.TabIndex = 2;
            // 
            // CharacterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlCharMain);
            this.Controls.Add(this.BtnCharTemp);
            this.Controls.Add(this.BtnNewChar);
            this.Name = "CharacterMain";
            this.Size = new System.Drawing.Size(760, 710);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewChar;
        private System.Windows.Forms.Button BtnCharTemp;
        private System.Windows.Forms.Panel PnlCharMain;
    }
}
