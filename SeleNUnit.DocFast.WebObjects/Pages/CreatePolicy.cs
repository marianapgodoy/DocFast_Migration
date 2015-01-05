using SeleNUnit.WebObjects.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleNUnit.DocFast.TestSuites
{
    public class CreatePolicy
    {


        #region Elements
        private static readonly WebElement productType = new WebElement().ById("ProductTypeDropDown");
        private static readonly WebElement IdentificationNumber = new WebElement().ById("PolicyNumber");
        private static readonly WebElement AnnualPremium = new WebElement().ById("AnnualPremium");
        private static readonly WebElement DeliveryExpirationDate = new WebElement().ById("DeliveryDate");
        private static readonly WebElement DatePickerCalendar = new WebElement().ByClass("ui-datepicker-calendar");
        private static readonly WebElement DatePickerCalendarToday = new WebElement().ByXPath("//a[contains(@class,'ui-state-default ui-state-highlight')]");

        private static readonly WebElement uploadDocumentMulti = new WebElement().ById("uploadDocumentMulti");
        private static readonly WebElement UploadDocumentSelectTemplate = new WebElement().ByXPath("//select[contains(@id,'_pdf_Template')]");
        private static readonly WebElement EnforceSignerVisibility = new WebElement().ById("EnforceSignerVisibilityCheckBox");
        private static readonly WebElement FirstName = new WebElement().ById("FirstName");
        private static readonly WebElement LastName = new WebElement().ById("LastName");
        private static readonly WebElement ConsumerConfirmationQuiz = new WebElement().ById("DocuSignIDCheckCheckBox");
        private static readonly WebElement BusinessEntityOwner = new WebElement().ById("BusinessEntityOwnerCheckBox");
        private static readonly WebElement BusinessEntityName = new WebElement().ById("BusinessEntityName");
        private static readonly WebElement AddressLine1 = new WebElement().ById("AddressLine1");
        private static readonly WebElement AddressLine2 = new WebElement().ById("AddressLine2");
        private static readonly WebElement City = new WebElement().ById("City");
        private static readonly WebElement StateDropDown = new WebElement().ById("StateDropDown");
        private static readonly WebElement Zip = new WebElement().ById("Zip");
        private static readonly WebElement btnAddNewQuizQuestion = new WebElement().ById("btnAddNewQuizQuestion");
        private static readonly WebElement chkConsumerQuizQuestion_1 = new WebElement().ById("chkConsumerQuizQuestion_1");
        private static readonly WebElement chkConsumerQuizQuestion_2 = new WebElement().ById("chkConsumerQuizQuestion_2");
        private static readonly WebElement chkConsumerQuizQuestion_3 = new WebElement().ById("chkConsumerQuizQuestion_3");
        private static readonly WebElement chkConsumerQuizQuestion_4 = new WebElement().ById("chkConsumerQuizQuestion_4");
        private static readonly WebElement txtConsumerQuizAnswerChoiceText_1 = new WebElement().ById("txtConsumerQuizAnswerChoiceText_1");
        private static readonly WebElement txtConsumerQuizAnswerChoiceText_2 = new WebElement().ById("txtConsumerQuizAnswerChoiceText_2");
        private static readonly WebElement txtConsumerQuizAnswerChoiceText_3 = new WebElement().ById("txtConsumerQuizAnswerChoiceText_3");
        private static readonly WebElement txtConsumerQuizAnswerChoiceText_4 = new WebElement().ById("txtConsumerQuizAnswerChoiceText_4");
        private static readonly WebElement AddNewConsumer = new WebElement().ById("AddNewConsumerLinkAboveTable");
        private static readonly WebElement UploadPrivateDocumentMulti = new WebElement().ById("uploadPrivateDocumentMulti");
        private static readonly WebElement DistributorCheckBox = new WebElement().ById("DistributorCheckBox");
        private static readonly WebElement DistributorDropDown = new WebElement().ById("DistributorDropDown");
        private static readonly WebElement CaseManagerID = new WebElement().ById("CaseManagerID");
        private static readonly WebElement DistributorPolicyRole = new WebElement().ById("distributorPolicyRole");
        private static readonly WebElement AgentCheckBox = new WebElement().ById("AgentCheckBox");
        private static readonly WebElement AgentName = new WebElement().ById("AgentName");
        private static readonly WebElement FindAgent = new WebElement().ById("find-agent");
        private static readonly WebElement AgentPolicyRole = new WebElement().ById("agentPolicyRole");
        private static readonly WebElement ConsumerEmail = new WebElement().ById("ConsumerEmail");
        private static readonly WebElement SendBtn = new WebElement().ById("add-policy-btn");
        private static readonly WebElement SaveAsIncompleteBtn = new WebElement().ById("btnSaveAsIncomplete");
        private static readonly WebElement CancelBtn = new WebElement().ByXPath("\\a[@href='/Policy/Dashboard/cancelActionLink']");
        private static readonly WebElement GoToDashboardLink = new WebElement().ById("GoToDashboardLink");
        private static readonly WebElement NewConsumerFirstName = new WebElement().ById("NewConsumerFirstName");
        private static readonly WebElement NewConsumerLastName = new WebElement().ById("NewConsumerLastName");
        private static readonly WebElement NewConsumerBusinessEntityOwnerCheckBox = new WebElement().ById("NewConsumerBusinessEntityOwnerCheckBox");
        private static readonly WebElement NewConsumerAddress1 = new WebElement().ById("NewConsumerAddress1");
        private static readonly WebElement NewConsumerEmail = new WebElement().ById("NewConsumerEmail");
        private static readonly WebElement NewConsumerAddress2 = new WebElement().ById("NewConsumerAddress2");
        private static readonly WebElement NewConsumerCity = new WebElement().ById("NewConsumerCity");
        private static readonly WebElement NewConsumerState = new WebElement().ById("NewConsumerState");
        private static readonly WebElement NewConsumerZip = new WebElement().ById("NewConsumerZip");
        private static readonly WebElement NewConsumerBusinessEntityName = new WebElement().ById("NewConsumerBusinessEntityName");
        private static readonly WebElement txtConsumerQuizAnswerChoiceTextA_1 = new WebElement().ById("txtConsumerQuizAnswerChoiceTextA_1");
        private static readonly WebElement txtConsumerQuizAnswerChoiceTextA_2 = new WebElement().ById("txtConsumerQuizAnswerChoiceTextA_2");
        private static readonly WebElement txtConsumerQuizAnswerChoiceTextA_3 = new WebElement().ById("txtConsumerQuizAnswerChoiceTextA_3");
        private static readonly WebElement txtConsumerQuizAnswerChoiceTextA_4 = new WebElement().ById("txtConsumerQuizAnswerChoiceTextA_4");
        private static readonly WebElement chkConsumerQuizQuestionA_1 = new WebElement().ById("chkConsumerQuizQuestionA_1");
        private static readonly WebElement chkConsumerQuizQuestionA_2 = new WebElement().ById("chkConsumerQuizQuestionA_2");
        private static readonly WebElement chkConsumerQuizQuestionA_3 = new WebElement().ById("chkConsumerQuizQuestionA_3");
        private static readonly WebElement chkConsumerQuizQuestionA_4 = new WebElement().ById("chkConsumerQuizQuestionA_4");
        private static readonly WebElement btnSave = new WebElement().ById("btnSave");
        private static readonly WebElement A1 = new WebElement().ById("A1");
        
        private static readonly WebElement TemplateRolesDropDown = new WebElement().ById("TemplateRolesDropDown0");
        private static readonly WebElement PrivateDocumentRecipientList = new WebElement().ByXPath("//select[contains(@id,'RecipientListCombo')]");
        private static readonly WebElement PrivateDocumentDocumentType = new WebElement().ByXPath("//select[contains(@id,'_pdf_DocumentTypeCombo')]");
        private static readonly WebElement AgentSearchFirstName = new WebElement().ById("AgentSearchFirstName");
        private static readonly WebElement AgentSearchLastName = new WebElement().ById("AgentSearchLastName");
        private static readonly WebElement AgentSearchEmail = new WebElement().ById("AgentSearchEmail");
        private static readonly WebElement AgentSearchButton = new WebElement().ById("AgentSearchButton");
        private static readonly WebElement AddNewAgent = new WebElement().ById("AddNewAgent");
        private static readonly WebElement SelectAgent = new WebElement().ById("SelectAgent");
        private static readonly WebElement AgentSearchCancel = new WebElement().ById("AgentSearchCancel");
        private static readonly WebElement AgentSearchList = new WebElement().ByClass("divAgentList");
        private static readonly WebElement NewAgentFirstName = new WebElement().ById("NewAgentFirstName");
        private static readonly WebElement NewAgentLastName = new WebElement().ById("NewAgentLastName");
        private static readonly WebElement NewAgentEmail = new WebElement().ById("NewAgentEmail");
        private static readonly WebElement SaveNewAgent = new WebElement().ById("SaveNewAgent");
        private static readonly WebElement CancelAddNewAgent = new WebElement().ById("CancelAddNewAgent");
        

        #endregion


        public void SetProductType(string type)
        {
            productType.SelectByText(type);
        }

        public void SetIdentificationNumber()
        {
            var polNbr = DateTime.Now.ToString();
            polNbr = polNbr.Replace(":", "_");
            IdentificationNumber.SendKeys(polNbr);
        }


        public void SetAnnualPremium(bool annualPremium)
        {
            if (annualPremium)
            {
                AnnualPremium.SendKeys("1234");
            }
        }

        public void SetDeliveryExpirationDate()
        {
            DeliveryExpirationDate.SendKeys("Enter");
            DatePickerCalendarToday.Click();
        }

        public void UploadDocument(string supplier)
        {
            if (supplier == "Lincoln")
            {
                uploadDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PDF_LocationLincoln);

            }
            else if (supplier == "Standard")
            {
                uploadDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PDF_LocationStd);

            }

            else
            {
                uploadDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PDF_LocationTest);
            }
        }

        public void SelectTemplate(string templateName)
        {
            UploadDocumentSelectTemplate.SelectByText(templateName);
        
        }

        public void CheckEnforceSignerVisibility()
        {
                if (!EnforceSignerVisibility.Selected)
                {
                    EnforceSignerVisibility.Click();
                }
                
            uploadDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PDFEsv_Location);
            
        }

        public void UncheckEnforceSignerVisibility()
        {
            
                if (EnforceSignerVisibility.Selected)
                {
                    EnforceSignerVisibility.Click();
                }
        }



        public void SetFirstAndLastName(bool ccq)
        {
            if (ccq)
            {
                FirstName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_FN);
                LastName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_LN); 

            }
            else // DocuSign ID Check
            {
                FirstName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_FN);
                LastName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_LN); 
            }
        }


        public void CheckConsumerQuizQuestionSupplierStandard(bool ccq, string supplier)
        {
            if (!ccq && supplier.Contains("Standard"))
            {
                chkConsumerQuizQuestion_1.Click();
                txtConsumerQuizAnswerChoiceText_1.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.SSN);

            }
        }


        public void CheckConsumerQuizQuestionSupplierNONStandard(bool ccq, string supplier)
        {
            if (!ccq && !supplier.Contains("Standard"))
            {
                if (chkConsumerQuizQuestion_1.Selected)
                {
                    chkConsumerQuizQuestion_1.Click();
                }
                if (DateTime.Now.Minute % 2 == 0)
                {
                    chkConsumerQuizQuestion_3.Click();
                    txtConsumerQuizAnswerChoiceText_3.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_LN);
                }
                else if (DateTime.Now.Minute % 3 == 0)
                {
                    chkConsumerQuizQuestion_2.Click();
                    txtConsumerQuizAnswerChoiceText_2.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.Birth_Date);
                }
                else
                {
                    chkConsumerQuizQuestion_1.Click();
                    txtConsumerQuizAnswerChoiceText_1.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.SSN);
                }
            } if (ccq)
            {
                ConsumerConfirmationQuiz.Click();

                AddressLine1.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PI_AddressLine1);

                City.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PI_City);

                StateDropDown.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.PI_State);

                Zip.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PI_Zip);

                chkConsumerQuizQuestion_1.Click();

            }
        }


        public void AddNewConsumerSigners(bool additional)
        {
            if (additional)
            {
                AddNewConsumer.Click();
                NewConsumerFirstName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_FN);
                NewConsumerLastName.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.CDAC_Add_LN);
                NewConsumerEmail.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.Consumer_Email);
                txtConsumerQuizAnswerChoiceTextA_1.SendKeys("1234");
                btnSave.Click();
            }

        }

        public void SetTemplateRole()
        {
            TemplateRolesDropDown.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.Template_Add_Role);
        }


        public void SetPrivateAttachment(bool ccq, string server)
        {

            if (server == "QA")
            {
                UploadPrivateDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PA_Location);

                if (!ccq)
                {
                    PrivateDocumentRecipientList.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_FN + " " + SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_LN);
                }
                else
                {
                    PrivateDocumentRecipientList.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_FN + " " + SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_LN);
                }

                if (DateTime.Now.Minute % 2 == 0)
                {
                    PrivateDocumentRecipientList.Select(1);
                }
                else if (DateTime.Now.Minute % 3 == 0)
                {
                    PrivateDocumentRecipientList.Select(2);
                }
                else
                {
                    PrivateDocumentRecipientList.Select(3);
                }
            }
            else
            {
                UploadPrivateDocumentMulti.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.PA_Location);

                if (ccq)//originally it was like !ccq ******IMPORTANT!!!
                {
                    PrivateDocumentRecipientList.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_FN + " " + SeleNUnit.DocFast.WebObjects.Resource.CDAC_PI_LN);
                }
                //else
                //{
                //    PrivateDocumentRecipientList.SelectByText(SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_FN + " " + SeleNUnit.DocFast.WebObjects.Resource.PI_IDCheck_LN);
                //}

                //PrivateDocumentRecipientList.Select(0);
            }
        }


        public void SetPrivateDocumentType(string documentType)
        {
            PrivateDocumentDocumentType.SelectByText(documentType);
        
        }


        public void SetDistributor(string distributorID)
        {
            DistributorCheckBox.Click();
            if (!DistributorDropDown.Enabled)
            {
                DistributorCheckBox.Click();
               
                if (DistributorDropDown.Enabled)
                {
                    DistributorDropDown.SelectByText(distributorID);
                }
            }
        }


        public void SetDistributorCaseManager(string distributorID)
        {
            CaseManagerID.SelectByText(distributorID);

        }


        public void SetDistributorsRole(string distributorRole)
        {


            if (distributorRole == "App")
            {
                DistributorPolicyRole.SelectByText("Approver");
                
            }

            else if (distributorRole == "CC")
            {
                DistributorPolicyRole.SelectByText("Carbon Copy");
               
            }
            else if (distributorRole == "CCRO")
            {
                DistributorPolicyRole.SelectByText("Carbon Copy (Read Only)");
               
               
            }

        }

        public void SetAgent(string agentID, string agentSearch)
        {
            if (agentID != "0") // No Agent
            {
                
                AgentCheckBox.Click();
                
                FindAgent.Click();
                FindAgent.Click();
                string searchField = agentSearch.Substring(3, agentSearch.Count() - 3);

                if (agentSearch.Contains("FN")) // Search by FN
                {
                    AgentSearchFirstName.SendKeys(searchField);
                }
                else if (agentSearch.Contains("LN")) // Search by LN
                {
                    AgentSearchLastName.SendKeys(searchField);
                }
                else // Search by Email
                {
                    AgentSearchEmail.SendKeys(searchField);
                }

                AgentSearchButton.Click();
                WebElement SelectAgentRadioBtn = new WebElement().ByXPath("//input[@value="+agentID+"]");
                SelectAgentRadioBtn.Click();
               

                SelectAgent.Click();
            }


        }

        public void SetAgentPolicyRole(string agentRole)
        {
            if (agentRole == "App" && AgentPolicyRole.Enabled) 
            {
                AgentPolicyRole.SelectByText("Approver");

            }

            else if (agentRole == "CC" && AgentPolicyRole.Enabled)
            {
                AgentPolicyRole.SelectByText("Carbon Copy");

            }
            else if (agentRole == "CCRO" && AgentPolicyRole.Enabled)
            {
                AgentPolicyRole.SelectByText("Carbon Copy (Read Only)");


            }
        }
        

        public void SetConsumerEmail()
        {
            ConsumerEmail.SendKeys(SeleNUnit.DocFast.WebObjects.Resource.Consumer_Email);
        }


        public void SendPolicy()
        {
            SendBtn.Click();
        }


        public void SaveAsIncomplete()
        {
            SaveAsIncompleteBtn.Click();
        }


        public void GotoDashboard()
        {
            GoToDashboardLink.Click();
        }

       
    }
}





 

