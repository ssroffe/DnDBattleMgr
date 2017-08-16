namespace BattleMgr
{
    partial class Form1
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
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.initTab = new System.Windows.Forms.TabPage();
            this.addInitBtn = new System.Windows.Forms.Button();
            this.removeCb = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dexTitleLabel = new System.Windows.Forms.Label();
            this.initTitleLabel = new System.Windows.Forms.Label();
            this.nameTitleLabel = new System.Windows.Forms.Label();
            this.initPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.monsterTab = new System.Windows.Forms.TabPage();
            this.clearMstr = new System.Windows.Forms.Button();
            this.rmMstr = new System.Windows.Forms.CheckBox();
            this.addMstrBtn = new System.Windows.Forms.Button();
            this.mstrPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCtl.SuspendLayout();
            this.initTab.SuspendLayout();
            this.monsterTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtl
            // 
            this.tabCtl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtl.Controls.Add(this.initTab);
            this.tabCtl.Controls.Add(this.monsterTab);
            this.tabCtl.Location = new System.Drawing.Point(12, 12);
            this.tabCtl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(604, 574);
            this.tabCtl.TabIndex = 0;
            // 
            // initTab
            // 
            this.initTab.Controls.Add(this.addInitBtn);
            this.initTab.Controls.Add(this.removeCb);
            this.initTab.Controls.Add(this.clearBtn);
            this.initTab.Controls.Add(this.dexTitleLabel);
            this.initTab.Controls.Add(this.initTitleLabel);
            this.initTab.Controls.Add(this.nameTitleLabel);
            this.initTab.Controls.Add(this.initPanel);
            this.initTab.Location = new System.Drawing.Point(4, 25);
            this.initTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initTab.Name = "initTab";
            this.initTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initTab.Size = new System.Drawing.Size(596, 545);
            this.initTab.TabIndex = 0;
            this.initTab.Text = "Initiative";
            this.initTab.UseVisualStyleBackColor = true;
            // 
            // addInitBtn
            // 
            this.addInitBtn.Location = new System.Drawing.Point(5, 5);
            this.addInitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addInitBtn.Name = "addInitBtn";
            this.addInitBtn.Size = new System.Drawing.Size(100, 28);
            this.addInitBtn.TabIndex = 2;
            this.addInitBtn.Text = "Add";
            this.addInitBtn.UseVisualStyleBackColor = true;
            this.addInitBtn.Click += new System.EventHandler(this.addInitBtn_Click_1);
            // 
            // removeCb
            // 
            this.removeCb.Appearance = System.Windows.Forms.Appearance.Button;
            this.removeCb.Location = new System.Drawing.Point(111, 5);
            this.removeCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeCb.Name = "removeCb";
            this.removeCb.Size = new System.Drawing.Size(100, 28);
            this.removeCb.TabIndex = 8;
            this.removeCb.Text = "Remove";
            this.removeCb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeCb.UseVisualStyleBackColor = true;
            this.removeCb.CheckedChanged += new System.EventHandler(this.removeCb_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(216, 5);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dexTitleLabel
            // 
            this.dexTitleLabel.AutoSize = true;
            this.dexTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexTitleLabel.Location = new System.Drawing.Point(263, 38);
            this.dexTitleLabel.Name = "dexTitleLabel";
            this.dexTitleLabel.Size = new System.Drawing.Size(70, 17);
            this.dexTitleLabel.TabIndex = 6;
            this.dexTitleLabel.Text = "Dex Mod";
            // 
            // initTitleLabel
            // 
            this.initTitleLabel.AutoSize = true;
            this.initTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initTitleLabel.Location = new System.Drawing.Point(125, 38);
            this.initTitleLabel.Name = "initTitleLabel";
            this.initTitleLabel.Size = new System.Drawing.Size(63, 17);
            this.initTitleLabel.TabIndex = 5;
            this.initTitleLabel.Text = "Init Roll";
            // 
            // nameTitleLabel
            // 
            this.nameTitleLabel.AutoSize = true;
            this.nameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTitleLabel.Location = new System.Drawing.Point(5, 38);
            this.nameTitleLabel.Name = "nameTitleLabel";
            this.nameTitleLabel.Size = new System.Drawing.Size(49, 17);
            this.nameTitleLabel.TabIndex = 4;
            this.nameTitleLabel.Text = "Name";
            // 
            // initPanel
            // 
            this.initPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initPanel.AutoScroll = true;
            this.initPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.initPanel.Location = new System.Drawing.Point(3, 58);
            this.initPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initPanel.Name = "initPanel";
            this.initPanel.Size = new System.Drawing.Size(587, 484);
            this.initPanel.TabIndex = 3;
            // 
            // monsterTab
            // 
            this.monsterTab.Controls.Add(this.label3);
            this.monsterTab.Controls.Add(this.label2);
            this.monsterTab.Controls.Add(this.label1);
            this.monsterTab.Controls.Add(this.mstrPanel);
            this.monsterTab.Controls.Add(this.clearMstr);
            this.monsterTab.Controls.Add(this.rmMstr);
            this.monsterTab.Controls.Add(this.addMstrBtn);
            this.monsterTab.Location = new System.Drawing.Point(4, 25);
            this.monsterTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterTab.Name = "monsterTab";
            this.monsterTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monsterTab.Size = new System.Drawing.Size(596, 545);
            this.monsterTab.TabIndex = 1;
            this.monsterTab.Text = "Monsters";
            this.monsterTab.UseVisualStyleBackColor = true;
            // 
            // clearMstr
            // 
            this.clearMstr.Location = new System.Drawing.Point(220, 6);
            this.clearMstr.Margin = new System.Windows.Forms.Padding(4);
            this.clearMstr.Name = "clearMstr";
            this.clearMstr.Size = new System.Drawing.Size(100, 28);
            this.clearMstr.TabIndex = 2;
            this.clearMstr.Text = "Clear";
            this.clearMstr.UseVisualStyleBackColor = true;
            this.clearMstr.Click += new System.EventHandler(this.clearMstr_Click);
            // 
            // rmMstr
            // 
            this.rmMstr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rmMstr.Location = new System.Drawing.Point(112, 6);
            this.rmMstr.Margin = new System.Windows.Forms.Padding(4);
            this.rmMstr.Name = "rmMstr";
            this.rmMstr.Size = new System.Drawing.Size(100, 28);
            this.rmMstr.TabIndex = 1;
            this.rmMstr.Text = "Remove";
            this.rmMstr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rmMstr.UseVisualStyleBackColor = true;
            // 
            // addMstrBtn
            // 
            this.addMstrBtn.Location = new System.Drawing.Point(7, 6);
            this.addMstrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMstrBtn.Name = "addMstrBtn";
            this.addMstrBtn.Size = new System.Drawing.Size(100, 28);
            this.addMstrBtn.TabIndex = 0;
            this.addMstrBtn.Text = "Add";
            this.addMstrBtn.UseVisualStyleBackColor = true;
            this.addMstrBtn.Click += new System.EventHandler(this.addMstrBtn_Click);
            // 
            // mstrPanel
            // 
            this.mstrPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mstrPanel.Location = new System.Drawing.Point(7, 58);
            this.mstrPanel.Name = "mstrPanel";
            this.mstrPanel.Size = new System.Drawing.Size(586, 482);
            this.mstrPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 598);
            this.Controls.Add(this.tabCtl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BattleMgr";
            this.tabCtl.ResumeLayout(false);
            this.initTab.ResumeLayout(false);
            this.initTab.PerformLayout();
            this.monsterTab.ResumeLayout(false);
            this.monsterTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage initTab;
        private System.Windows.Forms.TabPage monsterTab;
        private System.Windows.Forms.Button addInitBtn;
        private System.Windows.Forms.FlowLayoutPanel initPanel;
        private System.Windows.Forms.Label dexTitleLabel;
        private System.Windows.Forms.Label initTitleLabel;
        private System.Windows.Forms.Label nameTitleLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.CheckBox removeCb;
        private System.Windows.Forms.Button clearMstr;
        private System.Windows.Forms.CheckBox rmMstr;
        private System.Windows.Forms.Button addMstrBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel mstrPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

