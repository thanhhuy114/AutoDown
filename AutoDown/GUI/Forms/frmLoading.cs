using System;
using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading(string text = null)
        {
            InitializeComponent();

            if (text != null)
                label1.Text = text;
        }

        public void show()
        {
            Utils.StartNewThread(() =>
            {
                Invoke((Action)(() =>
                {
                    ShowDialog();
                }));
            });
        }

        public void close()
        {
            Invoke((Action)(() =>
            {
                Close();
            }));
        }
    }
}
