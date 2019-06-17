﻿namespace StockManagementSystem
{
    partial class HomeForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryToolStripMenuItem,
            this.CompanyToolStripMenuItem,
            this.ItemToolStripMenuItem,
            this.StockToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(948, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(163, 25);
            this.toolStripStatusLabel.Text = "Team RAM © 2019";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategorySetupToolStripMenuItem});
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.CategoryToolStripMenuItem.Text = "Category";
            // 
            // CategorySetupToolStripMenuItem
            // 
            this.CategorySetupToolStripMenuItem.Name = "CategorySetupToolStripMenuItem";
            this.CategorySetupToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.CategorySetupToolStripMenuItem.Text = "Category Setup";
            this.CategorySetupToolStripMenuItem.Click += new System.EventHandler(this.CategorySetupToolStripMenuItem_Click);
            // 
            // CompanyToolStripMenuItem
            // 
            this.CompanyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompanySetupToolStripMenuItem});
            this.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem";
            this.CompanyToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.CompanyToolStripMenuItem.Text = "Company";
            // 
            // CompanySetupToolStripMenuItem
            // 
            this.CompanySetupToolStripMenuItem.Name = "CompanySetupToolStripMenuItem";
            this.CompanySetupToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.CompanySetupToolStripMenuItem.Text = "Company Setup";
            this.CompanySetupToolStripMenuItem.Click += new System.EventHandler(this.CompanySetupToolStripMenuItem_Click);
            // 
            // ItemToolStripMenuItem
            // 
            this.ItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemSetupToolStripMenuItem,
            this.ViewItemsToolStripMenuItem});
            this.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem";
            this.ItemToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.ItemToolStripMenuItem.Text = "Item";
            // 
            // ItemSetupToolStripMenuItem
            // 
            this.ItemSetupToolStripMenuItem.Name = "ItemSetupToolStripMenuItem";
            this.ItemSetupToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ItemSetupToolStripMenuItem.Text = "Item Setup";
            this.ItemSetupToolStripMenuItem.Click += new System.EventHandler(this.ItemSetupToolStripMenuItem_Click);
            // 
            // StockToolStripMenuItem
            // 
            this.StockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StockInToolStripMenuItem,
            this.StockOutToolStripMenuItem,
            this.ViewReportToolStripMenuItem});
            this.StockToolStripMenuItem.Name = "StockToolStripMenuItem";
            this.StockToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.StockToolStripMenuItem.Text = "Stock";
            // 
            // StockInToolStripMenuItem
            // 
            this.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem";
            this.StockInToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.StockInToolStripMenuItem.Text = "Stock In";
            this.StockInToolStripMenuItem.Click += new System.EventHandler(this.StockInToolStripMenuItem_Click);
            // 
            // StockOutToolStripMenuItem
            // 
            this.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem";
            this.StockOutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.StockOutToolStripMenuItem.Text = "Stock Out";
            this.StockOutToolStripMenuItem.Click += new System.EventHandler(this.StockOutToolStripMenuItem_Click);
            // 
            // ViewReportToolStripMenuItem
            // 
            this.ViewReportToolStripMenuItem.Name = "ViewReportToolStripMenuItem";
            this.ViewReportToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ViewReportToolStripMenuItem.Text = "View Report";
            this.ViewReportToolStripMenuItem.Click += new System.EventHandler(this.ViewReportToolStripMenuItem_Click);
            // 
            // ViewItemsToolStripMenuItem
            // 
            this.ViewItemsToolStripMenuItem.Name = "ViewItemsToolStripMenuItem";
            this.ViewItemsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.ViewItemsToolStripMenuItem.Text = "View Items";
            this.ViewItemsToolStripMenuItem.Click += new System.EventHandler(this.ViewItemsToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewReportToolStripMenuItem;
    }
}


