using SeleNUnit.WebObjects.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleNUnit.DocFast.WebObjects.Pages.Dashboard
{
    public class Dashboard
    {


        #region Elements
        private static readonly WebElement AddNewPolicy = new WebElement().ByXPath("//a[contains(@href, 'javascript:PolicyCreate();')]");
        private static readonly WebElement UploadXMLBtn = new WebElement().ByXPath("a[contains(@href,'javascript:UploadXML();')]");
        private static readonly WebElement ReportsBtn = new WebElement().ByXPath("a[contains(@href,'//javascript:getSupplierReport();']");
        private static readonly WebElement ActivityDaysDropdown = new WebElement().ById("ActivityDaysDropdown");
        private static readonly WebElement SearchTextBox = new WebElement().ById("SearchTextBox");
        private static readonly WebElement SearchButton = new WebElement().ByXPath(".//*[@id='A3']/img");

        #endregion 


        public void SearchPolicy(string polNbr)
        {
            SearchTextBox.Clear();
            SearchTextBox.SendKeys(polNbr);
            SearchButton.Click();

        }

        public void AddNew()
        {
            AddNewPolicy.SendKeys("Enter");
            AddNewPolicy.Click(true);
          
        }

        public void Reports()
        {
            ReportsBtn.Click();

        }

        public void UploadXML()
        {
            UploadXMLBtn.Click();

        }

        public string polNbr { get; set; }

    }
}
