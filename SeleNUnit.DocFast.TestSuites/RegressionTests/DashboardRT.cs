using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleNUnit.ContentRD.TestSuites;
using SeleNUnit.DocFast.WebObjects.Pages.Dashboard;
using System.Data;
using SeleNUnit.DocFast.WebObjects.Pages;
using SeleNUnit.DocFast.Suites.Pages;


namespace SeleNUnit.DocFast.TestSuites.RegressionTests
{
    [TestClass]
    public class DashboardRT:SuiteBase
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        public struct Policy
        {
            public string Server;
            public string Browser;
            public string Flow;
            public string DistributorRole;
            public string AgentRole;
            public string Product;
            public bool AnnualPremium;
            public bool ESV;
            public bool CCQ;
            public bool CQ;
            public bool Additional;
            public bool PrivateAttachment;
            public bool NewAgent;
            public bool PIEmail;
            public string SaveOrSend;
            public string Actor;
            public string Action;
            public string Supplier;
            public string DistributorID;
            public string DCMID;
            public string AgentID;
            public string AgentSearch;
            public string Carrier;
            public string Distributor;
            public string Agent;

        }
        Policy newPol = new Policy();

        /// <summary>
        /// Objective:
        /// Author/Updated By: 
        /// Date:12/2014
        /// Tags: Regression
        /// </summary>
        [TestMethod]
        [DataSource("Regression")]
        public void Regression_CDAC()
        {
            #region TestData
            newPol.Server = Convert.ToString(TestContext.DataRow["Server"]);
            newPol.Browser = Convert.ToString(TestContext.DataRow["Browser"]);
            newPol.Flow = Convert.ToString(TestContext.DataRow["Flow"]);
            newPol.DistributorRole = Convert.ToString(TestContext.DataRow["Distributor Role"]);
            newPol.AgentRole = Convert.ToString(TestContext.DataRow["Agent Role"]);
            newPol.Product = Convert.ToString(TestContext.DataRow["Product"]);
            newPol.AnnualPremium = Convert.ToBoolean(TestContext.DataRow["Annual Premium"]);
            newPol.ESV = Convert.ToBoolean(TestContext.DataRow["ESV"]);
            newPol.CCQ = Convert.ToBoolean(TestContext.DataRow["CCQ"]);
            newPol.CQ = Convert.ToBoolean(TestContext.DataRow["CQ"]);
            newPol.Additional = Convert.ToBoolean(TestContext.DataRow["Additional"]);
            newPol.PrivateAttachment = Convert.ToBoolean(TestContext.DataRow["PA"]);
            newPol.NewAgent = Convert.ToBoolean(TestContext.DataRow["New Agent"]);
            newPol.PIEmail = Convert.ToBoolean(TestContext.DataRow["PI Email"]);
            newPol.SaveOrSend = Convert.ToString(TestContext.DataRow["SaveOrSend"]);
            newPol.Actor = Convert.ToString(TestContext.DataRow["Actor"]);
            newPol.Action = Convert.ToString(TestContext.DataRow["Action"]);
            newPol.Supplier = Convert.ToString(TestContext.DataRow["Supplier"]);
            newPol.DistributorID = Convert.ToString(TestContext.DataRow["DistributorID"]);
            newPol.DCMID = Convert.ToString(TestContext.DataRow["DCMID"]);
            newPol.AgentID = Convert.ToString(TestContext.DataRow["AgentID"]);
            newPol.AgentSearch = Convert.ToString(TestContext.DataRow["AgentSearch"]);
            newPol.Carrier = Convert.ToString(TestContext.DataRow["Carrier"]);

             //string userName = newPol.Carrier;
             string password = "12345678";
             string urlParams = "";
             string currentUser = "Carrier";
            
            #endregion TestData



            #region TestSteps
            new RSALogin().DoLogin(urlParams, newPol.Carrier, password);
            Dashboard dashboardPage = new Dashboard(); 
            CreatePolicy createPolicy=new CreatePolicy();

            if (newPol.Flow == "CDAC") 
            {
                if (currentUser == "Carrier")
                {

                    dashboardPage.AddNew();
                    createPolicy.SetProductType(newPol.Product);
                    createPolicy.SetIdentificationNumber();
                    createPolicy.SetAnnualPremium(newPol.AnnualPremium);
                    createPolicy.SetDeliveryExpirationDate();
                    createPolicy.UploadDocument(newPol.Supplier);
                    createPolicy.SelectTemplate("Policy Template");//I added it ***Ask Teresita
                    if (newPol.ESV)
                    {
                        createPolicy.CheckEnforceSignerVisibility();
                    }
                    else {
                        createPolicy.UncheckEnforceSignerVisibility();
                    }

                    createPolicy.SetFirstAndLastName(newPol.CCQ);
                    createPolicy.CheckConsumerQuizQuestionSupplierNONStandard(newPol.CCQ, newPol.Supplier);
                    createPolicy.CheckConsumerQuizQuestionSupplierStandard(newPol.CCQ, newPol.Supplier);
                    createPolicy.AddNewConsumerSigners(newPol.Additional);
                    createPolicy.SetPrivateAttachment(newPol.CCQ, newPol.Server);
                    createPolicy.SetPrivateDocumentType("Inspection Report - Personal");
                    createPolicy.SetDistributor("Toner Organization, A Bisys Company");//(newPol.DistributorID);
                    createPolicy.SetDistributorCaseManager("Default Case Manager");//(newPol.DistributorID);
                    createPolicy.SetDistributorsRole(newPol.DistributorRole);
                    createPolicy.SetAgent(newPol.AgentID,newPol.AgentSearch);
                    createPolicy.SetAgentPolicyRole(newPol.AgentRole);
                    createPolicy.SetConsumerEmail();
                    if (newPol.SaveOrSend == "Send"){ createPolicy.SendPolicy();}
                    else { createPolicy.SaveAsIncomplete(); }
                }
            }

           

        

            #endregion TestSteps

            #region Assertions
            #endregion Assertions


        }
    }
}
