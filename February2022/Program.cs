using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace February2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch turn portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //identify username text box and valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //identify password and valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            //click a login button\
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            //check if user login successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hellohari.Text== "Hello hari!")
            {
                Console.WriteLine("LOGGED SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("not LOGGED SUCCESSFULLY");
            }
        }
    }
}
