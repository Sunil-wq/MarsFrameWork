using MarsFramework.Pages;
using NUnit.Framework;

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
               
                ShareSkill adddetails = new ShareSkill();
                 adddetails.EnterShareSkill();
               
                    
                                           
            }
            [Test]
            public void Test1()
            {
              
                ManageListings manage = new ManageListings();
                manage.Listings();
                manage.UpdateListing();
               

            }
            [Test]
            public void Test2()
            {
               
                ManageListings manage = new ManageListings();
                manage.Delete();
               

            }




        }
    }
}