﻿namespace MiniProject
{
    partial class AdministrationForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.목록관리LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원성향분석SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.목록관리LToolStripMenuItem,
            this.회원관리MToolStripMenuItem,
            this.회원성향분석SToolStripMenuItem,
            this.통계SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(21, 75);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1758, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 목록관리LToolStripMenuItem
            // 
            this.목록관리LToolStripMenuItem.Name = "목록관리LToolStripMenuItem";
            this.목록관리LToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.목록관리LToolStripMenuItem.Text = "목록관리(&L)";
            this.목록관리LToolStripMenuItem.Click += new System.EventHandler(this.목록관리LToolStripMenuItem_Click);
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.회원관리MToolStripMenuItem.Text = "회원관리(&M)";
            this.회원관리MToolStripMenuItem.Click += new System.EventHandler(this.회원관리MToolStripMenuItem_Click);
            // 
            // 회원성향분석SToolStripMenuItem
            // 
            this.회원성향분석SToolStripMenuItem.Name = "회원성향분석SToolStripMenuItem";
            this.회원성향분석SToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.회원성향분석SToolStripMenuItem.Text = "회원성향차이분석(&A)";
            this.회원성향분석SToolStripMenuItem.Click += new System.EventHandler(this.회원성향분석SToolStripMenuItem_Click);
            // 
            // 통계SToolStripMenuItem
            // 
            this.통계SToolStripMenuItem.Name = "통계SToolStripMenuItem";
            this.통계SToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.통계SToolStripMenuItem.Text = "통계(&S)";
            this.통계SToolStripMenuItem.Click += new System.EventHandler(this.통계SToolStripMenuItem_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1102);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministrationForm";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "관리자";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrationForm_FormClosing);
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 목록관리LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원성향분석SToolStripMenuItem;
    }
}