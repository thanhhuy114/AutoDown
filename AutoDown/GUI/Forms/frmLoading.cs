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


        public async void RunTask()
        {

            if (this.InvokeRequired)
            {
                Invoke((Action)(() => { Show(); }));
            }
            else
            {
                Show();
            }

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
