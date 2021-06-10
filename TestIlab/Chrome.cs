using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestIlab
{
    public class Chrome
    {
        public IWebDriver driver;
        public IWebElement elemento;

        public void abrirChrome()
        {
            driver = new ChromeDriver("C:\\Users\\Qintess\\source\\repos\\TesteIlab\\TestIlab\\Driver\\");

        }

        public void navegarParaUrl(string txt)
        {
            driver.Navigate().GoToUrl(txt);
        }

        public void maximizarTela()
        {
            driver.Manage().Window.Maximize();
        }

        public void fecharNavegador()
        {
            driver.Quit();

        }

        public void capturaTela()
        {
            Screenshot imagem = ((ITakesScreenshot)driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\Qintess\\source\\repos\\TesteIlab\\TestIlab\\CapturaDeTela\\capturadetela.png", ScreenshotImageFormat.Png);
        }

        public IWebDriver getDriver()
        {
            return driver;
        }
    }
}