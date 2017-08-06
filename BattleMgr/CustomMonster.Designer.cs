﻿namespace BattleMgr
{
    partial class CustomMonster
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
            this.customMstrTitle = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpUd = new System.Windows.Forms.NumericUpDown();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acLbl = new System.Windows.Forms.Label();
            this.acUd = new System.Windows.Forms.NumericUpDown();
            this.strLbl = new System.Windows.Forms.Label();
            this.strUd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dexUd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.consUd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.intUd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.wisUd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.charUd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.sensesTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dmgResTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dmgImmTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.condImmTb = new System.Windows.Forms.TextBox();
            this.errMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hpUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charUd)).BeginInit();
            this.SuspendLayout();
            // 
            // customMstrTitle
            // 
            this.customMstrTitle.AutoSize = true;
            this.customMstrTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customMstrTitle.Location = new System.Drawing.Point(12, 9);
            this.customMstrTitle.Name = "customMstrTitle";
            this.customMstrTitle.Size = new System.Drawing.Size(327, 46);
            this.customMstrTitle.TabIndex = 0;
            this.customMstrTitle.Text = "Custom Monster";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(72, 70);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(267, 22);
            this.nameTb.TabIndex = 2;
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(17, 115);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(31, 17);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP:";
            // 
            // hpUd
            // 
            this.hpUd.Location = new System.Drawing.Point(72, 113);
            this.hpUd.Name = "hpUd";
            this.hpUd.Size = new System.Drawing.Size(72, 22);
            this.hpUd.TabIndex = 4;
            this.hpUd.Enter += new System.EventHandler(this.hpUd_Enter);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(13, 413);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(80, 26);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(408, 413);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 26);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // acLbl
            // 
            this.acLbl.AutoSize = true;
            this.acLbl.Location = new System.Drawing.Point(168, 115);
            this.acLbl.Name = "acLbl";
            this.acLbl.Size = new System.Drawing.Size(88, 17);
            this.acLbl.TabIndex = 7;
            this.acLbl.Text = "Armor Class:";
            // 
            // acUd
            // 
            this.acUd.Location = new System.Drawing.Point(262, 113);
            this.acUd.Name = "acUd";
            this.acUd.Size = new System.Drawing.Size(77, 22);
            this.acUd.TabIndex = 8;
            this.acUd.Enter += new System.EventHandler(this.acUd_Enter);
            // 
            // strLbl
            // 
            this.strLbl.AutoSize = true;
            this.strLbl.Location = new System.Drawing.Point(17, 160);
            this.strLbl.Name = "strLbl";
            this.strLbl.Size = new System.Drawing.Size(30, 17);
            this.strLbl.TabIndex = 9;
            this.strLbl.Text = "Str:";
            // 
            // strUd
            // 
            this.strUd.Location = new System.Drawing.Point(53, 158);
            this.strUd.Name = "strUd";
            this.strUd.Size = new System.Drawing.Size(55, 22);
            this.strUd.TabIndex = 10;
            this.strUd.Enter += new System.EventHandler(this.strUd_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dex:";
            // 
            // dexUd
            // 
            this.dexUd.Location = new System.Drawing.Point(220, 158);
            this.dexUd.Name = "dexUd";
            this.dexUd.Size = new System.Drawing.Size(50, 22);
            this.dexUd.TabIndex = 12;
            this.dexUd.Enter += new System.EventHandler(this.dexUd_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cons:";
            // 
            // consUd
            // 
            this.consUd.Location = new System.Drawing.Point(389, 158);
            this.consUd.Name = "consUd";
            this.consUd.Size = new System.Drawing.Size(53, 22);
            this.consUd.TabIndex = 14;
            this.consUd.Enter += new System.EventHandler(this.consUd_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Int:";
            // 
            // intUd
            // 
            this.intUd.Location = new System.Drawing.Point(53, 196);
            this.intUd.Name = "intUd";
            this.intUd.Size = new System.Drawing.Size(55, 22);
            this.intUd.TabIndex = 16;
            this.intUd.Enter += new System.EventHandler(this.intUd_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Wis:";
            // 
            // wisUd
            // 
            this.wisUd.Location = new System.Drawing.Point(219, 196);
            this.wisUd.Name = "wisUd";
            this.wisUd.Size = new System.Drawing.Size(51, 22);
            this.wisUd.TabIndex = 18;
            this.wisUd.Enter += new System.EventHandler(this.wisUd_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Char:";
            // 
            // charUd
            // 
            this.charUd.Location = new System.Drawing.Point(389, 196);
            this.charUd.Name = "charUd";
            this.charUd.Size = new System.Drawing.Size(53, 22);
            this.charUd.TabIndex = 20;
            this.charUd.Enter += new System.EventHandler(this.charUd_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Senses:";
            // 
            // sensesTb
            // 
            this.sensesTb.Location = new System.Drawing.Point(171, 235);
            this.sensesTb.Name = "sensesTb";
            this.sensesTb.Size = new System.Drawing.Size(273, 22);
            this.sensesTb.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Damage Resistances:";
            // 
            // dmgResTb
            // 
            this.dmgResTb.Location = new System.Drawing.Point(171, 291);
            this.dmgResTb.Name = "dmgResTb";
            this.dmgResTb.Size = new System.Drawing.Size(273, 22);
            this.dmgResTb.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Damage Immunities:";
            // 
            // dmgImmTb
            // 
            this.dmgImmTb.Location = new System.Drawing.Point(171, 321);
            this.dmgImmTb.Name = "dmgImmTb";
            this.dmgImmTb.Size = new System.Drawing.Size(273, 22);
            this.dmgImmTb.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Condition Immunities:";
            // 
            // condImmTb
            // 
            this.condImmTb.Location = new System.Drawing.Point(171, 354);
            this.condImmTb.Name = "condImmTb";
            this.condImmTb.Size = new System.Drawing.Size(273, 22);
            this.condImmTb.TabIndex = 28;
            // 
            // errMsg
            // 
            this.errMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(13, 390);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(156, 17);
            this.errMsg.TabIndex = 29;
            this.errMsg.Text = "Please input a name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Damage Vulnerabilities:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 31;
            // 
            // CustomMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.condImmTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dmgImmTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dmgResTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sensesTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.charUd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wisUd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intUd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consUd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dexUd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strUd);
            this.Controls.Add(this.strLbl);
            this.Controls.Add(this.acUd);
            this.Controls.Add(this.acLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.hpUd);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customMstrTitle);
            this.Name = "CustomMonster";
            this.Text = "CustomMonster";
            ((System.ComponentModel.ISupportInitialize)(this.hpUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customMstrTitle;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.NumericUpDown hpUd;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label acLbl;
        private System.Windows.Forms.NumericUpDown acUd;
        private System.Windows.Forms.Label strLbl;
        private System.Windows.Forms.NumericUpDown strUd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dexUd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown consUd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intUd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown wisUd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown charUd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sensesTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dmgResTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dmgImmTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox condImmTb;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}