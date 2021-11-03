using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tools.Automation.Framework.Core;
using Tools.Automation.Framework.Drivers;
using Tools.Automation.Framework.Searcher;
using Tools.Automation.Framework.Waits;
using AILogistic.Test.PageObjects;
using System.Threading;
using NUnit.Framework;

namespace AILogistic.Test
{
    [Binding]
    public class OrderCRUDSteps : TestCore
    {
        ElementSearcher objElementSearcher;

        [Given(@"I Navigate to Order Page")]
        public void GivenINavigateToOrderPage()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            Menubar objMenu = new Menubar(objElementSearcher);
            objMenu.GetMenuItem("Administration").Click();
            objMenu.GetSubMenuItem("Manage Orders").Click();
        }

        [Given(@"I Click Add New Button")]
        public void GivenIClickAddNewButton()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            WaitForStringPresent.DoWait("Add New");
            Thread.Sleep(2000);
            objElementSearcher.FindElementById("btnCreateOrder").Click();
        }
        [Then(@"I Enter Order Details")]
        public void ThenIEnterOrderDetails()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            //Order
            objElementSearcher.FindSelectBoxById("ddlOrderType").SelectByText("Delivery");
            objElementSearcher.FindSelectBoxById("ddlOrderStatus").SelectByText("Booked");
            //Retailer
            objElementSearcher.FindAutoCompleteBoxById("ddlRetailer", "Best Buy");
            objElementSearcher.FindAutoCompleteBoxById("ddlSaleStore", "Test Yard");
            objElementSearcher.FindElementById("txtInvoiceNumber").SendKeys("INV0001234");
            //Orgin
            objElementSearcher.FindAutoCompleteBoxById("ddlOriginType", "Yard");
            objElementSearcher.DateSelectById("dtpPickupDate","19-Sep-2018");
            objElementSearcher.FindAutoCompleteBoxById("ddlCountryO", "US");
            objElementSearcher.FindAutoCompleteBoxById("ddlProvinceO", "Alask");
            objElementSearcher.FindAutoCompleteBoxById("ddlCityO", "Ada");
            objElementSearcher.FindElementById("txtPostalCodeO").SendKeys("22222");
            objElementSearcher.FindElementById("txtAddress1O").SendKeys("Address");
            objElementSearcher.FindElementById("txtFirstNameO").SendKeys("Ravi");
            objElementSearcher.FindElementById("txtLastNameO").SendKeys("Chennai");

            //Destination
            objElementSearcher.FindAutoCompleteBoxById("ddlDestType", "Store");
            objElementSearcher.DateSelectById("dtpDeliveryDate", "19-Sep-2018");
            objElementSearcher.FindAutoCompleteBoxById("ddlLocationD", "Test");
       }

        [Then(@"I Add Product Detail")]
        public void ThenIAddProductDetail()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            objElementSearcher.FindElementLinkText("Add Product").Click();
            WaitForStringPresent.DoWait("Remove");
            objElementSearcher.FindSelectBoxById("ddlTask").SelectByText("Service");
            objElementSearcher.FindAutoCompleteBoxById("ddlProduct", "W/G LOCAL DELIVERY");
        }

        [Then(@"I Click Save Order")]
        public void ThenIClickSaveOrder()
        {
            objElementSearcher = new ElementSearcher(DriverFactory.Instance);
            objElementSearcher.FindElementById("btnSave").Click();
            Assert.AreEqual("", "");
        }

    }
}
