using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceTest.PageObjectsBasic;

//finish this test case tomorrow
namespace EcommerceTest.TestCases
{
    [TestFixture]
    public class HappyPathTest
    {
      protected IWebDriver Driver;

        [SetUp]
        public void BeforeAll()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void HappyTestCase()
        {
            PO_Basic po_basic = new PO_Basic(Driver);
            po_basic.GoToHomePage();
            po_basic.Login("test1@testingyes.com", "test12345");
            po_basic.AddElementsToCart("3");
            po_basic.LogOut();

        }

        [TearDown]
        public void AfterAll()
        {
            Driver.Close();
        }


    }
}





