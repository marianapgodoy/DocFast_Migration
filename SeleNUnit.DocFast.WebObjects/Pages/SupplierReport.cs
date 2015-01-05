using SeleNUnit.WebObjects.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleNUnit.DocFast.Suites.Pages
{
    class SupplierReport
    {

        #region Elements
        private static readonly WebElement ReportsList = new WebElement().ById("ReportsList");
        private static readonly WebElement GetResults = new WebElement().ById("hrefGetResults");
        private static readonly WebElement StartDate = new WebElement().ById("param_StartDate");
        private static readonly WebElement EndDate = new WebElement().ById("param_EndDate");
        private static readonly WebElement DatepickerCalendar = new WebElement().ById("ui-datepicker-calendar");

        #endregion
    }
}
