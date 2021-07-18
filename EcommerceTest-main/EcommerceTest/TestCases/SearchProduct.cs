using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceTest.PageObjectsBasic;

namespace EcommerceTest.TestCases
{
    [TestFixture]
    public class SearchProduct
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeAll()
        {
            Driver = new ChromeDriver();


        }
        [Test]
        public void SearchElement()
        {
            PO_Basic po_basic = new PO_Basic(Driver);
            po_basic.GoToHomePage();
            po_basic.Login("test1@testingyes.com", "test12345");
            po_basic.SearchElement("short");
            po_basic.LogOut();


        }

        [TearDown]
        public void AfterAll()
        {
            Driver.Close();
        }
    }
}

