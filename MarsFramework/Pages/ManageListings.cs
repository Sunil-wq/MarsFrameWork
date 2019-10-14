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
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[1]")]
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
            view.Click();
            servicemanageListingsLink.Click();



        }
        internal void UpdateListing()
        {
            Thread.Sleep(2000);
            edit.Click();
        }
        internal void Delete()
        {
           // Populate the Excel Sheet
             GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            GlobalDefinitions.wait(2000);
            manageListingsLink.Click();
            GlobalDefinitions.wait(2000);
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        IWebElement code = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]"));


                        if (code.Text == "Selenium")
                        {

                            Thread.Sleep(5000);
                            delete.Click();
                            Thread.Sleep(5000);
                            clickActionsButton.Click();
                            return;
                        }
                    }

                    GlobalDefinitions.wait(2000);
                    GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[10]")).Click();


                }
            }
            catch (Exception)
            {
                Console.WriteLine("not found");
            }
           
           
           
        }
    }
}
