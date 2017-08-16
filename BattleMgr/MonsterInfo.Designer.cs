namespace BattleMgr
{
    partial class MonsterInfo
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
            this.mstrName = new System.Windows.Forms.Label();
            this.mstrSize = new System.Windows.Forms.Label();
            this.mstrType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mstrHP = new System.Windows.Forms.Label();
            this.mstrAC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mstrName
            // 
            this.mstrName.AutoSize = true;
            this.mstrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrName.Location = new System.Drawing.Point(13, 13);
            this.mstrName.Name = "mstrName";
            this.mstrName.Size = new System.Drawing.Size(132, 46);
            this.mstrName.TabIndex = 0;
            this.mstrName.Text = "label1";
            // 
            // mstrSize
            // 
            this.mstrSize.AutoSize = true;
            this.mstrSize.Location = new System.Drawing.Point(12, 63);
            this.mstrSize.Name = "mstrSize";
            this.mstrSize.Size = new System.Drawing.Size(33, 17);
            this.mstrSize.TabIndex = 1;
            this.mstrSize.Text = "size";
            // 
            // mstrType
            // 
            this.mstrType.AutoSize = true;
            this.mstrType.Location = new System.Drawing.Point(72, 63);
            this.mstrType.Name = "mstrType";
            this.mstrType.Size = new System.Drawing.Size(35, 17);
            this.mstrType.TabIndex = 2;
            this.mstrType.Text = "type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "AC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max HP:";
            // 
            // mstrHP
            // 
            this.mstrHP.AutoSize = true;
            this.mstrHP.Location = new System.Drawing.Point(85, 93);
            this.mstrHP.Name = "mstrHP";
            this.mstrHP.Size = new System.Drawing.Size(27, 17);
            this.mstrHP.TabIndex = 6;
            this.mstrHP.Text = "HP";
            // 
            // mstrAC
            // 
            this.mstrAC.AutoSize = true;
            this.mstrAC.Location = new System.Drawing.Point(198, 93);
            this.mstrAC.Name = "mstrAC";
            this.mstrAC.Size = new System.Drawing.Size(26, 17);
            this.mstrAC.TabIndex = 7;
            this.mstrAC.Text = "AC";
            // 
            // MonsterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 473);
            this.Controls.Add(this.mstrAC);
            this.Controls.Add(this.mstrHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mstrType);
            this.Controls.Add(this.mstrSize);
            this.Controls.Add(this.mstrName);
            this.Name = "MonsterInfo";
            this.Text = "MonsterInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mstrName;
        private System.Windows.Forms.Label mstrSize;
        private System.Windows.Forms.Label mstrType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mstrHP;
        private System.Windows.Forms.Label mstrAC;
    }
}