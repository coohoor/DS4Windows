﻿namespace DS4Windows
{
    partial class DS4Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DS4Form));
            this.lvDebug = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
            this.lBTest = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lbLastMessage = new System.Windows.Forms.Label();
            this.llbHelp = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMTaskbar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProfileForController1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileForController2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileForController3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileForController4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openProfiles = new System.Windows.Forms.OpenFileDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabControllers = new System.Windows.Forms.TabPage();
            this.tLPControllers = new System.Windows.Forms.TableLayoutPanel();
            this.pBStatus1 = new System.Windows.Forms.PictureBox();
            this.lbPad1 = new System.Windows.Forms.Label();
            this.lbPad2 = new System.Windows.Forms.Label();
            this.bnEditC3 = new System.Windows.Forms.Button();
            this.bnEditC4 = new System.Windows.Forms.Button();
            this.lbPad3 = new System.Windows.Forms.Label();
            this.lbPad4 = new System.Windows.Forms.Label();
            this.cBController1 = new System.Windows.Forms.ComboBox();
            this.bnEditC2 = new System.Windows.Forms.Button();
            this.cBController2 = new System.Windows.Forms.ComboBox();
            this.cBController3 = new System.Windows.Forms.ComboBox();
            this.bnEditC1 = new System.Windows.Forms.Button();
            this.cBController4 = new System.Windows.Forms.ComboBox();
            this.lBSelectedProfile = new System.Windows.Forms.Label();
            this.lBID = new System.Windows.Forms.Label();
            this.lBStatus = new System.Windows.Forms.Label();
            this.lBBattery = new System.Windows.Forms.Label();
            this.lBBatt1 = new System.Windows.Forms.Label();
            this.lBBatt2 = new System.Windows.Forms.Label();
            this.lBBatt3 = new System.Windows.Forms.Label();
            this.lBBatt4 = new System.Windows.Forms.Label();
            this.pBStatus2 = new System.Windows.Forms.PictureBox();
            this.pBStatus3 = new System.Windows.Forms.PictureBox();
            this.pBStatus4 = new System.Windows.Forms.PictureBox();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.lBProfiles = new System.Windows.Forms.ListBox();
            this.cMProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToController1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToController2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToController3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToController4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSOptions = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tSTBProfile = new System.Windows.Forms.ToolStripTextBox();
            this.tSBSaveProfile = new System.Windows.Forms.ToolStripButton();
            this.tSBCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBKeepSize = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBNewProfle = new System.Windows.Forms.ToolStripButton();
            this.tsBEditProfile = new System.Windows.Forms.ToolStripButton();
            this.tsBDeleteProfile = new System.Windows.Forms.ToolStripButton();
            this.tSBDupProfile = new System.Windows.Forms.ToolStripButton();
            this.tSBImportProfile = new System.Windows.Forms.ToolStripButton();
            this.tSBExportProfile = new System.Windows.Forms.ToolStripButton();
            this.tabAutoProfiles = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hideDS4CheckBox = new System.Windows.Forms.CheckBox();
            this.cBSwipeProfiles = new System.Windows.Forms.CheckBox();
            this.StartWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.startMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.cBUpdate = new System.Windows.Forms.CheckBox();
            this.pNUpdate = new System.Windows.Forms.Panel();
            this.cBUpdateTime = new System.Windows.Forms.ComboBox();
            this.lBCheckEvery = new System.Windows.Forms.Label();
            this.nUDUpdateTime = new System.Windows.Forms.NumericUpDown();
            this.cBNotifications = new System.Windows.Forms.CheckBox();
            this.cBDisconnectBT = new System.Windows.Forms.CheckBox();
            this.cBQuickCharge = new System.Windows.Forms.CheckBox();
            this.linkProfiles = new System.Windows.Forms.LinkLabel();
            this.lLBUpdate = new System.Windows.Forms.LinkLabel();
            this.linkSetup = new System.Windows.Forms.LinkLabel();
            this.linkUninstall = new System.Windows.Forms.LinkLabel();
            this.lnkControllers = new System.Windows.Forms.LinkLabel();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.saveProfiles = new System.Windows.Forms.SaveFileDialog();
            this.pnlButton.SuspendLayout();
            this.cMTaskbar.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabControllers.SuspendLayout();
            this.tLPControllers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus4)).BeginInit();
            this.tabProfiles.SuspendLayout();
            this.cMProfile.SuspendLayout();
            this.tSOptions.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pNUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdateTime)).BeginInit();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDebug
            // 
            this.lvDebug.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chData});
            resources.ApplyResources(this.lvDebug, "lvDebug");
            this.lvDebug.FullRowSelect = true;
            this.lvDebug.Name = "lvDebug";
            this.lvDebug.UseCompatibleStateImageBehavior = false;
            this.lvDebug.View = System.Windows.Forms.View.Details;
            this.lvDebug.ItemActivate += new System.EventHandler(this.lvDebug_ItemActivate);
            // 
            // chTime
            // 
            resources.ApplyResources(this.chTime, "chTime");
            // 
            // chData
            // 
            resources.ApplyResources(this.chData, "chData");
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.ControllerStatusChange);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButton.Controls.Add(this.lBTest);
            this.pnlButton.Controls.Add(this.btnStartStop);
            this.pnlButton.Controls.Add(this.lbLastMessage);
            this.pnlButton.Controls.Add(this.llbHelp);
            resources.ApplyResources(this.pnlButton, "pnlButton");
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.MouseLeave += new System.EventHandler(this.pnlButton_MouseLeave);
            // 
            // lBTest
            // 
            resources.ApplyResources(this.lBTest, "lBTest");
            this.lBTest.Name = "lBTest";
            // 
            // btnStartStop
            // 
            resources.ApplyResources(this.btnStartStop, "btnStartStop");
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lbLastMessage
            // 
            resources.ApplyResources(this.lbLastMessage, "lbLastMessage");
            this.lbLastMessage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLastMessage.Name = "lbLastMessage";
            this.lbLastMessage.MouseHover += new System.EventHandler(this.lbLastMessage_MouseHover);
            // 
            // llbHelp
            // 
            resources.ApplyResources(this.llbHelp, "llbHelp");
            this.llbHelp.Name = "llbHelp";
            this.llbHelp.TabStop = true;
            this.llbHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHelp_LinkClicked);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.ContextMenuStrip = this.cMTaskbar;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // cMTaskbar
            // 
            this.cMTaskbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cMTaskbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileForController1ToolStripMenuItem,
            this.editProfileForController2ToolStripMenuItem,
            this.editProfileForController3ToolStripMenuItem,
            this.editProfileForController4ToolStripMenuItem,
            this.toolStripSeparator1,
            this.startToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cMTaskbar.Name = "cMTaskbar";
            resources.ApplyResources(this.cMTaskbar, "cMTaskbar");
            this.cMTaskbar.Tag = "25";
            // 
            // editProfileForController1ToolStripMenuItem
            // 
            this.editProfileForController1ToolStripMenuItem.Name = "editProfileForController1ToolStripMenuItem";
            resources.ApplyResources(this.editProfileForController1ToolStripMenuItem, "editProfileForController1ToolStripMenuItem");
            this.editProfileForController1ToolStripMenuItem.Tag = "0";
            this.editProfileForController1ToolStripMenuItem.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // editProfileForController2ToolStripMenuItem
            // 
            this.editProfileForController2ToolStripMenuItem.Name = "editProfileForController2ToolStripMenuItem";
            resources.ApplyResources(this.editProfileForController2ToolStripMenuItem, "editProfileForController2ToolStripMenuItem");
            this.editProfileForController2ToolStripMenuItem.Tag = "1";
            this.editProfileForController2ToolStripMenuItem.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // editProfileForController3ToolStripMenuItem
            // 
            this.editProfileForController3ToolStripMenuItem.Name = "editProfileForController3ToolStripMenuItem";
            resources.ApplyResources(this.editProfileForController3ToolStripMenuItem, "editProfileForController3ToolStripMenuItem");
            this.editProfileForController3ToolStripMenuItem.Tag = "2";
            this.editProfileForController3ToolStripMenuItem.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // editProfileForController4ToolStripMenuItem
            // 
            this.editProfileForController4ToolStripMenuItem.Name = "editProfileForController4ToolStripMenuItem";
            resources.ApplyResources(this.editProfileForController4ToolStripMenuItem, "editProfileForController4ToolStripMenuItem");
            this.editProfileForController4ToolStripMenuItem.Tag = "4";
            this.editProfileForController4ToolStripMenuItem.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // openProfiles
            // 
            resources.ApplyResources(this.openProfiles, "openProfiles");
            this.openProfiles.Multiselect = true;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabControllers);
            this.tabMain.Controls.Add(this.tabProfiles);
            this.tabMain.Controls.Add(this.tabAutoProfiles);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabLog);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabControllers
            // 
            this.tabControllers.Controls.Add(this.tLPControllers);
            resources.ApplyResources(this.tabControllers, "tabControllers");
            this.tabControllers.Name = "tabControllers";
            this.tabControllers.UseVisualStyleBackColor = true;
            // 
            // tLPControllers
            // 
            resources.ApplyResources(this.tLPControllers, "tLPControllers");
            this.tLPControllers.Controls.Add(this.pBStatus1, 1, 1);
            this.tLPControllers.Controls.Add(this.lbPad1, 0, 1);
            this.tLPControllers.Controls.Add(this.lbPad2, 0, 2);
            this.tLPControllers.Controls.Add(this.bnEditC3, 4, 3);
            this.tLPControllers.Controls.Add(this.bnEditC4, 4, 4);
            this.tLPControllers.Controls.Add(this.lbPad3, 0, 3);
            this.tLPControllers.Controls.Add(this.lbPad4, 0, 4);
            this.tLPControllers.Controls.Add(this.cBController1, 3, 1);
            this.tLPControllers.Controls.Add(this.bnEditC2, 4, 2);
            this.tLPControllers.Controls.Add(this.cBController2, 3, 2);
            this.tLPControllers.Controls.Add(this.cBController3, 3, 3);
            this.tLPControllers.Controls.Add(this.bnEditC1, 4, 1);
            this.tLPControllers.Controls.Add(this.cBController4, 3, 4);
            this.tLPControllers.Controls.Add(this.lBSelectedProfile, 3, 0);
            this.tLPControllers.Controls.Add(this.lBID, 0, 0);
            this.tLPControllers.Controls.Add(this.lBStatus, 1, 0);
            this.tLPControllers.Controls.Add(this.lBBattery, 2, 0);
            this.tLPControllers.Controls.Add(this.lBBatt1, 2, 1);
            this.tLPControllers.Controls.Add(this.lBBatt2, 2, 2);
            this.tLPControllers.Controls.Add(this.lBBatt3, 2, 3);
            this.tLPControllers.Controls.Add(this.lBBatt4, 2, 4);
            this.tLPControllers.Controls.Add(this.pBStatus2, 1, 2);
            this.tLPControllers.Controls.Add(this.pBStatus3, 1, 3);
            this.tLPControllers.Controls.Add(this.pBStatus4, 1, 4);
            this.tLPControllers.Name = "tLPControllers";
            // 
            // pBStatus1
            // 
            resources.ApplyResources(this.pBStatus1, "pBStatus1");
            this.pBStatus1.InitialImage = global::DS4Windows.Properties.Resources.BT;
            this.pBStatus1.Name = "pBStatus1";
            this.pBStatus1.TabStop = false;
            this.pBStatus1.Tag = "0";
            this.pBStatus1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBStatus_MouseClick);
            // 
            // lbPad1
            // 
            resources.ApplyResources(this.lbPad1, "lbPad1");
            this.lbPad1.Name = "lbPad1";
            this.lbPad1.TextChanged += new System.EventHandler(this.lbPad1_TextChanged);
            // 
            // lbPad2
            // 
            resources.ApplyResources(this.lbPad2, "lbPad2");
            this.lbPad2.Name = "lbPad2";
            this.lbPad2.TextChanged += new System.EventHandler(this.lbPad1_TextChanged);
            // 
            // bnEditC3
            // 
            resources.ApplyResources(this.bnEditC3, "bnEditC3");
            this.bnEditC3.Name = "bnEditC3";
            this.bnEditC3.Tag = "2";
            this.bnEditC3.UseVisualStyleBackColor = true;
            this.bnEditC3.Click += new System.EventHandler(this.editButtons_Click);
            // 
            // bnEditC4
            // 
            resources.ApplyResources(this.bnEditC4, "bnEditC4");
            this.bnEditC4.Name = "bnEditC4";
            this.bnEditC4.Tag = "3";
            this.bnEditC4.UseVisualStyleBackColor = true;
            this.bnEditC4.Click += new System.EventHandler(this.editButtons_Click);
            // 
            // lbPad3
            // 
            resources.ApplyResources(this.lbPad3, "lbPad3");
            this.lbPad3.Name = "lbPad3";
            this.lbPad3.TextChanged += new System.EventHandler(this.lbPad1_TextChanged);
            // 
            // lbPad4
            // 
            resources.ApplyResources(this.lbPad4, "lbPad4");
            this.lbPad4.Name = "lbPad4";
            this.lbPad4.TextChanged += new System.EventHandler(this.lbPad1_TextChanged);
            // 
            // cBController1
            // 
            resources.ApplyResources(this.cBController1, "cBController1");
            this.cBController1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBController1.FormattingEnabled = true;
            this.cBController1.Name = "cBController1";
            this.cBController1.Tag = "0";
            this.cBController1.SelectedValueChanged += new System.EventHandler(this.Profile_Changed);
            // 
            // bnEditC2
            // 
            resources.ApplyResources(this.bnEditC2, "bnEditC2");
            this.bnEditC2.Name = "bnEditC2";
            this.bnEditC2.Tag = "1";
            this.bnEditC2.UseVisualStyleBackColor = true;
            this.bnEditC2.Click += new System.EventHandler(this.editButtons_Click);
            // 
            // cBController2
            // 
            resources.ApplyResources(this.cBController2, "cBController2");
            this.cBController2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBController2.FormattingEnabled = true;
            this.cBController2.Name = "cBController2";
            this.cBController2.Tag = "1";
            this.cBController2.SelectedValueChanged += new System.EventHandler(this.Profile_Changed);
            // 
            // cBController3
            // 
            resources.ApplyResources(this.cBController3, "cBController3");
            this.cBController3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBController3.FormattingEnabled = true;
            this.cBController3.Name = "cBController3";
            this.cBController3.Tag = "2";
            this.cBController3.SelectedValueChanged += new System.EventHandler(this.Profile_Changed);
            // 
            // bnEditC1
            // 
            resources.ApplyResources(this.bnEditC1, "bnEditC1");
            this.bnEditC1.Name = "bnEditC1";
            this.bnEditC1.Tag = "0";
            this.bnEditC1.UseVisualStyleBackColor = true;
            this.bnEditC1.Click += new System.EventHandler(this.editButtons_Click);
            // 
            // cBController4
            // 
            resources.ApplyResources(this.cBController4, "cBController4");
            this.cBController4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBController4.FormattingEnabled = true;
            this.cBController4.Name = "cBController4";
            this.cBController4.Tag = "3";
            this.cBController4.SelectedValueChanged += new System.EventHandler(this.Profile_Changed);
            // 
            // lBSelectedProfile
            // 
            resources.ApplyResources(this.lBSelectedProfile, "lBSelectedProfile");
            this.lBSelectedProfile.Name = "lBSelectedProfile";
            // 
            // lBID
            // 
            resources.ApplyResources(this.lBID, "lBID");
            this.lBID.Name = "lBID";
            // 
            // lBStatus
            // 
            resources.ApplyResources(this.lBStatus, "lBStatus");
            this.lBStatus.Name = "lBStatus";
            // 
            // lBBattery
            // 
            resources.ApplyResources(this.lBBattery, "lBBattery");
            this.lBBattery.Name = "lBBattery";
            // 
            // lBBatt1
            // 
            resources.ApplyResources(this.lBBatt1, "lBBatt1");
            this.lBBatt1.Name = "lBBatt1";
            // 
            // lBBatt2
            // 
            resources.ApplyResources(this.lBBatt2, "lBBatt2");
            this.lBBatt2.Name = "lBBatt2";
            // 
            // lBBatt3
            // 
            resources.ApplyResources(this.lBBatt3, "lBBatt3");
            this.lBBatt3.Name = "lBBatt3";
            // 
            // lBBatt4
            // 
            resources.ApplyResources(this.lBBatt4, "lBBatt4");
            this.lBBatt4.Name = "lBBatt4";
            // 
            // pBStatus2
            // 
            resources.ApplyResources(this.pBStatus2, "pBStatus2");
            this.pBStatus2.InitialImage = global::DS4Windows.Properties.Resources.BT;
            this.pBStatus2.Name = "pBStatus2";
            this.pBStatus2.TabStop = false;
            this.pBStatus2.Tag = "1";
            this.pBStatus2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBStatus_MouseClick);
            // 
            // pBStatus3
            // 
            resources.ApplyResources(this.pBStatus3, "pBStatus3");
            this.pBStatus3.InitialImage = global::DS4Windows.Properties.Resources.BT;
            this.pBStatus3.Name = "pBStatus3";
            this.pBStatus3.TabStop = false;
            this.pBStatus3.Tag = "2";
            this.pBStatus3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBStatus_MouseClick);
            // 
            // pBStatus4
            // 
            resources.ApplyResources(this.pBStatus4, "pBStatus4");
            this.pBStatus4.InitialImage = global::DS4Windows.Properties.Resources.BT;
            this.pBStatus4.Name = "pBStatus4";
            this.pBStatus4.TabStop = false;
            this.pBStatus4.Tag = "3";
            this.pBStatus4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBStatus_MouseClick);
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.lBProfiles);
            this.tabProfiles.Controls.Add(this.tSOptions);
            this.tabProfiles.Controls.Add(this.toolStrip1);
            resources.ApplyResources(this.tabProfiles, "tabProfiles");
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.UseVisualStyleBackColor = true;
            // 
            // lBProfiles
            // 
            this.lBProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBProfiles.ContextMenuStrip = this.cMProfile;
            resources.ApplyResources(this.lBProfiles, "lBProfiles");
            this.lBProfiles.FormattingEnabled = true;
            this.lBProfiles.MultiColumn = true;
            this.lBProfiles.Name = "lBProfiles";
            this.lBProfiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lBProfiles_KeyDown);
            this.lBProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBProfiles_MouseDoubleClick);
            this.lBProfiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lBProfiles_MouseDown);
            // 
            // cMProfile
            // 
            this.cMProfile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cMProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.assignToController1ToolStripMenuItem,
            this.assignToController2ToolStripMenuItem,
            this.assignToController3ToolStripMenuItem,
            this.assignToController4ToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.newProfileToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.cMProfile.Name = "cMProfile";
            resources.ApplyResources(this.cMProfile, "cMProfile");
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.tsBNEditProfile_Click);
            // 
            // assignToController1ToolStripMenuItem
            // 
            this.assignToController1ToolStripMenuItem.Name = "assignToController1ToolStripMenuItem";
            resources.ApplyResources(this.assignToController1ToolStripMenuItem, "assignToController1ToolStripMenuItem");
            this.assignToController1ToolStripMenuItem.Click += new System.EventHandler(this.assignToController1ToolStripMenuItem_Click);
            // 
            // assignToController2ToolStripMenuItem
            // 
            this.assignToController2ToolStripMenuItem.Name = "assignToController2ToolStripMenuItem";
            resources.ApplyResources(this.assignToController2ToolStripMenuItem, "assignToController2ToolStripMenuItem");
            this.assignToController2ToolStripMenuItem.Click += new System.EventHandler(this.assignToController2ToolStripMenuItem_Click);
            // 
            // assignToController3ToolStripMenuItem
            // 
            this.assignToController3ToolStripMenuItem.Name = "assignToController3ToolStripMenuItem";
            resources.ApplyResources(this.assignToController3ToolStripMenuItem, "assignToController3ToolStripMenuItem");
            this.assignToController3ToolStripMenuItem.Click += new System.EventHandler(this.assignToController3ToolStripMenuItem_Click);
            // 
            // assignToController4ToolStripMenuItem
            // 
            this.assignToController4ToolStripMenuItem.Name = "assignToController4ToolStripMenuItem";
            resources.ApplyResources(this.assignToController4ToolStripMenuItem, "assignToController4ToolStripMenuItem");
            this.assignToController4ToolStripMenuItem.Click += new System.EventHandler(this.assignToController4ToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.tsBDeleteProfle_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            resources.ApplyResources(this.duplicateToolStripMenuItem, "duplicateToolStripMenuItem");
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.tSBDupProfile_Click);
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            resources.ApplyResources(this.newProfileToolStripMenuItem, "newProfileToolStripMenuItem");
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.tsBNewProfile_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            this.importToolStripMenuItem.Click += new System.EventHandler(this.tSBImportProfile_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.tSBExportProfile_Click);
            // 
            // tSOptions
            // 
            this.tSOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tSTBProfile,
            this.tSBSaveProfile,
            this.tSBCancel,
            this.toolStripSeparator3,
            this.tSBKeepSize});
            resources.ApplyResources(this.tSOptions, "tSOptions");
            this.tSOptions.Name = "tSOptions";
            this.tSOptions.ShowItemToolTips = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // tSTBProfile
            // 
            this.tSTBProfile.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tSTBProfile.Name = "tSTBProfile";
            resources.ApplyResources(this.tSTBProfile, "tSTBProfile");
            this.tSTBProfile.Enter += new System.EventHandler(this.tBProfile_Enter);
            this.tSTBProfile.Leave += new System.EventHandler(this.tBProfile_Leave);
            this.tSTBProfile.TextChanged += new System.EventHandler(this.tBProfile_TextChanged);
            // 
            // tSBSaveProfile
            // 
            this.tSBSaveProfile.AutoToolTip = false;
            this.tSBSaveProfile.Image = global::DS4Windows.Properties.Resources.saveprofile;
            resources.ApplyResources(this.tSBSaveProfile, "tSBSaveProfile");
            this.tSBSaveProfile.Name = "tSBSaveProfile";
            this.tSBSaveProfile.Click += new System.EventHandler(this.tSBSaveProfile_Click);
            // 
            // tSBCancel
            // 
            this.tSBCancel.AutoToolTip = false;
            this.tSBCancel.Image = global::DS4Windows.Properties.Resources.delete;
            resources.ApplyResources(this.tSBCancel, "tSBCancel");
            this.tSBCancel.Name = "tSBCancel";
            this.tSBCancel.Click += new System.EventHandler(this.tSBCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // tSBKeepSize
            // 
            this.tSBKeepSize.Image = global::DS4Windows.Properties.Resources.size;
            resources.ApplyResources(this.tSBKeepSize, "tSBKeepSize");
            this.tSBKeepSize.Name = "tSBKeepSize";
            this.tSBKeepSize.Click += new System.EventHandler(this.tSBKeepSize_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBNewProfle,
            this.tsBEditProfile,
            this.tsBDeleteProfile,
            this.tSBDupProfile,
            this.tSBImportProfile,
            this.tSBExportProfile});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tsBNewProfle
            // 
            this.tsBNewProfle.Image = global::DS4Windows.Properties.Resources.newprofile;
            resources.ApplyResources(this.tsBNewProfle, "tsBNewProfle");
            this.tsBNewProfle.Name = "tsBNewProfle";
            this.tsBNewProfle.Click += new System.EventHandler(this.tsBNewProfile_Click);
            // 
            // tsBEditProfile
            // 
            this.tsBEditProfile.Image = global::DS4Windows.Properties.Resources.edit;
            resources.ApplyResources(this.tsBEditProfile, "tsBEditProfile");
            this.tsBEditProfile.Name = "tsBEditProfile";
            this.tsBEditProfile.Click += new System.EventHandler(this.tsBNEditProfile_Click);
            // 
            // tsBDeleteProfile
            // 
            resources.ApplyResources(this.tsBDeleteProfile, "tsBDeleteProfile");
            this.tsBDeleteProfile.Name = "tsBDeleteProfile";
            this.tsBDeleteProfile.Click += new System.EventHandler(this.tsBDeleteProfle_Click);
            // 
            // tSBDupProfile
            // 
            resources.ApplyResources(this.tSBDupProfile, "tSBDupProfile");
            this.tSBDupProfile.Name = "tSBDupProfile";
            this.tSBDupProfile.Click += new System.EventHandler(this.tSBDupProfile_Click);
            // 
            // tSBImportProfile
            // 
            this.tSBImportProfile.Image = global::DS4Windows.Properties.Resources.import;
            resources.ApplyResources(this.tSBImportProfile, "tSBImportProfile");
            this.tSBImportProfile.Name = "tSBImportProfile";
            this.tSBImportProfile.Click += new System.EventHandler(this.tSBImportProfile_Click);
            // 
            // tSBExportProfile
            // 
            resources.ApplyResources(this.tSBExportProfile, "tSBExportProfile");
            this.tSBExportProfile.Name = "tSBExportProfile";
            this.tSBExportProfile.Click += new System.EventHandler(this.tSBExportProfile_Click);
            // 
            // tabAutoProfiles
            // 
            resources.ApplyResources(this.tabAutoProfiles, "tabAutoProfiles");
            this.tabAutoProfiles.Name = "tabAutoProfiles";
            this.tabAutoProfiles.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.hideDS4CheckBox);
            this.flowLayoutPanel1.Controls.Add(this.cBSwipeProfiles);
            this.flowLayoutPanel1.Controls.Add(this.StartWindowsCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.startMinimizedCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.cBUpdate);
            this.flowLayoutPanel1.Controls.Add(this.pNUpdate);
            this.flowLayoutPanel1.Controls.Add(this.cBNotifications);
            this.flowLayoutPanel1.Controls.Add(this.cBDisconnectBT);
            this.flowLayoutPanel1.Controls.Add(this.cBQuickCharge);
            this.flowLayoutPanel1.Controls.Add(this.linkProfiles);
            this.flowLayoutPanel1.Controls.Add(this.lLBUpdate);
            this.flowLayoutPanel1.Controls.Add(this.linkSetup);
            this.flowLayoutPanel1.Controls.Add(this.linkUninstall);
            this.flowLayoutPanel1.Controls.Add(this.lnkControllers);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // hideDS4CheckBox
            // 
            resources.ApplyResources(this.hideDS4CheckBox, "hideDS4CheckBox");
            this.hideDS4CheckBox.Name = "hideDS4CheckBox";
            this.hideDS4CheckBox.UseVisualStyleBackColor = true;
            this.hideDS4CheckBox.CheckedChanged += new System.EventHandler(this.hideDS4CheckBox_CheckedChanged);
            // 
            // cBSwipeProfiles
            // 
            resources.ApplyResources(this.cBSwipeProfiles, "cBSwipeProfiles");
            this.cBSwipeProfiles.Checked = true;
            this.cBSwipeProfiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBSwipeProfiles.Name = "cBSwipeProfiles";
            this.cBSwipeProfiles.UseVisualStyleBackColor = true;
            this.cBSwipeProfiles.CheckedChanged += new System.EventHandler(this.cBSwipeProfiles_CheckedChanged);
            // 
            // StartWindowsCheckBox
            // 
            resources.ApplyResources(this.StartWindowsCheckBox, "StartWindowsCheckBox");
            this.StartWindowsCheckBox.Name = "StartWindowsCheckBox";
            this.StartWindowsCheckBox.UseVisualStyleBackColor = true;
            this.StartWindowsCheckBox.CheckedChanged += new System.EventHandler(this.StartWindowsCheckBox_CheckedChanged);
            // 
            // startMinimizedCheckBox
            // 
            resources.ApplyResources(this.startMinimizedCheckBox, "startMinimizedCheckBox");
            this.startMinimizedCheckBox.Name = "startMinimizedCheckBox";
            this.startMinimizedCheckBox.UseVisualStyleBackColor = true;
            this.startMinimizedCheckBox.CheckedChanged += new System.EventHandler(this.startMinimizedCheckBox_CheckedChanged);
            // 
            // cBUpdate
            // 
            resources.ApplyResources(this.cBUpdate, "cBUpdate");
            this.cBUpdate.Name = "cBUpdate";
            this.cBUpdate.UseVisualStyleBackColor = true;
            this.cBUpdate.CheckedChanged += new System.EventHandler(this.cBUpdate_CheckedChanged);
            // 
            // pNUpdate
            // 
            this.pNUpdate.Controls.Add(this.cBUpdateTime);
            this.pNUpdate.Controls.Add(this.lBCheckEvery);
            this.pNUpdate.Controls.Add(this.nUDUpdateTime);
            resources.ApplyResources(this.pNUpdate, "pNUpdate");
            this.pNUpdate.Name = "pNUpdate";
            // 
            // cBUpdateTime
            // 
            this.cBUpdateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBUpdateTime.FormattingEnabled = true;
            this.cBUpdateTime.Items.AddRange(new object[] {
            resources.GetString("cBUpdateTime.Items"),
            resources.GetString("cBUpdateTime.Items1")});
            resources.ApplyResources(this.cBUpdateTime, "cBUpdateTime");
            this.cBUpdateTime.Name = "cBUpdateTime";
            this.cBUpdateTime.SelectedIndexChanged += new System.EventHandler(this.cBUpdateTime_SelectedIndexChanged);
            // 
            // lBCheckEvery
            // 
            resources.ApplyResources(this.lBCheckEvery, "lBCheckEvery");
            this.lBCheckEvery.Name = "lBCheckEvery";
            // 
            // nUDUpdateTime
            // 
            resources.ApplyResources(this.nUDUpdateTime, "nUDUpdateTime");
            this.nUDUpdateTime.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUDUpdateTime.Name = "nUDUpdateTime";
            this.nUDUpdateTime.ValueChanged += new System.EventHandler(this.nUDUpdateTime_ValueChanged);
            // 
            // cBNotifications
            // 
            resources.ApplyResources(this.cBNotifications, "cBNotifications");
            this.cBNotifications.Name = "cBNotifications";
            this.cBNotifications.UseVisualStyleBackColor = true;
            this.cBNotifications.CheckedChanged += new System.EventHandler(this.cBNotifications_CheckedChanged);
            // 
            // cBDisconnectBT
            // 
            resources.ApplyResources(this.cBDisconnectBT, "cBDisconnectBT");
            this.cBDisconnectBT.Name = "cBDisconnectBT";
            this.cBDisconnectBT.UseVisualStyleBackColor = true;
            this.cBDisconnectBT.CheckedChanged += new System.EventHandler(this.cBDisconnectBT_CheckedChanged);
            // 
            // cBQuickCharge
            // 
            resources.ApplyResources(this.cBQuickCharge, "cBQuickCharge");
            this.cBQuickCharge.Name = "cBQuickCharge";
            this.cBQuickCharge.UseVisualStyleBackColor = true;
            this.cBQuickCharge.CheckedChanged += new System.EventHandler(this.cBQuickCharge_CheckedChanged);
            // 
            // linkProfiles
            // 
            resources.ApplyResources(this.linkProfiles, "linkProfiles");
            this.linkProfiles.Name = "linkProfiles";
            this.linkProfiles.TabStop = true;
            this.linkProfiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfiles_LinkClicked);
            // 
            // lLBUpdate
            // 
            resources.ApplyResources(this.lLBUpdate, "lLBUpdate");
            this.lLBUpdate.Name = "lLBUpdate";
            this.lLBUpdate.TabStop = true;
            this.lLBUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLBUpdate_LinkClicked);
            // 
            // linkSetup
            // 
            resources.ApplyResources(this.linkSetup, "linkSetup");
            this.linkSetup.Name = "linkSetup";
            this.linkSetup.TabStop = true;
            this.linkSetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLSetup_LinkClicked);
            // 
            // linkUninstall
            // 
            resources.ApplyResources(this.linkUninstall, "linkUninstall");
            this.linkUninstall.Name = "linkUninstall";
            this.linkUninstall.TabStop = true;
            this.linkUninstall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUninstall_LinkClicked);
            // 
            // lnkControllers
            // 
            resources.ApplyResources(this.lnkControllers, "lnkControllers");
            this.lnkControllers.Name = "lnkControllers";
            this.lnkControllers.TabStop = true;
            this.lnkControllers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkControllers_LinkClicked);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lvDebug);
            this.tabLog.Controls.Add(this.btnClear);
            resources.ApplyResources(this.tabLog, "tabLog");
            this.tabLog.Name = "tabLog";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // saveProfiles
            // 
            resources.ApplyResources(this.saveProfiles, "saveProfiles");
            // 
            // DS4Form
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlButton);
            this.Name = "DS4Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScpForm_Closing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ScpForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ScpForm_DragEnter);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.cMTaskbar.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabControllers.ResumeLayout(false);
            this.tLPControllers.ResumeLayout(false);
            this.tLPControllers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatus4)).EndInit();
            this.tabProfiles.ResumeLayout(false);
            this.tabProfiles.PerformLayout();
            this.cMProfile.ResumeLayout(false);
            this.tSOptions.ResumeLayout(false);
            this.tSOptions.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pNUpdate.ResumeLayout(false);
            this.pNUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdateTime)).EndInit();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDebug;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chData;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cMTaskbar;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileForController1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileForController2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileForController4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileForController3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openProfiles;
        private System.Windows.Forms.LinkLabel llbHelp;
        private System.Windows.Forms.Label lBTest;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListBox lBProfiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBNewProfle;
        private System.Windows.Forms.ToolStripButton tsBEditProfile;
        private System.Windows.Forms.ToolStripButton tsBDeleteProfile;
        private System.Windows.Forms.TabPage tabAutoProfiles;
        private System.Windows.Forms.ToolStripButton tSBDupProfile;
        private System.Windows.Forms.TabPage tabControllers;
        private System.Windows.Forms.TableLayoutPanel tLPControllers;
        private System.Windows.Forms.PictureBox pBStatus1;
        private System.Windows.Forms.Label lbPad1;
        private System.Windows.Forms.Label lbPad2;
        private System.Windows.Forms.Button bnEditC3;
        private System.Windows.Forms.Button bnEditC4;
        private System.Windows.Forms.Label lbPad3;
        private System.Windows.Forms.Label lbPad4;
        private System.Windows.Forms.ComboBox cBController1;
        private System.Windows.Forms.Button bnEditC2;
        private System.Windows.Forms.ComboBox cBController2;
        private System.Windows.Forms.ComboBox cBController3;
        private System.Windows.Forms.Button bnEditC1;
        private System.Windows.Forms.ComboBox cBController4;
        private System.Windows.Forms.Label lBSelectedProfile;
        private System.Windows.Forms.Label lBID;
        private System.Windows.Forms.Label lBStatus;
        private System.Windows.Forms.Label lBBattery;
        private System.Windows.Forms.Label lBBatt1;
        private System.Windows.Forms.Label lBBatt2;
        private System.Windows.Forms.Label lBBatt3;
        private System.Windows.Forms.Label lBBatt4;
        private System.Windows.Forms.PictureBox pBStatus2;
        private System.Windows.Forms.PictureBox pBStatus3;
        private System.Windows.Forms.PictureBox pBStatus4;
        private System.Windows.Forms.ToolStripButton tSBImportProfile;
        private System.Windows.Forms.ToolStripButton tSBExportProfile;
        private System.Windows.Forms.SaveFileDialog saveProfiles;
        private System.Windows.Forms.ContextMenuStrip cMProfile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToController1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToController2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToController3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToController4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tSOptions;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tSTBProfile;
        private System.Windows.Forms.ToolStripButton tSBSaveProfile;
        private System.Windows.Forms.ToolStripButton tSBCancel;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ToolStripButton tSBKeepSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel lLBUpdate;
        private System.Windows.Forms.LinkLabel linkSetup;
        private System.Windows.Forms.CheckBox hideDS4CheckBox;
        private System.Windows.Forms.CheckBox cBUpdate;
        private System.Windows.Forms.Panel pNUpdate;
        private System.Windows.Forms.ComboBox cBUpdateTime;
        private System.Windows.Forms.Label lBCheckEvery;
        private System.Windows.Forms.NumericUpDown nUDUpdateTime;
        private System.Windows.Forms.LinkLabel lnkControllers;
        private System.Windows.Forms.CheckBox StartWindowsCheckBox;
        private System.Windows.Forms.CheckBox startMinimizedCheckBox;
        private System.Windows.Forms.LinkLabel linkProfiles;
        private System.Windows.Forms.LinkLabel linkUninstall;
        private System.Windows.Forms.CheckBox cBNotifications;
        private System.Windows.Forms.CheckBox cBDisconnectBT;
        private System.Windows.Forms.CheckBox cBSwipeProfiles;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        public System.Windows.Forms.Label lbLastMessage;
        private System.Windows.Forms.CheckBox cBQuickCharge;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

