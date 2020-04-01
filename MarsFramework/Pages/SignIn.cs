using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Owner\source\repos\marsframework-master\MarsFramework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", "SignIn");
            //Click on Join button
            Assert.IsTrue(SignIntab.Enabled);
            SignIntab.Click();
           
            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter LastName
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

           // Thread.Sleep(2000);
            //Click on Login
            LoginBtn.Click();
        }
        internal void InvalidLoginSteps()
        {
           
            GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[2]/button")).Click();
            //Click on Join button
            GlobalDefinitions.wait(20);
            Assert.IsTrue(SignIntab.Enabled);
            SignIntab.Click();
            GlobalDefinitions.wait(50);
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\Owner\source\repos\marsframework-master\MarsFramework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", "SignIn");
            //Enter Email
             Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Username"));

            //Enter LastName
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Password"));

            // Thread.Sleep(2000);
            //Click on Login
            LoginBtn.Click();
            IWebElement Submitbtn = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='submit-btn']"));
            Assert.IsTrue(Submitbtn.Enabled);
        }
    }
}