using AutoDown.Constants;
using OpenQA.Selenium;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AutoDown.GUI.Forms
{
    public partial class AutoDown2 : Form
    {
        const string TEXT_FORMAT_PAGE = "0000000X";

        IWebDriver webDriver;

        void LoadWeb()
        {
            frmLoading frmLoad = new frmLoading("Đang load..");

            Utils.StartNewThread(() =>
            {
                Invoke((Action)(() =>
                {
                    frmLoad.ShowDialog();
                }));
            });

            webDriver = new OpenQA.Selenium.Safari.SafariDriver();

            //OpenQA.Selenium.

            try
            {
                webDriver.Navigate().GoToUrl(AppConstants.URL_PAGE_LOGIN);
                Console.WriteLine(webDriver.PageSource);
                AutoLogin();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                webDriver.Navigate().GoToUrl("https://google.com/");
            }
            frmLoad.close();
        }

        void AutoLogin()
        {
            try
            {
                IWebElement username = webDriver.FindElement(By.CssSelector("#UserName"));
                IWebElement password = webDriver.FindElement(By.CssSelector("#Password"));
                IWebElement title = webDriver.FindElement(By.XPath("//h4[@lang='loginnews-pagetitle']"));
                IWebElement button = webDriver.FindElement(By.XPath("//input[@class='button']"));
                IWebElement image = webDriver.FindElement(By.CssSelector("div.text-center > img"));
                IWebElement wobbly = webDriver.FindElement(By.XPath("//div[@class='col-lg-9 col-md-8']"));
                IWebElement header = webDriver.FindElement(By.XPath("//header"));
                IWebElement downloadArea = webDriver.FindElement(By.XPath("//div[@class='box-download-app']"));


                username.SendKeys(AppConstants.USERNAME);
                password.SendKeys(AppConstants.PASSWORD);

                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].innerText = 'Welcome AutoDown';", title);

                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].value = 'AutoDown =>';", button);
                ((IJavaScriptExecutor)webDriver).ExecuteScript($"arguments[0].src = '{AppConstants.URL_AVATA_DEFAULT}';", image);


                // Sử dụng JavaScript Executor để xóa phần tử
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", wobbly);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", header);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", downloadArea);

                //in ra html của element
                //webElement.GetAttribute("outerHTML")
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        void checkExistsImageFolder(string drectoryImage)
        {
            if (!Directory.Exists(drectoryImage)) Directory.CreateDirectory(drectoryImage);
        }

        string getNewFolderImage()
        {

            string drectoryImage = AppDomain.CurrentDomain.BaseDirectory + @"Image";
            checkExistsImageFolder(drectoryImage);

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
                newFileName = $"{txtFolderPath.Text}\\{txtNameFile.Text}({++counter}).pdf";
            }

            ConvertImagesToPdf(fileNames, newFileName);
        }

        bool checkURL(ReadOnlyCollection<IWebElement> imageElements)
        {
            if (webDriver.Url.Contains("https://sinhvien.cofer.edu.vn/"))
            {
                imageElements = webDriver.FindElements(By.CssSelector("iframe[id='view']"));

                foreach (var imageElement in imageElements)
                {
                    string imageUrl = imageElement.GetAttribute("src");

                    if (imageUrl.Contains("https://media.cofer.edu.vn//viewer.html"))
                    {
                        Invoke((Action)(() =>
                        {
                            MessageBox.Show("Đang được chuyển hướng đến trang chứa tài liệu. Bạn vui lòng đợi load xong hết tất cả trang tài liệu và bấm 'Bắt đầu tải'. để tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                        webDriver.Navigate().GoToUrl(imageUrl);
                        return false;
                    }
                }
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Không tìm thấy tài liệu cần tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                return false;
            }
            else if (!webDriver.Url.Contains("https://media.cofer.edu.vn//viewer"))
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Không tìm thấy tài liệu cần tải xuống.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
                return false;
            }

            return true;
        }

        int getCounterPage()
        {
            string pageHtml = webDriver.PageSource;
            var listPage = webDriver.FindElements(By.XPath("//input[@class='docThumb docUnselectable']"));
            return listPage.Count;
        }

        void DownPng()
        {
            var imageElements = webDriver.FindElements(By.CssSelector("input[type='image']"));

            if (!checkURL(imageElements)) return;

            imageElements = webDriver.FindElements(By.CssSelector("input[type='image']"));

            //
            string pathFolder = getNewFolderImage();

            Directory.CreateDirectory(pathFolder);

            int identify = -1;

            string imageUrl = "";

            // Lặp qua từng phần tử <img> và tải xuống hình ảnh
            foreach (var imageElement in imageElements)
            {
                string urlByElement = imageElement.GetAttribute("src");

                // chỉ cần tìm được 1 url rồi thay đổi số page là được
                if (!string.IsNullOrEmpty(urlByElement) && urlByElement.Contains("?page"))
                {
                    imageUrl = urlByElement;
                    break;
                }
            }

            if (imageUrl == "")
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show("Đợi một tý đi nhé...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));

                return;
            }

            // lấy ra số page
            int counterPage = getCounterPage() + 2;
            imageUrl = formatUrlImage(imageUrl);

            string newImageUrl;
            for (int i = 1; i < counterPage; i++)
            {
                newImageUrl = imageUrl.Replace(TEXT_FORMAT_PAGE, $"{i}");
                try
                {
                    // Tải xuống hình ảnh và lưu vào thư mục
                    using (var client = new System.Net.WebClient())
                    {
                        string path = pathFolder + $"\\img{(++identify).ToString("0000")}.png";
                        client.DownloadFile(newImageUrl, path);
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

            convertToPDF(pathFolder);

            Invoke((Action)(() =>
            {
                MessageBox.Show("Đã tải xong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }
        public AutoDown2()
        {
            InitializeComponent();

            txtFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtNameFile.Text = "h";
        }

        string formatUrlImage(string url)
        {
            int startIndex = url.IndexOf("?page=") + 6;

            int endIndex = url.IndexOf("&zoom");

            string subString = url.Substring(startIndex, endIndex - startIndex);

            return url.Replace($"?page={subString}", $"?page={TEXT_FORMAT_PAGE}");
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }



        private void btnLoadWeb_Click(object sender, EventArgs e)
        {
            if (webDriver != null) return;

            Thread t = new Thread(LoadWeb);
            t.IsBackground = true;
            t.Start();
        }

        static bool IsWebDriverRunning()
        {
            Process[] processes = Process.GetProcessesByName("chromedriver");
            return processes.Length > 0;
        }


        private void btnStartDown_Click(object sender, EventArgs e)
        {

            if (webDriver == null || !IsWebDriverRunning())
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
            if (webDriver != null)
                webDriver.Quit();
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
                "Lưu ý: Tắt app trước khi tắt web\n" +
                "Bước 1: Nhấn mở Web (không mở thì lấy gì tải!). \n" +
                "Bước 2: Đăng nhập và tìm mở phần tài liệu cần tải (hoặc dán link tài liệu vào luôn cũng được.\n" +
                "Bước 3: Nhấn Nút bắt đầu tải và đi lướt TikTok hay gì đó...\n" +
                "Bước 4: Có thể thay đổi đường dẫn lưu flie và tên flie nữa nhé.\n" +
                "Bước 5: Khi tải xong sẽ có thông báo, có thể tắt hoặc tải tài liệu tiếp theo.\n" +
                "Bước 6: Bước 5 là hết rồi nhé, tại mới Update nên nó đơn giản hơn phiên bản cũ....\n" +
                "Bước 7: Nói là hết rồi mà còn ráng đọc tới đây chi nữa thím :< \n" +
                "Cảm ơn <3", "HƯỚNG DẪN SỬ DỤNG AUTODOWN by Huy");
        }
    }
}