using AutoDown.Properties;
using System.Windows.Forms;


namespace AutoDown.GUI.Forms
{
    partial class frmMain
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolderPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOpenFolder = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.txtPDFFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnStartDown = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkboxUseDocmumentName = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAutoComplate = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlAutoComplate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hướng dẫn sử dụng";
            this.label3.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đường dẫn lưu file";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFolderPath.BorderRadius = 5;
            this.txtFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFolderPath.CustomizableEdges = customizableEdges1;
            this.txtFolderPath.DefaultText = "";
            this.txtFolderPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.Enabled = false;
            this.txtFolderPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolderPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Location = new System.Drawing.Point(7, 51);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.PasswordChar = '\0';
            this.txtFolderPath.PlaceholderText = "";
            this.txtFolderPath.SelectedText = "";
            this.txtFolderPath.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.txtFolderPath.Size = new System.Drawing.Size(243, 39);
            this.txtFolderPath.TabIndex = 8;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BorderRadius = 5;
            this.btnOpenFolder.CustomizableEdges = customizableEdges3;
            this.btnOpenFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOpenFolder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenFolder.Location = new System.Drawing.Point(255, 51);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnOpenFolder.Size = new System.Drawing.Size(65, 39);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Tìm";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnDown
            // 
            this.btnDown.BorderRadius = 5;
            this.btnDown.CustomizableEdges = customizableEdges5;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = global::AutoDown.Properties.Resources.world_wide_web;
            this.btnDown.ImageSize = new System.Drawing.Size(26, 26);
            this.btnDown.Location = new System.Drawing.Point(7, 6);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.btnDown.Size = new System.Drawing.Size(313, 39);
            this.btnDown.TabIndex = 10;
            this.btnDown.Tag = "1";
            this.btnDown.Text = " Mở Web";
            this.btnDown.Click += new System.EventHandler(this.btnLoadWeb_Click);
            // 
            // txtPDFFileName
            // 
            this.txtPDFFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPDFFileName.BorderRadius = 5;
            this.txtPDFFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDFFileName.CustomizableEdges = customizableEdges7;
            this.txtPDFFileName.DefaultText = "h";
            this.txtPDFFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPDFFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPDFFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDFFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDFFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDFFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPDFFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDFFileName.Location = new System.Drawing.Point(11, 27);
            this.txtPDFFileName.Name = "txtPDFFileName";
            this.txtPDFFileName.PasswordChar = '\0';
            this.txtPDFFileName.PlaceholderText = "";
            this.txtPDFFileName.SelectedText = "";
            this.txtPDFFileName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.txtPDFFileName.Size = new System.Drawing.Size(147, 39);
            this.txtPDFFileName.TabIndex = 12;
            this.txtPDFFileName.TextChanged += new System.EventHandler(this.txtPDFFileName_TextChanged);
            // 
            // btnStartDown
            // 
            this.btnStartDown.BorderRadius = 5;
            this.btnStartDown.CustomizableEdges = customizableEdges9;
            this.btnStartDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDown.ForeColor = System.Drawing.Color.White;
            this.btnStartDown.Location = new System.Drawing.Point(88, 5);
            this.btnStartDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartDown.Name = "btnStartDown";
            this.btnStartDown.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.btnStartDown.Size = new System.Drawing.Size(143, 39);
            this.btnStartDown.TabIndex = 13;
            this.btnStartDown.Text = "Bắt đầu tải";
            this.btnStartDown.Click += new System.EventHandler(this.btnStartDown_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên File (.pdf)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã sinh viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMSSV.BorderRadius = 5;
            this.txtMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSSV.CustomizableEdges = customizableEdges11;
            this.txtMSSV.DefaultText = "";
            this.txtMSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSSV.Location = new System.Drawing.Point(9, 52);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.PasswordChar = '\0';
            this.txtMSSV.PlaceholderText = "";
            this.txtMSSV.SelectedText = "";
            this.txtMSSV.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.txtMSSV.Size = new System.Drawing.Size(117, 25);
            this.txtMSSV.TabIndex = 15;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tự động điền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label7.Location = new System.Drawing.Point(142, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.CustomizableEdges = customizableEdges13;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconRight = global::AutoDown.Properties.Resources.hide;
            this.txtPassword.IconRightSize = new System.Drawing.Size(18, 18);
            this.txtPassword.Location = new System.Drawing.Point(142, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges14;
            this.txtPassword.Size = new System.Drawing.Size(161, 25);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.IconRightClick += new System.EventHandler(this.txtPassword_IconRightClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlAutoComplate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 366);
            this.panel1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnStartDown);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 55);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkboxUseDocmumentName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtPDFFileName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 77);
            this.panel4.TabIndex = 3;
            // 
            // checkboxUseDocmumentName
            // 
            this.checkboxUseDocmumentName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkboxUseDocmumentName.CheckedState.BorderRadius = 2;
            this.checkboxUseDocmumentName.CheckedState.BorderThickness = 0;
            this.checkboxUseDocmumentName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkboxUseDocmumentName.CustomizableEdges = customizableEdges15;
            this.checkboxUseDocmumentName.Location = new System.Drawing.Point(165, 43);
            this.checkboxUseDocmumentName.Name = "checkboxUseDocmumentName";
            this.checkboxUseDocmumentName.ShadowDecoration.CustomizableEdges = customizableEdges16;
            this.checkboxUseDocmumentName.Size = new System.Drawing.Size(20, 17);
            this.checkboxUseDocmumentName.TabIndex = 21;
            this.checkboxUseDocmumentName.Text = "guna2CustomCheckBox1";
            this.checkboxUseDocmumentName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkboxUseDocmumentName.UncheckedState.BorderRadius = 2;
            this.checkboxUseDocmumentName.UncheckedState.BorderThickness = 0;
            this.checkboxUseDocmumentName.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkboxUseDocmumentName.CheckedChanged += new System.EventHandler(this.checkboxUseDocmumentName_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label8.Location = new System.Drawing.Point(186, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sử dụng tên của tài liệu";
            // 
            // pnlAutoComplate
            // 
            this.pnlAutoComplate.Controls.Add(this.txtPassword);
            this.pnlAutoComplate.Controls.Add(this.txtMSSV);
            this.pnlAutoComplate.Controls.Add(this.label7);
            this.pnlAutoComplate.Controls.Add(this.label2);
            this.pnlAutoComplate.Controls.Add(this.label6);
            this.pnlAutoComplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAutoComplate.Location = new System.Drawing.Point(0, 145);
            this.pnlAutoComplate.Name = "pnlAutoComplate";
            this.pnlAutoComplate.Size = new System.Drawing.Size(330, 89);
            this.pnlAutoComplate.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFolderPath);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnOpenFolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 96);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 49);
            this.panel2.TabIndex = 0;
            // 
            // AutoDown
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 366);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AutoDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDown (version 3.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoDown_FormClosing);
            this.Shown += new System.EventHandler(this.AutoDown_Shown);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlAutoComplate.ResumeLayout(false);
            this.pnlAutoComplate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label3;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFolderPath;
        private Guna.UI2.WinForms.Guna2Button btnOpenFolder;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Button btnDown;
        private Guna.UI2.WinForms.Guna2TextBox txtPDFFileName;
        private Guna.UI2.WinForms.Guna2Button btnStartDown;
        private Label label4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMSSV;
        private Label label6;
        private Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Panel panel1;
        private Panel pnlAutoComplate;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Label label8;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkboxUseDocmumentName;
    }
}