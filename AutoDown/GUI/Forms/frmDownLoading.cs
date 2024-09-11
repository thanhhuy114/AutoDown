using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    public partial class frmDownLoading : Form
    {
        private Action action;
        private Action cancelAction;

        public frmDownLoading()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            if (txtLabel.InvokeRequired)
                Invoke((Action)(() =>
                {
                    txtLabel.Text = text;
                    Console.WriteLine(text);
                }));
            else
                txtLabel.Text = text;
        }

        public void SetAction(Action action)
        {
            this.action = action;
        }

        private async void frmDownLoading_Shown(object sender, EventArgs e)
        {
            await Task.Run(action);

            if (InvokeRequired)
                Invoke((Action)(() => { Close(); }));
            else
                Close();
        }

        public void CancelAction(Action action)
        {
            cancelAction = action;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cancelAction != null)
                cancelAction();
            Close();
        }
    }
}