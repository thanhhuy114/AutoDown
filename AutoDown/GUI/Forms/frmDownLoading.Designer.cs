using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    partial class frmDownLoading
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.txtLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnStartDown = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLabel
            // 
            this.txtLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.txtLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(97)))), ((int)(((byte)(166)))));
            this.txtLabel.Location = new System.Drawing.Point(20, 99);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLabel.Size = new System.Drawing.Size(182, 38);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "Đang bắt đầu";
            this.txtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.CustomizableEdges = customizableEdges1;
            this.guna2PictureBox1.ErrorImage = global::AutoDown.Properties.Resources.giphy;
            this.guna2PictureBox1.Image = global::AutoDown.Properties.Resources.giphy;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = global::AutoDown.Properties.Resources.giphy;
            this.guna2PictureBox1.Location = new System.Drawing.Point(48, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2PictureBox1.Size = new System.Drawing.Size(122, 99);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimationInterval = 100;
            this.BorderlessForm.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.BorderlessForm.BorderRadius = 40;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(142)))), ((int)(((byte)(253)))));
            this.BorderlessForm.TransparentWhileDrag = true;
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
            this.btnStartDown.Location = new System.Drawing.Point(68, 143);
            this.btnStartDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartDown.Name = "btnStartDown";
            this.btnStartDown.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.btnStartDown.Size = new System.Drawing.Size(82, 26);
            this.btnStartDown.TabIndex = 14;
            this.btnStartDown.Text = "Hủy";
            this.btnStartDown.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDownLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(222, 180);
            this.ControlBox = false;
            this.Controls.Add(this.btnStartDown);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDownLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.frmDownLoading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Button btnStartDown;
    }
}