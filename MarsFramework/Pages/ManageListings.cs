using java.sql;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement manageListingsLink { get; set; }

        //Click on Service Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/section[1]/div/a[3]")]
        private IWebElement servicemanageListingsLink { get; set; }

        //View the listing
       // [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[1]")]
       // private IWebElement view { get; set; }
        
        //View the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@class='remove icon']")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement clickActionsButton { get; set; }

        internal void Listings()
        {

            GlobalDefinitions.wait(2000);
            manageListingsLink.Click();
            Thread.Sleep(2000);
            while (true)
            {
                for (int i = 1; i < 5; i++)
                {
                    IWebElement ela = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                    String Eleme = ela.Text;
                    if (Eleme == "Java")
                    {
                        GlobalDefinitions.wait(2000);
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[1]/i")).Click();
                        servicemanageListingsLink.Click();
                        return;
                    }


                }
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[2]/button[10]")).Click();
            }
            
           



        }
        internal void UpdateListing()
        {
            GlobalDefinitions.wait(2000);
            while (true)
            {
                for (int i = 1; i < 5; i++)
                {
                    IWebElement ela = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                    String Eleme = ela.Text;
                    if (Eleme == "Java")
                    {
                        Thread.Sleep(2000);
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[2]/i")).Click();
                        ShareSkill updte = new ShareSkill();
                        updte.EditShareSkill();
                        return;
                    }
                }
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[2]/button[10]")).Click();

            }
            }
        internal void Delete()
        {
           // Populate the Excel Sheet
            // GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            GlobalDefinitions.wait(2000);
            manageListingsLink.Click();
            GlobalDefinitions.wait(2000);
            while (true)
            {
                for (int i = 1; i < 5; i++)
                {
                    IWebElement ela = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                    String Eleme = ela.Text;
                    
                    if (Eleme == "Selenium")
                    {
                        GlobalDefinitions.wait(2000);
                        GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[" + i + "]/td[8]/div/button[3]/i")).Click();
                        Thread.Sleep(2000);
                        foreach (string handle in GlobalDefinitions.driver.WindowHandles)
                        {
                            IWebDriver popup = GlobalDefinitions.driver.SwitchTo().Window(handle);
                            if (popup.Title.Contains("Delete Your Service"))
                            {
                                break;
                            }
                        }
                        IWebElement closebutton = GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
                        closebutton.Click();
                        return;
                    }


                }
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[2]/button[10]")).Click();
            }



        }
    }
}
