using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using AutoDown.Constants;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace AutoDown.Utils
{
    public class ProgressReport
    {
        public int Percent { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Exception Exception { get; set; }
    }

    public class DownloadImage
    {
        private CancellationToken cancellationToken;
        private string pdfFileName;
        private string savePath;
        private readonly WebView webView;

        public DownloadImage(WebView webView)
        {
            this.webView = webView;
        }

        private void CreateImageDirectory(string directoryImage)
        {
            Directory.CreateDirectory(directoryImage);
        }

        private bool IsValidDirectory(string directoryName)
        {
            // Format => "HT_xxx", note xxx (000 -> 999)
            return directoryName.Length == AppConstants.FORMAT_IMAGE_DIRECTORY_LENGHT &&
                   directoryName.Substring(0, 3) == AppConstants.FORMAT_IMAGE_DIRECTORY_NAME &&
                   int.TryParse(directoryName.Substring(3, 3), out _);
        }

        private int GetNumberInDirectoryName(string directoryName)
        {
            // Format => "HT_xxx", note xxx (000 -> 999)
            return Convert.ToInt32(directoryName.Substring(3, 3));
        }

        private string GetImageDirectoryPath(string directoryImagePath)
        {
            if (!Directory.Exists(directoryImagePath))
                CreateImageDirectory(directoryImagePath);

            // format th001
            var directoryImages = Directory.GetDirectories(directoryImagePath);

            directoryImages = directoryImages.Select(item => Path.GetFileName(item))
                .Where(item => IsValidDirectory(item)).OrderByDescending(i => i).ToArray();

            if (directoryImages.Length > 0)
                return
                    $"{directoryImagePath}{AppConstants.FORMAT_IMAGE_DIRECTORY_NAME}{(GetNumberInDirectoryName(directoryImages[0]) + 1).ToString("000")}";
            return $"{directoryImagePath}{AppConstants.FORMAT_IMAGE_DIRECTORY_NAME}000";
        }

        private void CheckCancel()
        {
            if (cancellationToken.IsCancellationRequested) throw new Exception("Cancel download");
        }


        public void StartDownLoad(string url, string savePath, string pdfFileName, IProgress<ProgressReport> progress,
            CancellationToken _cancellationToken)
        {
            cancellationToken = _cancellationToken;
            this.savePath = savePath;
            this.pdfFileName = pdfFileName;
            var directoryImagePath = $"{AppDomain.CurrentDomain.BaseDirectory}Images\\";

            webView.Open(url);

            var newDirectoryImagePath = GetImageDirectoryPath(directoryImagePath);
            Directory.CreateDirectory(newDirectoryImagePath);


            try
            {
                DownLoading(newDirectoryImagePath, progress);

                CheckCancel();

                progress.Report(
                    new ProgressReport { Message = "Đang tạo PDF..." });

                ConvertToPDF(newDirectoryImagePath);

                CheckCancel();

                webView.Close();
                progress.Report(
                    new ProgressReport { IsSuccess = true });
            }
            catch (Exception error)
            {
                webView.Close();
                if (!cancellationToken.IsCancellationRequested)
                    progress.Report(
                        new ProgressReport { Exception = new Exception(error.Message) });
            }
        }


        private void ConvertToPDF(string _directoryPath)
        {
            var directoryPath = Path.Combine(_directoryPath);
            var imageNames = Directory.GetFiles(directoryPath).OrderBy(item => item)
                .ToArray();

            var pdfFileNames = Directory.GetFiles(savePath);

            var newPDFFileName = $"{savePath}\\{pdfFileName}.pdf";

            var counter = -1;
            while (File.Exists(newPDFFileName)) newPDFFileName = $"{savePath}\\{pdfFileName}({++counter}).pdf";

            ConvertImagesToPdf(imageNames, newPDFFileName);
        }

        private void ConvertImagesToPdf(string[] imagePaths, string outputPdfPath)
        {
            using (var document = new PdfDocument())
            {
                foreach (var imagePath in imagePaths)
                {
                    CheckCancel();
                    var xImage = XImage.FromFile(imagePath);
                    var page = document.AddPage();
                    page.Width = xImage.PointWidth;
                    page.Height = xImage.PointHeight;
                    var gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(xImage, 0, 0, xImage.PointWidth, xImage.PointHeight);
                }

                document.Save(outputPdfPath);
            }
        }

        private void DownLoading(string drectoryImagePath, IProgress<ProgressReport> progress)
        {
            var mainUrlImage = webView.GetURLImage();

            if (mainUrlImage == "") throw new Exception("Lỗi không tìm lấy URL ảnh");

            var counterPage = webView.GetCounterPage() + 2;
            mainUrlImage = FormatUrlImage(mainUrlImage);

            string newUrlImage;
            for (var i = 1; i < counterPage; i++)
            {
                CheckCancel();
                progress.Report(new ProgressReport
                {
                    Exception = null,
                    Percent = 100 * i / counterPage,
                    Message = $"Đang xử lý {100 * i / counterPage}%..."
                });
                newUrlImage = mainUrlImage.Replace(AppConstants.TEXT_FORMAT_PAGE, $"{i}");

                // Tải xuống hình ảnh và lưu vào thư mục
                using (var client = new WebClient())
                {
                    var path = drectoryImagePath + $"\\i_{(i - 1).ToString("0000")}.png";
                    client.DownloadFile(newUrlImage, path);
                }
            }
        }

        public void Dispoes()
        {
            try
            {
                webView.Close();
            }
            catch
            {
            }
        }

        private string FormatUrlImage(string url)
        {
            var startIndex = url.IndexOf("?page=") + 6;

            var endIndex = url.IndexOf("&zoom");

            var subString = url.Substring(startIndex, endIndex - startIndex);

            return url.Replace($"?page={subString}", $"?page={AppConstants.TEXT_FORMAT_PAGE}");
        }
    }
}