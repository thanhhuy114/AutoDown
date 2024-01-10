using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Linq;
using System.Security.Principal;

namespace AutoDown.GUI.Forms
{
    public partial class AutoDown : Form
    {
        IWebDriver driver;

        const string URL_Login = @"https://sinhvien.cofer.edu.vn/sinh-vien-dang-nhap.html";


        /*
          https://media.cofer.edu.vn//viewer.html?k=y02W7hHqbO8nIaTOnHP24D_uOcxw9qfANu2jrA3qBmyH99carfeHPEFphp5h72XNSyggq_nuKj09HVCHv_DcX8zYhXGlskNonTsGQZJFTaYTOH-mip6OAT7ACwZ5tUdxS1u8KCYMJCjbTQ3wnbnuPA
         */

        void LoadWeb()
        {
            frmLoading frmLoad = new frmLoading("Đang load..");
            Thread t2 = new Thread(() =>
            {
                Invoke((Action)(() =>
                {
                    frmLoad.ShowDialog();
                }));
            });
            t2.IsBackground = true;
            t2.Start();

            driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl(URL_Login);
            }
            catch
            {
                driver.Navigate().GoToUrl("https://google.com/");
            }
            Invoke((Action)(() =>
            {
                frmLoad.Close();
            }));
        }

        string nameFolder()
        {
            string drectoryImage = AppDomain.CurrentDomain.BaseDirectory + @"Image";

            // format th001

            string[] folders = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory + @"Image");

            folders = folders.Select(item => Path.GetFileName(item)).ToArray();

            folders = folders.Select(item => item.Substring(2)).ToArray();

            var numFolder = folders.Select(item => Convert.ToInt32(item)).OrderBy(item => item).ToArray();

            if (numFolder.Count() == 0)
            {
                return drectoryImage + $"\\th{(0).ToString("000")}";
            }

            return drectoryImage + $"\\th{(numFolder.Last() + 1).ToString("000")}";
        }

        void convertToPDF(string pathFolder)
        {
            string directoryPath = Path.Combine(pathFolder);
            string[] fileNames = Directory.GetFiles(directoryPath).OrderBy(item => item)
                                         .ToArray();


            string[] pdfFile = Directory.GetFiles(txtFolderPath.Text);

            int counter = -1;

            string newFileName = $"{txtFolderPath.Text}\\{txtNameFile.Text}.pdf";

            while (File.Exists(newFileName))
            {
                newFileName = $"{txtFolderPath.Text}\\{txtNameFile.Text}{++counter}.pdf";
            }

            ConvertImagesToPdf(fileNames, newFileName);
        }


        void DownPng()
        {
            var imageElements = driver.FindElements(By.CssSelector("input[type='image']"));

            if (driver.Url.Contains("https://sinhvien.cofer.edu.vn/"))
            {
                imageElements = driver.FindElements(By.CssSelector("iframe[id='view']"));

                foreach (var imageElement in imageElements)
                {
                    string imageUrl = imageElement.GetAttribute("src");

                    if (imageUrl.Contains("https://media.cofer.edu.vn//viewer.html"))
                    {
                        Invoke((Action)(() =>
                        {
                            MessageBox.Show("Đang được chuyển hướng đến trang chứa tài liệu. Bạn vui lòng đợi load xong hết tất cả trang tài liệu và bấm 'Bắt đầu tải'. để tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                        driver.Navigate().GoToUrl(imageUrl);
                        return;
                    }
                }
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Không tìm thấy tài liệu cần tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                return;
            }
            else if (!driver.Url.Contains("https://media.cofer.edu.vn//viewer"))
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Không tìm thấy tài liệu cần tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                return;
            }

            imageElements = driver.FindElements(By.CssSelector("input[type='image']"));

            string pathFolder = nameFolder();

            Directory.CreateDirectory(pathFolder);


            int identify = -1;

            // Lặp qua từng phần tử <img> và tải xuống hình ảnh
            foreach (var imageElement in imageElements)
            {
                string imageUrl = imageElement.GetAttribute("src");


                if (!string.IsNullOrEmpty(imageUrl) && imageUrl.Contains("?page"))
                {
                    try
                    {
                        // Tạo tên tập tin từ URL hình ảnh
                        string fileName = System.IO.Path.GetFileName(imageUrl);

                        // Tải xuống hình ảnh và lưu vào thư mục
                        using (var client = new System.Net.WebClient())
                        {
                            client.DownloadFile(imageUrl, pathFolder + $"\\img{(++identify).ToString("0000")}.png");
                        }
                    }
                    catch (Exception ex)
                    {
                        Invoke((Action)(() =>
                        {
                            MessageBox.Show($"Error downloading image: {ex.Message}");
                            Close();
                        }));

                    }
                }
            }

            convertToPDF(pathFolder);

            Invoke((Action)(() =>
            {
                MessageBox.Show("Đã tải xong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }
        public AutoDown()
        {
            InitializeComponent();

            txtFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtNameFile.Text = "h";
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }



        private void btnDown_Click(object sender, EventArgs e)
        {
            if (driver != null) return;

            Thread t = new Thread(LoadWeb);
            t.IsBackground = true;
            t.Start();
        }


        private void btnStartDown_Click(object sender, EventArgs e)
        {
            if (driver == null)
            {
                MessageBox.Show("Vui lòng chọn mở Web trước khi tải", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Thread t = new Thread(() =>
            {
                frmLoading f = new frmLoading();
                Thread t2 = new Thread(() =>
                {
                    Invoke((Action)(() =>
                    {
                        f.ShowDialog();
                    }));
                });
                t2.IsBackground = true;
                t2.Start();

                DownPng();

                Invoke((Action)(() =>
                {
                    f.Close();
                }));
            });
            t.IsBackground = true;
            t.Start();
        }

        private void AutoDown_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
                driver.Quit();
        }



        public void ConvertImagesToPdf(string[] imagePaths, string outputPdfPath)
        {
            using (PdfDocument document = new PdfDocument())
            {
                foreach (string imagePath in imagePaths)
                {
                    XImage xImage = XImage.FromFile(imagePath);
                    PdfPage page = document.AddPage();
                    page.Width = xImage.PointWidth;
                    page.Height = xImage.PointHeight;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(xImage, 0, 0, xImage.PointWidth, xImage.PointHeight);
                }

                document.Save(outputPdfPath);
            }
        }

        private void AutoDown_Shown(object sender, EventArgs e)
        {
            btnDown.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bước 1: Điền URL hoặc để mặc định cũng được. \n" +
                "Bước 2: Nhấn mở Web và tìm mở phần tài liệu cần tải.\n" +
                "Bước 3: Nhấn Nút bắt đầu tải để Ứng dụng tự tìm và mở đến trang có thể tải, và bạn hãy lướt đến cuối trang và đợi cho các trang tài liệu được load lên hết.\n" +
                "Bước 4: Chọn đường dẫn lưu file và đặt tên File (có thể để mặc định).\n" +
                "Bước 5: Nhấn bắt đầu tải để ứng dụng bắt đầu tải tài liệu về máy.\n" +
                "Bước 6: Khi hoàn tất bạn có thể tắt ứng dụng hoặc tải tiếp tài liệu khác. Nhưng lưu ý trùng tên file nhé\n" +
                "Cảm ơn <3", "HƯỚNG DẪN SỬ DỤNG AUTODOWN");
        }
    }
}