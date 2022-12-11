using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeachAwayMenu
{
    [TestClass]
    public class Login
    {

        [TestMethod]
        public void LogInTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.teachaway.com");
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            var login = driver.FindElement(By.Id("login"));
            login.Click();

            var username = driver.FindElement(By.Id("username"));
            var password = driver.FindElement(By.Id("password"));

            //username input
            username.Clear();
            username.Click();
            username.SendKeys("elmaxhelo21@gmail.com");

            //password input
            password.Clear();
            password.Click();
            password.SendKeys("Elma1234");

            //Clicking of the LogIn button
            driver.FindElement(By.Id("login_action")).Click(); 
           
            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}
