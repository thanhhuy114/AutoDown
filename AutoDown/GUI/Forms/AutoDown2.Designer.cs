using AutoDown.Properties;
using System.Windows.Forms;


namespace AutoDown.GUI.Forms
{
    partial class AutoDown2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDown2));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDown = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartDown = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolderPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOpenFolder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Chọn đường dẫn lưu flie";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnDown);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnStartDown);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtNameFile);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtFolderPath);
            this.guna2Panel1.Controls.Add(this.btnOpenFolder);
            this.guna2Panel1.CustomizableEdges = customizableEdges11;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.guna2Panel1.Size = new System.Drawing.Size(500, 755);
            this.guna2Panel1.TabIndex = 15;
            // 
            // btnDown
            // 
            this.btnDown.BorderRadius = 5;
            this.btnDown.CustomizableEdges = customizableEdges1;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = global::AutoDown.Properties.Resources.world_wide_web;
            this.btnDown.ImageSize = new System.Drawing.Size(26, 26);
            this.btnDown.Location = new System.Drawing.Point(16, 17);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnDown.Size = new System.Drawing.Size(470, 60);
            this.btnDown.TabIndex = 10;
            this.btnDown.Tag = "1";
            this.btnDown.Text = " Mở Web";
            this.btnDown.Click += new System.EventHandler(this.btnLoadWeb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(16, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên File (.pdf)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(14, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lưu ý: \r\nBạn bắt buộc phải có Chrome mới có thể sử dụng ứng dụng này\r\nỨng dụng nà" +
    "y chỉ áp dụng cho web https://sinhvien.cofer.edu.vn\r\n";
            // 
            // btnStartDown
            // 
            this.btnStartDown.BorderRadius = 5;
            this.btnStartDown.CustomizableEdges = customizableEdges3;
            this.btnStartDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDown.ForeColor = System.Drawing.Color.White;
            this.btnStartDown.Location = new System.Drawing.Point(136, 437);
            this.btnStartDown.Name = "btnStartDown";
            this.btnStartDown.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnStartDown.Size = new System.Drawing.Size(214, 60);
            this.btnStartDown.TabIndex = 13;
            this.btnStartDown.Text = "Bắt đầu tải";
            this.btnStartDown.Click += new System.EventHandler(this.btnStartDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hướng dẫn sử dụng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNameFile
            // 
            this.txtNameFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNameFile.BorderRadius = 5;
            this.txtNameFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameFile.CustomizableEdges = customizableEdges5;
            this.txtNameFile.DefaultText = "h";
            this.txtNameFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFile.Location = new System.Drawing.Point(16, 272);
            this.txtNameFile.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.PasswordChar = '\0';
            this.txtNameFile.PlaceholderText = "";
            this.txtNameFile.SelectedText = "";
            this.txtNameFile.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.txtNameFile.Size = new System.Drawing.Size(248, 60);
            this.txtNameFile.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(10, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đường dẫn lưu file";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFolderPath.BorderRadius = 5;
            this.txtFolderPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFolderPath.CustomizableEdges = customizableEdges7;
            this.txtFolderPath.DefaultText = "";
            this.txtFolderPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFolderPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFolderPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFolderPath.Enabled = false;
            this.txtFolderPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFolderPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFolderPath.Location = new System.Drawing.Point(16, 162);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.PasswordChar = '\0';
            this.txtFolderPath.PlaceholderText = "";
            this.txtFolderPath.SelectedText = "";
            this.txtFolderPath.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.txtFolderPath.Size = new System.Drawing.Size(364, 60);
            this.txtFolderPath.TabIndex = 8;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BorderRadius = 5;
            this.btnOpenFolder.CustomizableEdges = customizableEdges9;
            this.btnOpenFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOpenFolder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenFolder.Location = new System.Drawing.Point(388, 162);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.btnOpenFolder.Size = new System.Drawing.Size(98, 60);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Tìm";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.CustomizableEdges = customizableEdges13;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.Location = new System.Drawing.Point(500, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            this.guna2Panel2.Size = new System.Drawing.Size(8, 755);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.Controls.Add(this.webView);
            this.guna2Panel3.CustomizableEdges = customizableEdges15;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel3.Location = new System.Drawing.Point(508, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges16;
            this.guna2Panel3.Size = new System.Drawing.Size(124, 755);
            this.guna2Panel3.TabIndex = 17;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(124, 755);
            this.webView.Source = new System.Uri("https://sinhvien.cofer.edu.vn/sinh-vien-dang-nhap.html", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // AutoDown2
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 755);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoDown2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDown (version 3.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoDown_FormClosing);
            this.Shown += new System.EventHandler(this.AutoDown_Shown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDown;
        private Label label4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnStartDown;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNameFile;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtFolderPath;
        private Guna.UI2.WinForms.Guna2Button btnOpenFolder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}