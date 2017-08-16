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
            this.addMstrLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumGenLabel = new System.Windows.Forms.Label();
            this.numGenUd = new System.Windows.Forms.NumericUpDown();
            this.makeCustMstr = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errMsg = new System.Windows.Forms.Label();
            this.autoInit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGenUd)).BeginInit();
            this.SuspendLayout();
            // 
            // mstrCb
            // 
            this.mstrCb.FormattingEnabled = true;
            this.mstrCb.Location = new System.Drawing.Point(95, 68);
            this.mstrCb.Margin = new System.Windows.Forms.Padding(4);
            this.mstrCb.Name = "mstrCb";
            this.mstrCb.Size = new System.Drawing.Size(263, 24);
            this.mstrCb.Sorted = true;
            this.mstrCb.TabIndex = 0;
            // 
            // addMstrLabel
            // 
            this.addMstrLabel.AutoSize = true;
            this.addMstrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMstrLabel.Location = new System.Drawing.Point(12, 9);
            this.addMstrLabel.Name = "addMstrLabel";
            this.addMstrLabel.Size = new System.Drawing.Size(257, 46);
            this.addMstrLabel.TabIndex = 1;
            this.addMstrLabel.Text = "Add Monster";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monster:";
            // 
            // NumGenLabel
            // 
            this.NumGenLabel.AutoSize = true;
            this.NumGenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumGenLabel.Location = new System.Drawing.Point(17, 121);
            this.NumGenLabel.Name = "NumGenLabel";
            this.NumGenLabel.Size = new System.Drawing.Size(114, 17);
            this.NumGenLabel.TabIndex = 3;
            this.NumGenLabel.Text = "# to Generate:";
            // 
            // numGenUd
            // 
            this.numGenUd.Location = new System.Drawing.Point(140, 119);
            this.numGenUd.Name = "numGenUd";
            this.numGenUd.Size = new System.Drawing.Size(56, 22);
            this.numGenUd.TabIndex = 4;
            this.numGenUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // makeCustMstr
            // 
            this.makeCustMstr.Location = new System.Drawing.Point(20, 167);
            this.makeCustMstr.Name = "makeCustMstr";
            this.makeCustMstr.Size = new System.Drawing.Size(176, 27);
            this.makeCustMstr.TabIndex = 5;
            this.makeCustMstr.Text = "Make a Custom Monster";
            this.makeCustMstr.UseVisualStyleBackColor = true;
            this.makeCustMstr.Click += new System.EventHandler(this.makeCustMstr_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(13, 284);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(83, 29);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(337, 284);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 29);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errMsg
            // 
            this.errMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(12, 254);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(175, 17);
            this.errMsg.TabIndex = 8;
            this.errMsg.Text = "Please input a Monster";
            this.errMsg.Visible = false;
            // 
            // autoInit
            // 
            this.autoInit.AutoSize = true;
            this.autoInit.Location = new System.Drawing.Point(20, 212);
            this.autoInit.Name = "autoInit";
            this.autoInit.Size = new System.Drawing.Size(150, 21);
            this.autoInit.TabIndex = 9;
            this.autoInit.Text = "Auto Roll Initiative?";
            this.autoInit.UseVisualStyleBackColor = true;
            // 
            // AddMstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 325);
            this.Controls.Add(this.autoInit);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.makeCustMstr);
            this.Controls.Add(this.numGenUd);
            this.Controls.Add(this.NumGenLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMstrLabel);
            this.Controls.Add(this.mstrCb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMstr";
            this.Text = "AddMstr";
            ((System.ComponentModel.ISupportInitialize)(this.numGenUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mstrCb;
        private System.Windows.Forms.Label addMstrLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumGenLabel;
        private System.Windows.Forms.NumericUpDown numGenUd;
        private System.Windows.Forms.Button makeCustMstr;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.CheckBox autoInit;
    }
}