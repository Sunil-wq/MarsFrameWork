using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {

                SignIn InvLog = new SignIn();
                InvLog.InvalidLoginSteps();

            }
            [Test]
            public void Test1()
            {

                ProfileDesc details = new ProfileDesc();
                details.profiledata();

            }
            [Test]
            public void Test2()
            {
                               
                Skills mars = new Skills();
                mars.addskills();


            }
            [Test]
            public void Test3()
            {

                 ShareSkill adddetails = new ShareSkill();
                 adddetails.EnterShareSkill();

            }
            [Test]
            public void Test4()
            {

                 ManageListings manage = new ManageListings();
                 manage.Listings();
                 manage.UpdateListing();
                 manage.Delete();

            }

                       
            [Test]
            public void Test5()
            {

                 Search search1 = new Search();
                 search1.SearchData();

            }
            [Test]
            public void Test6()
            {

                manageRequest mrequest = new manageRequest();
                mrequest.Request();

            }
            [Test]
            public void SanityTest()
            {

                Skills mars = new Skills();
                mars.addskills();
                Thread.Sleep(5000);
                ManageListings manage = new ManageListings();
                manage.Listings();
                ShareSkill adddetails = new ShareSkill();
                adddetails.EnterShareSkill();
                Thread.Sleep(1000);
                Search search1 = new Search();
                search1.SearchData();

            }




        }
    }
}