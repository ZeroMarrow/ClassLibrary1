using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        IWebDriver webDriver = new ChromeDriver();
        
        [TestCase] 
        public void maintTatle()
        {
            webDriver.Url = "https://www.e-katalog.ru/";
            Assert.AreEqual("e-Katalog - каталог товаров, сравнение цен в интернет-магазинах России", webDriver.Title);
            IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"ek-search\"]"));
            search.SendKeys("intel core i7");
            IWebElement button = webDriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/form/div[1]/div/div/div[3]/div/table/tbody/tr[1]"));
            button.Click();




            //Assert.AreEqual("Интернет-магазин компьютерных технологий | computeruniverse", webDriver.Title);
            //webDriver.Navigate().Refresh();

            //IWebElement search = webDriver.FindElement(By.XPath("//*[@id=\"search-input\"]"));
            //search.SendKeys("Intel core i7");
            //IWebElement button1 = webDriver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/div/div/div[1]"));
            //button1.Click();
            //IWebElement button = webDriver.FindElement(By.XPath("html/body/div[1]/div/header/div[1]/div/div[3]/form/div[2]"));
            //button.Click();
            //webDriver.Navigate().Refresh();
            //IWebElement button2 = webDriver.FindElement(By.XPath("/html/body/button"));
            //button2.Click();
        }
        // [TearDown]
        //public void testEnd()
        // {
        //    webDriver.Quit();
        // }
    }
}
