namespace SWRPGrc.Views
{
    partial class Welcome
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
            this.btnCharSheet = new System.Windows.Forms.Button();
            this.btnMapper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCharSheet
            // 
            this.btnCharSheet.Location = new System.Drawing.Point(139, 31);
            this.btnCharSheet.Name = "btnCharSheet";
            this.btnCharSheet.Size = new System.Drawing.Size(139, 23);
            this.btnCharSheet.TabIndex = 0;
            this.btnCharSheet.Text = "Character Sheet";
            this.btnCharSheet.UseVisualStyleBackColor = true;
            this.btnCharSheet.Click += new System.EventHandler(this.btnCharSheet_Click);
            // 
            // btnMapper
            // 
            this.btnMapper.Location = new System.Drawing.Point(139, 69);
            this.btnMapper.Name = "btnMapper";
            this.btnMapper.Size = new System.Drawing.Size(139, 23);
            this.btnMapper.TabIndex = 1;
            this.btnMapper.Text = "Mapper";
            this.btnMapper.UseVisualStyleBackColor = true;
            this.btnMapper.Click += new System.EventHandler(this.btnMapper_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMapper);
            this.Controls.Add(this.btnCharSheet);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(591, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCharSheet;
        private System.Windows.Forms.Button btnMapper;
    }
}
