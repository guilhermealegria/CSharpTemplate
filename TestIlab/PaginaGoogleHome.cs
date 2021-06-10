using OpenQA.Selenium;
using System;
using System.Threading;

namespace TestIlab
{
    public class PaginaGoogleHome : Chrome
    {


        internal void preencherCampoDePesquisa(string texto)
        {
            driver.FindElement(By.Name("q")).SendKeys(texto);
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        internal bool verificarResultadoDePesquisa(string texto)
        {
            string text = driver.FindElement(By.ClassName("yuRUbf"))
                .FindElement(By.TagName("a"))
                .FindElement(By.TagName("h3")).Text;
            if (text.Equals(texto))
            {
                return true;
            } else
            {
                return false;
            }
        }

        internal void esperarUmtEmpo()
        {
            Thread.Sleep(2000);
        }
    }
}