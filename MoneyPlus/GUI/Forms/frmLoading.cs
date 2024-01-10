using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        public frmLoading(string text)
        {
            InitializeComponent();

            label1.Text = text;
        }
    }
}
