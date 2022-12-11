using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;

namespace TeachAwayMenu
{
    [TestClass]
    public class SignUp
    {

        [TestMethod]
        public void SignUpTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.teachaway.com");

            //Register button 
            var register = driver.FindElement(By.Id("register"));
            register.Click();

            //send data in form
            var firstName = driver.FindElement(By.Id("first_name"));
            firstName.SendKeys("Elma");

            driver.FindElement(By.Id("last_name")).SendKeys("Xhelo");
            driver.FindElement(By.Id("email")).SendKeys("elm1wqedsa@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Elma1234");

            //SignUp button
            var SignUp = driver.FindElement(By.Id("create_account_action"));
            SignUp.Click();

            //Alert message result
            string AlertMessage = "Your account was created successfully!";
            var actual_Result = driver.FindElements(By.CssSelector("[data-test-id: \"ta-web-ui-input-email-error\"]"));
            
            if(actual_Result != null){
                AlertMessage = "Your profile is register before!";
                Console.WriteLine("Alert text is " + AlertMessage);
            }
            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(AlertMessage, alert_win);
            alert_win.Accept();


            //Profile complete form
            var triagle = driver.FindElement(By.ClassName("ta-web-ui-input-dropdown__list"));
            //triagle.Click();
            var selectTriagle = new SelectElement(triagle);
            selectTriagle.SelectByText("College/University Faculty");

            //firstButton
            driver.FindElement(By.CssSelector("[aria-label = No button]")).Click();
            //secondButton
            driver.FindElement(By.CssSelector("[aria-label = No button]")).Click();

            driver.FindElement(By.Id("get-started")).Click();


            //Preferences form 
            driver.FindElement(By.CssSelector("No button")).Click();
            driver.FindElement(By.CssSelector("No button")).Click();
            driver.FindElement(By.CssSelector("No button")).Click();
            driver.FindElement(By.CssSelector("No button")).Click();

            //next button
            driver.FindElement(By.Id("next-to-about")).Click();


            //Personal information form
            var country = driver.FindElement(By.Id("select-triangle"));
            var selectcountry = new SelectElement(country);
            selectcountry.SelectByText("Albania");

            var State = driver.FindElement(By.ClassName("ta-web-ui-input-dropdown__option-label"));
            var selectState = new SelectElement(State);
            selectState.SelectByText("Tirana County");

            var Citizenship = driver.FindElement(By.Id("citizenship"));
            var selectCitizenship = new SelectElement(Citizenship);
            selectCitizenship.SelectByText("Albania");

            var Fluentlanguages = driver.FindElement(By.Id("languages"));
            var selectFluentlanguages = new SelectElement(Fluentlanguages);
            selectFluentlanguages.SelectByText("Albania");

            var month = driver.FindElement(By.Id("monthOfBirth-selected"));
            var selectmonth = new SelectElement(month);
            selectmonth.SelectByText("Aug");

            var date = driver.FindElement(By.Id("dayOfBirth"));
            var selectdate = new SelectElement(date);
            selectdate.SelectByText("21");

            var year = driver.FindElement(By.Id("yearOfBirth"));
            var selectyear = new SelectElement(year);
            selectyear.SelectByText("2001");

            var Countrycode = driver.FindElement(By.Id("country code"));
            var selectCountrycode = new SelectElement(Countrycode);
            selectCountrycode.SelectByText("select option AL +355");

            var phone = driver.FindElement(By.Id("phoneNumber"));
            var selectphone = new SelectElement(phone);
            selectphone.SelectByText("694400111");

            driver.FindElement(By.Id("next-step")).Click();


            //EducationForm
            driver.FindElement(By.Id("noEducation")).Click();
            driver.FindElement(By.Id("next - step")).Click();


            //lastForm
            driver.FindElement(By.Id("checkbox - no - experience")).Click();
            driver.FindElement(By.Id("complete-next")).Click();

            driver.FindElement(By.Id("last - registration - modal")).Click();
            driver.FindElement(By.Id("close")).Click();

            driver.Dispose();
        }


    }
}
