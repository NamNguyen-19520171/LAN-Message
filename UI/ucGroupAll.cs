﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
    public partial class ucGroupAll : UserControl
    {
        private GroupUI Parent;
        private Panel pnParent;
        public ucGroupAll()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.lbId.ForeColor = Form1.theme.TextColor;
            this.lbName.ForeColor = Form1.theme.TextColor;
            this.pnLine.BackColor = Form1.theme.LineColor;
            this.picAdd.Image = Image.FromFile(Form1.theme.PictureMenu);
            this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
        }
        public ucGroupAll(Group group, GroupUI groupUI)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Parent = groupUI;
            this.lbName.Text = group.Name;
            this.lbId.Text = "#" + group.ID;
            this.lbId.ForeColor = Form1.theme.TextColor;
            this.lbName.ForeColor = Form1.theme.TextColor;
            this.pnLine.BackColor = Form1.theme.LineColor;
            this.picAdd.Image = Image.FromFile(Form1.theme.PictureMenu);
            this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
        }
        public void InitColor()
        {
            this.lbId.ForeColor = Form1.theme.TextColor;
            this.lbName.ForeColor = Form1.theme.TextColor;
            this.pnLine.BackColor = Form1.theme.LineColor;
            this.picAdd.Image = Image.FromFile(Form1.theme.PictureMenu);
            this.picChat.Image = Image.FromFile(Form1.theme.PictureMessage);
        }
        private void picChat_Click(object sender, EventArgs e)
        {
            this.Parent.ShowChatForm();
            this.Parent.AddGroupInteracted();
        }
        public void SetAvatar(string path)
        {
            gunaPic.Image = Image.FromFile(path);
        }

        private void gunaPic_MouseClick(object sender, MouseEventArgs e)
        {
            this.Parent.ShowChatForm();
            this.Parent.AddGroupInteracted();
            if (Form1.interactFocus != null)
            {
                Form1.interactFocus.ChangeColorWhenNonClick();
            }
            this.Parent.ucGroupInteract.ChangeColorWhenClick();
            Form1.interactFocus = this.Parent.ucGroupInteract;
        }
        private void picAdd_Click(object sender, EventArgs e)
        {
            this.Parent.cmns.BackColor = Form1.theme.Menu;
            this.Parent.cmns.Show(MousePosition);
        }
    }
}