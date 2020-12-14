﻿using Network;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManager;

namespace UI
{
	public class GroupUI
	{
		public Group group;
		public GroupForm groupForm; // Khung chat của Group
		Form1 mainForm;
		public Panel panelINTERACTED;
		public Panel panelRIGHT;

		public ucGroupToAdd ucGroupToAdd;
		public ucGroupAll ucGroupAll;
		public ucInterac ucGroupInteract;
		public ucGroupPending ucGroupPending;
		public ContextMenuStrip cmns { get; set; }
		public GroupUI(Group group, Form1 mainForm)
		{
			this.group = group;
			this.panelINTERACTED = mainForm.PnInteract;
			this.panelRIGHT = mainForm.PnRight;
			this.mainForm = mainForm;
			ucGroupAll = new ucGroupAll(group, this);
			InitGroupForm();
			InitCmns();
			ucGroupInteract = new ucInterac(this.group.Name);
			ucGroupInteract.SetGroup(this);
			ucGroupInteract.InitColor();
			ucGroupInteract.SetAvatar(group.AvatarPath);
			ucGroupToAdd = new ucGroupToAdd(group);
			//ucGroupToAdd = new ucGroupToAdd(group);
		}

        public void InitCmns()
        {
			cmns = new ContextMenuStrip();
			cmns.Width = 100;
			cmns.RenderMode = ToolStripRenderMode.System;
			cmns.BackColor = Form1.theme.Menu;
			cmns.ShowImageMargin = false;
			ToolStripButton tsAddGroup = new ToolStripButton("ADD Member");
			tsAddGroup.ForeColor = Form1.theme.TxtForeColor;
			ToolStripButton tsOutGroup = new ToolStripButton("Out Group");
			tsOutGroup.ForeColor = Form1.theme.TxtForeColor;
			ToolStripButton tsRemoveGroup = new ToolStripButton("Remove Group");
			tsRemoveGroup.ForeColor = Color.Red;
			tsAddGroup.Click += TsAddGroup_Click;
			tsOutGroup.Click += TsOutGroup_Click;
			tsRemoveGroup.Click += TsRemoveGroup_Click;
			if (group.admin != Form1.me) tsRemoveGroup.Visible = false;
			cmns.Items.Add(tsAddGroup);
			cmns.Items.Add(tsOutGroup);
			cmns.Items.Add(tsRemoveGroup);
		}

        public void ResetTheme()
        {
			this.groupForm.BackColor = Form1.theme.BackColor;
			this.groupForm.InitColor();
			foreach (var item in groupForm.Controls)
			{
				if (item.GetType() == typeof(ucUserINChatBox))
				{
					(item as ucUserINChatBox).InitColor();
				}
				else if (item.GetType() == typeof(ucMessShow))
				{
					(item as ucMessShow).ChangeTheme();
				}
				else if (item.GetType() == typeof(ucFileShow))
				{
					(item as ucFileShow).InitColor();
				}
			}
			InitCmns();
			ucGroupAll.InitColor();
			ucGroupInteract.InitColor();
			if (ucGroupPending != null) ucGroupPending.InitColor();
			if (ucGroupToAdd != null) ucGroupToAdd.InitColor();
		}
		public void InitGroupForm()
		{
			groupForm = new GroupForm(group,this);
			groupForm.TopLevel = false;
			groupForm.BackColor = Form1.theme.BackColor;
			groupForm.Dock = DockStyle.Fill;
			groupForm.InitColor();
			this.panelRIGHT.Controls.Add(groupForm);
		}
        private void TsRemoveGroup_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Are you sure remove this Group", "Remove Group", MessageBoxButtons.YesNo);
			// gửi lên server xóa group
			//mainForm.GroupUIs.Remove(this);
        }
        private void TsOutGroup_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Are you sure Out this Group", "Remove Group", MessageBoxButtons.YesNo);
			byte[] buff = Encoding.UTF8.GetBytes("OUTGR%" + group.ID + "%"+(group.admin == Form1.me ? "true" : "false"));
			SmallPackage smallPackage = new SmallPackage(0, 1024, "M", buff, "0");
			Form1.server.GetStream().WriteAsync(smallPackage.Packing(), 0, smallPackage.Packing().Length);

			mainForm.GroupUIs.Remove(this);
			this.Dispose();
		}
		public void Dispose()
        {
			groupForm.Dispose();
			this.ucGroupAll.Dispose();
			this.ucGroupInteract.Dispose();
			//this.ucGroupPending.Dispose();
			this.ucGroupToAdd.Dispose();
        }
		private void TsAddGroup_Click(object sender, EventArgs e)
        {
			mainForm.frmADD.InitControls();
			mainForm.frmADD.InitAddGroupForm(group);
			mainForm.frmADD.Show();
			mainForm.frmADD.BringToFront();
        }

        public async void AddMessage(User user,string IDMess, string message)
		{
			groupForm.AddItemToListChat(user, IDMess,message);
			this.ucGroupInteract.AddMessage(user.Name + ": "+ message);
		}
		public void AddMessageIntoInteract(string name,string mess)
		{
			this.ucGroupInteract.AddMessage(name + ": "+mess);
		}
		public string GetID() => group.ID;
		public void SetAvatar(string path)
		{
			this.group.AvatarPath = path;
			this.groupForm.SetAvatar(path);
			this.ucGroupInteract.SetAvatar(path);
			this.ucGroupAll.SetAvatar(path);
		}
		public void AddPanelFile(User user,string fileid, string filename)
		{

			this.groupForm.AddFileToListChat(user,fileid , filename);
		}
		public void BringToTop()
		{
			if (this.panelINTERACTED.Contains(ucGroupInteract))
			{
				this.panelINTERACTED.Controls.Remove(ucGroupInteract);
			}
			this.AddGroupInteracted();
		}
		public void AddGroupIntoPanelGroup(Panel panelGroupAll)
		{
			panelGroupAll.Controls.Add(ucGroupAll);
		}
		public void AddGroupIntoPanelPending(Panel pnPending)
		{
			ucGroupPending = new ucGroupPending(this, pnPending);
			pnPending.Controls.Add(ucGroupPending);
		}
		public void ShowChatForm()
		{
			groupForm.Show();
			groupForm.BringToFront();
			Form1.groupFormFocus = this.groupForm;
		}
		public void AddGroupInteracted()
		{
			if (this.panelINTERACTED.Contains(ucGroupInteract))
			{
				ucGroupInteract.Visible = true;
				ucGroupInteract.Dock = DockStyle.Top;
			}
			else
			{
				ucGroupInteract.Visible = true;
				ucGroupInteract.Dock = DockStyle.Top;
				this.panelINTERACTED.Controls.Add(ucGroupInteract);
			}
		}
		public void DeleteMessage(string IDMess)
		{
			this.groupForm.DeleteMessage(IDMess);
		}
		public void EditMessage(string idmess, string newMess)
		{
			this.groupForm.EditMessage(idmess, newMess);
		}
		public bool MemberInGroup(User user)
        {
			return group.MemberInGroup(user);
        }
	}
}