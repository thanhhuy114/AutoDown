using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AutoDown.Properties;
using AutoDown.Utils;
using OpenQA.Selenium.Chrome;

namespace AutoDown.GUI.Forms
{
    public partial class frmMain : Form
    {
        private readonly WebView webView;
        private DownloadImage download;

        public frmMain()
        {
            InitializeComponent();

            txtFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            GetSettings();
            txtPassword.UseSystemPasswordChar = true;

            var options = new ChromeOptions();

            // không hiện cửa sổ chrome ('--headless')
            //options.AddArgument("--headless");

            webView = new WebView(options);
        }

        private void GetSettings()
        {
            txtPassword.Text = Settings.Default.Password;
            txtMSSV.Text = Settings.Default.MSSV;
            txtPDFFileName.Text = Settings.Default.FileName;
            checkboxUseDocmumentName.Checked = Settings.Default.IsUseDocName;
        }

        private void SetStatus(string text)
        {
            if (btnDown.InvokeRequired)
                Invoke((Action)(() => btnDown.Text = text));
            else
                btnDown.Text = text;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnLoadWeb_Click(object sender, EventArgs e)
        {
            if (!webView.IsWebViewShow())
            {
                var frmLoading = new frmLoading(() =>
                {
                    webView.Open();

                    if (!webView.IsWebViewShow())
                    {
                        MessageBox.Show("Lỗi mở Web");
                        return;
                    }

                    webView.HandleUI(txtMSSV.Text, txtPassword.Text);
                    SetStatus("Đóng Web");
                    HandleUIForm();
                    Invoke((Action)(() => { pnlAutoComplate.Visible = false; }));
                }, "Đang load...");
                frmLoading.RunTask();
            }
            else
            {
                var frmLoading = new frmLoading(() =>
                {
                    webView.Close();

                    if (webView.IsWebViewShow()) return;
                    HandleUIForm();
                    SetStatus("Mở Web");
                }, "Đang đóng...");
                frmLoading.RunTask();
            }
        }

        private void HandleUIForm()
        {
            Invoke((Action)(() =>
            {
                pnlAutoComplate.Visible = !pnlAutoComplate.Visible;
                Size = new Size(Size.Width,
                    Size.Height - pnlAutoComplate.Size.Height * (pnlAutoComplate.Visible ? -1 : 1));
            }));
        }

        private void btnStartDown_Click(object sender, EventArgs e)
        {
            var dialog = DialogResult.No;
            var loading = new frmLoading(() =>
            {
                var isWebShow = webView.IsWebViewShowSync();

                if (!isWebShow)
                {
                    MessageBox.Show("Bạn chưa mở Web", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!webView.IsValidUrl())
                {
                    MessageBox.Show("Chúng tôi chỉ cho phép tải tài liệu trên trang \"sinhvien.cofer.edu.vn\"",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                if (!webView.CheckExistDocument())
                {
                    MessageBox.Show("Không tìm thấy tài liệu trên trang này", "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                dialog = MessageBox.Show($"Bạn có chắc muốn tải{Environment.NewLine}{webView.GetDocumentTitle()}",
                    "Tải xuống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }, "Chờ tí");

            loading.ShowDialog();

            if (dialog == DialogResult.No) return;

            var loadF = new frmDownLoading();
            var cts = new CancellationTokenSource();
            var progress = new Progress<ProgressReport>(report =>
            {
                if (report.Exception != null)
                {
                    MessageBox.Show("Lỗi trong quá trình tải", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (report.IsSuccess)
                {
                    MessageBox.Show("Đã tải xong", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }

                loadF.SetText(report.Message);
            });

            loadF.SetAction(() => { DownLoad(progress, cts.Token); });

            loadF.CancelAction(() => { cts.Cancel(); });

            loadF.ShowDialog();
        }

        private void DownLoad(IProgress<ProgressReport> progress, CancellationToken cancellationToken)
        {
            var options = new ChromeOptions();

            // không hiện cửa sổ chrome ('--headless')
            options.AddArgument("--headless");
            options.AddArgument("--ignore-certificate-errors");
            download = new DownloadImage(new WebView(options));

            download.StartDownLoad(webView.GetURLDocument(), txtFolderPath.Text,
                checkboxUseDocmumentName.Checked ? webView.GetDocumentTitle() : txtPDFFileName.Text, progress,
                cancellationToken);
        }

        private void AutoDown_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (webView.IsWebViewShow())
            {
                e.Cancel = true;
                var frmLoading = new frmLoading(() =>
                {
                    webView.Close();

                    Invoke((Action)(() => { Close(); }));
                }, "Đang đóng...");
                frmLoading.RunTask();
            }

            if (download != null)
                download.Dispoes();
        }

        private void AutoDown_Shown(object sender, EventArgs e)
        {
            btnDown.Focus();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Lưu ý: Ứng dụng chỉ dùng để tải tài liệu trên \"sinhvien.cofer.edu.vn\"\n" +
                "Bước 1: Nhấn mở Web (không mở thì lấy gì tải!). \n" +
                "Bước 2: Đăng nhập và tìm mở phần tài liệu cần tải (hoặc dán link tài liệu vào luôn cũng được.\n" +
                "Bước 3: Nhấn Nút bắt đầu tải và đi lướt TikTok hay gì đó...\n" +
                "Bước 4: Có thể thay đổi đường dẫn lưu flie và tên flie nữa nhé.\n" +
                "Bước 5: Khi tải xong sẽ có thông báo, có thể tắt hoặc tải tài liệu tiếp theo.\n" +
                "Bước 6: Bước 5 là hết rồi nhé, tại mới Update nên nó đơn giản hơn phiên bản cũ....\n" +
                "Bước 7: Nói là hết rồi mà còn ráng đọc tới đây chi nữa :< \n" +
                "Cảm ơn <3", "HƯỚNG DẪN SỬ DỤNG AUTODOWN");

            Process.Start("https://github.com/thanhhuy114/AutoDown");
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
                txtPassword.IconRight = Resources.show;
            else
                txtPassword.IconRight = Resources.hide;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.Save();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.MSSV = txtMSSV.Text;
            Settings.Default.Save();
        }

        private void checkboxUseDocmumentName_CheckedChanged(object sender, EventArgs e)
        {
            txtPDFFileName.Enabled = !checkboxUseDocmumentName.Checked;

            Settings.Default.IsUseDocName = checkboxUseDocmumentName.Checked;
            Settings.Default.Save();
        }

        private void txtPDFFileName_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.FileName = txtPDFFileName.Text;
            Settings.Default.Save();
        }
    }
}