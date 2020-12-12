﻿namespace UI
{
    partial class FrmFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFriend));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.btnOnline = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnOnline = new System.Windows.Forms.Panel();
            this.pnAll = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelOnline.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelAll);
            this.panel1.Controls.Add(this.panelOnline);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 53);
            this.panel1.TabIndex = 1;
            // 
            // panelAll
            // 
            this.panelAll.BackColor = System.Drawing.Color.Transparent;
            this.panelAll.Controls.Add(this.btnAll);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAll.Location = new System.Drawing.Point(238, 0);
            this.panelAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelAll.Size = new System.Drawing.Size(133, 53);
            this.panelAll.TabIndex = 2;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.DimGray;
            this.btnAll.Location = new System.Drawing.Point(20, 10);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(93, 33);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.btnAll.MouseLeave += new System.EventHandler(this.btnAll_MouseLeave);
            this.btnAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_MouseMove);
            // 
            // panelOnline
            // 
            this.panelOnline.BackColor = System.Drawing.Color.Transparent;
            this.panelOnline.Controls.Add(this.btnOnline);
            this.panelOnline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOnline.Location = new System.Drawing.Point(109, 0);
            this.panelOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelOnline.Size = new System.Drawing.Size(129, 53);
            this.panelOnline.TabIndex = 1;
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.Transparent;
            this.btnOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.DimGray;
            this.btnOnline.Location = new System.Drawing.Point(20, 10);
            this.btnOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(89, 33);
            this.btnOnline.TabIndex = 1;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            this.btnOnline.MouseLeave += new System.EventHandler(this.btnAll_MouseLeave);
            this.btnOnline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAll_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel2.Size = new System.Drawing.Size(109, 53);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Transparent;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 53);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(806, 1);
            this.panelLine.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnOnline);
            this.panel3.Controls.Add(this.pnAll);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(806, 458);
            this.panel3.TabIndex = 6;
            // 
            // pnOnline
            // 
            this.pnOnline.Location = new System.Drawing.Point(353, 219);
            this.pnOnline.Name = "pnOnline";
            this.pnOnline.Size = new System.Drawing.Size(301, 165);
            this.pnOnline.TabIndex = 7;
            // 
            // pnAll
            // 
            this.pnAll.Location = new System.Drawing.Point(145, 106);
            this.pnAll.Name = "pnAll";
            this.pnAll.Size = new System.Drawing.Size(301, 165);
            this.pnAll.TabIndex = 6;
            // 
            // FrmFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFriend";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "FrmFriend";
            this.panel1.ResumeLayout(false);
            this.panelAll.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnOnline;
        private System.Windows.Forms.Panel pnAll;
    }
}