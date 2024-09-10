using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    public partial class frmLoading : Form
    {
        private readonly Action action;
        public frmLoading(Action action, string label = null)
        {
            InitializeComponent();

            this.action = action;
            if (label != null)
                txtLabel.Text = label;
        }
        public void setText(string text) { txtLabel.Text = text; }


        public void RunTask()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)(() => { ShowDialog(); }));
            }
            else
            {
                ShowDialog();
            }
        }

        private async void frmLoading_Shown(object sender, EventArgs e)
        {
            await Task.Run(action);

            if (this.InvokeRequired)
            {
                Invoke((Action)(() => { Close(); }));
            }
            else
            {
                Close();
            }
        }
    }
}
