namespace BattleMgr
{
    partial class AddMstr
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
            this.mstrCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mstrCb
            // 
            this.mstrCb.FormattingEnabled = true;
            this.mstrCb.Location = new System.Drawing.Point(141, 41);
            this.mstrCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mstrCb.Name = "mstrCb";
            this.mstrCb.Size = new System.Drawing.Size(263, 24);
            this.mstrCb.Sorted = true;
            this.mstrCb.TabIndex = 0;
            // 
            // AddMstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 511);
            this.Controls.Add(this.mstrCb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMstr";
            this.Text = "AddMstr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mstrCb;
    }
}