namespace RocketLeagueWinLossApplication
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenuItem = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LossCountLabel = new System.Windows.Forms.Label();
            this.WinCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RatioLabel = new System.Windows.Forms.Label();
            this.DifferenceLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.LossButton = new System.Windows.Forms.Button();
            this.WinButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenuItem});
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Index = 0;
            this.FileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 0;
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.LossCountLabel);
            this.panel1.Controls.Add(this.WinCountLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RatioLabel);
            this.panel1.Controls.Add(this.DifferenceLabel);
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.LossButton);
            this.panel1.Controls.Add(this.WinButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 361);
            this.panel1.TabIndex = 0;
            // 
            // LossCountLabel
            // 
            this.LossCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LossCountLabel.AutoSize = true;
            this.LossCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossCountLabel.Location = new System.Drawing.Point(525, 28);
            this.LossCountLabel.Name = "LossCountLabel";
            this.LossCountLabel.Size = new System.Drawing.Size(59, 31);
            this.LossCountLabel.TabIndex = 10;
            this.LossCountLabel.Text = "222";
            this.LossCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WinCountLabel
            // 
            this.WinCountLabel.AutoSize = true;
            this.WinCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinCountLabel.Location = new System.Drawing.Point(13, 28);
            this.WinCountLabel.Name = "WinCountLabel";
            this.WinCountLabel.Size = new System.Drawing.Size(59, 31);
            this.WinCountLabel.TabIndex = 9;
            this.WinCountLabel.Text = "222";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ratio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Difference:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatioLabel
            // 
            this.RatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RatioLabel.AutoSize = true;
            this.RatioLabel.Location = new System.Drawing.Point(274, 288);
            this.RatioLabel.Name = "RatioLabel";
            this.RatioLabel.Size = new System.Drawing.Size(13, 13);
            this.RatioLabel.TabIndex = 6;
            this.RatioLabel.Text = "0";
            this.RatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DifferenceLabel
            // 
            this.DifferenceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DifferenceLabel.AutoSize = true;
            this.DifferenceLabel.Location = new System.Drawing.Point(274, 237);
            this.DifferenceLabel.Name = "DifferenceLabel";
            this.DifferenceLabel.Size = new System.Drawing.Size(13, 13);
            this.DifferenceLabel.TabIndex = 5;
            this.DifferenceLabel.Text = "0";
            this.DifferenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(255, 326);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LossButton
            // 
            this.LossButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LossButton.AutoSize = true;
            this.LossButton.Location = new System.Drawing.Point(506, 175);
            this.LossButton.Name = "LossButton";
            this.LossButton.Size = new System.Drawing.Size(75, 75);
            this.LossButton.TabIndex = 3;
            this.LossButton.Text = "Loss";
            this.LossButton.UseVisualStyleBackColor = true;
            this.LossButton.Click += new System.EventHandler(this.LossButton_Click);
            // 
            // WinButton
            // 
            this.WinButton.AutoSize = true;
            this.WinButton.Location = new System.Drawing.Point(3, 175);
            this.WinButton.Name = "WinButton";
            this.WinButton.Size = new System.Drawing.Size(75, 75);
            this.WinButton.TabIndex = 2;
            this.WinButton.Text = "Win";
            this.WinButton.UseVisualStyleBackColor = true;
            this.WinButton.Click += new System.EventHandler(this.WinButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Losses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem FileMenuItem;
        private System.Windows.Forms.MenuItem ExitMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WinButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LossButton;
        private System.Windows.Forms.Label LossCountLabel;
        private System.Windows.Forms.Label WinCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RatioLabel;
        private System.Windows.Forms.Label DifferenceLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

