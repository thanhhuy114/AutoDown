using AutoDown.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutoDown.Utils
{
    public class WebView
    {
        public WebView(ChromeOptions options)
        {
            this.options = options;
        }

        private ChromeOptions options;
        private IWebDriver webDriver;

        public bool IsWebViewShow()
        {
            if (webDriver == null) return false;

            return true;
        }

        public bool IsWebViewShowSync()
        {
            if (webDriver == null) return false;

            try
            {
                // kiểm tra xem webview còn hoạt động không
                var a = webDriver.Url;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsValidUrl()
        {
            return (webDriver.Url.Contains(AppConstants.URL_VALID));
        }

        public bool CheckExistDocument()
        {
            ReadOnlyCollection<IWebElement> iframeElements = webDriver.FindElements(By.CssSelector("iframe[id='view']"));

            if (iframeElements.Count == 0) return false;

            if (!iframeElements[0].GetAttribute("src").Contains("https://media.cofer.edu.vn//viewer.html")) return false;

            return true;
        }

        public string GetDocumentTitle()
        {
            ReadOnlyCollection<IWebElement> iframeElements = webDriver.FindElements(By.CssSelector("div[class='title-khoahoc']"));

            if (iframeElements.Count == 0) return "";

            return iframeElements[0].Text;
        }

        public string GetURLDocument()
        {
            ReadOnlyCollection<IWebElement> iframeElements = webDriver.FindElements(By.CssSelector("iframe[id='view']"));

            return iframeElements[0].GetAttribute("src");
        }

        public string GetURLImage()
        {
            ReadOnlyCollection<IWebElement> imageElements = webDriver.FindElements(By.CssSelector("input[type='image']"));

            while (true)
            {
                imageElements = webDriver.FindElements(By.CssSelector("input[type='image']"));

                List<string> images = new List<string>();
                foreach (var imageElement in imageElements)
                {
                    string urlByElement = imageElement.GetAttribute("src");
                    if (!string.IsNullOrEmpty(urlByElement))
                        images.Add(urlByElement);

                    // chỉ cần tìm được 1 url rồi thay đổi số page là được
                    if (!string.IsNullOrEmpty(urlByElement) && urlByElement.Contains("?page"))
                    {
                        return urlByElement;
                    }
                }
            }
        }

        public int GetCounterPage()
        {
            string pageHtml = webDriver.PageSource;
            var listPage = webDriver.FindElements(By.XPath("//input[@class='docThumb docUnselectable']"));
            return listPage.Count;
        }

        public void Open(string url = null)
        {
            try
            {
                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                webDriver = new ChromeDriver(service, options);

                if (url == null)
                    webDriver.Navigate().GoToUrl(AppConstants.URL_PAGE_LOGIN);
                else
                    webDriver.Navigate().GoToUrl(url);
            }
            catch (Exception)
            {
                //webDriver.Navigate().GoToUrl("https://google.com/");
            }
        }

        public void Close()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
                webDriver = null;
            }
        }


        public void HandleUI(string studentID = null, string password = null)
        {
            try
            {
                IWebElement username = webDriver.FindElement(By.CssSelector("#UserName"));
                IWebElement passwordForm = webDriver.FindElement(By.CssSelector("#Password"));
                IWebElement title = webDriver.FindElement(By.XPath("//h4[@lang='loginnews-pagetitle']"));
                IWebElement button = webDriver.FindElement(By.XPath("//input[@class='button']"));
                IWebElement image = webDriver.FindElement(By.CssSelector("div.text-center > img"));
                IWebElement wobbly = webDriver.FindElement(By.XPath("//div[@class='col-lg-9 col-md-8']"));
                IWebElement header = webDriver.FindElement(By.XPath("//header"));
                IWebElement downloadArea = webDriver.FindElement(By.XPath("//div[@class='box-download-app']"));
                IWebElement formLogin = webDriver.FindElement(By.ClassName("col-lg-3"));
                IWebElement forParents = webDriver.FindElement(By.ClassName("form-footer"));
                IWebElement buttonLogInWithMicrosoft = webDriver.FindElement(By.ClassName("login-with-microsoft-btn"));

                if (studentID.Trim() != String.Empty)
                    username.SendKeys(studentID.Trim());

                if (password.Trim() != String.Empty)
                    passwordForm.SendKeys(password.Trim());


                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].innerText = 'Welcome AutoDown';", title);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].value = 'Đăng nhập';", button);
                //((IJavaScriptExecutor)webDriver).ExecuteScript($"arguments[0].src = '{AppConstants.URL_AVATA_DEFAULT}';", image);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", wobbly);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", forParents);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", buttonLogInWithMicrosoft);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", header);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].remove();", downloadArea);
                ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].style.margin = '0 auto';", formLogin);
                //((IJavaScriptExecutor)webDriver).ExecuteScript("Console.log(\"huy\")", webElement);

                //in ra html của element
                //webElement.GetAttribute("outerHTML")
            }
            catch (Exception)
            {
                //Invoke((Action)(() => MessageBox.Show(e.ToString())));
            }
        }
    }
}
