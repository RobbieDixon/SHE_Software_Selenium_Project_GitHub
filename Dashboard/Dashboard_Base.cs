using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace SHE_Software_Selenium_Project.Dashboard
{
    public class Dashboard_Base : Dashboard_TestData
    {
        readonly IWebDriver driver = new ChromeDriver();

        public IWebElement FindA11y_ID(string A11y_ID)
        {
            return driver.FindElement(By.CssSelector(A11y_ID));
        }

        public Action HoverA11y_ID(string A11y_ID)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(FindA11y_ID(A11y_ID))
                  .Perform();
            return null;
        }

        public string CurrentNewRecord(string IncrementNewRecord)
        {
            string CurrentNewRecord = "#manageRecord" + IncrementNewRecord;

            return CurrentNewRecord;
        }

        public string IncrementNewRecord(string CurrentNewRecord)
        {
            string TrimNewRecord = CurrentNewRecord.Remove(13);
            int i = (int)long.Parse(TrimNewRecord);
            int IncrementNewRecord = i++;

            return IncrementNewRecord.ToString();
        }

        public bool VerifyDisplayed(string A11y_ID)
        {
            try
            {
                FindA11y_ID(A11y_ID);
            }

            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        public bool VerifyText(string A11y_ID, string Data_ID)
        {
            try
            {
                FindA11y_ID(A11y_ID).Text.Equals(Data_ID);
            }

            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool VerifyDeleted(string Data_ID)
        {
            try
            {
                driver.PageSource.Contains(Data_ID);
            }

            catch (Exception)
            {
                return true;
            }

            return false;
        }

        public void GoToDashboardURL_LoggedOut()
        {
            //driver.Manage().Window.FullScreen(); 3RD PARTY DEFECT - ACTIVATE CODE WHEN FIXED
            driver.Navigate().GoToUrl(Data_DashboardURL);
            VerifyDisplayed(A11y_UsernameFld);
        }

        public void LogInDashboard()
        {
            FindA11y_ID(A11y_UsernameFld).SendKeys(Data_Username);
            FindA11y_ID(A11y_PasswordFld).SendKeys(Data_Password);
            FindA11y_ID(A11y_LoginBtn).Click();
            VerifyDisplayed(A11y_RiskModuleBtn);
        }

        public void NavigateToModule_Contractor_SupplierContractor()
        {
            FindA11y_ID(A11y_ModulesDrp).Click();
            HoverA11y_ID(A11y_ModulesDrp_ContractorDrp);
            FindA11y_ID(A11y_ContractorDrp_SupplierContractorBtn).Click();
            VerifyDisplayed(A11y_SupplierContractorTtl);
        }

        public void ClickNewRecordBtn()
        {
            FindA11y_ID(A11y_NewRecordBtn).Click();
            VerifyDisplayed(A11y_SupplierContractorTab);
        }

        public void EnterSupplierContractorName()
        {
            FindA11y_ID(A11y_SupplierContractor_NameFld).SendKeys(Data_SupplierContractor_Name);
            VerifyText(A11y_SupplierContractor_NameFld, Data_SupplierContractor_Name);
        }

        public void ClickSaveCloseBtn()
        {
            FindA11y_ID(A11y_SaveCloseBtn).Click();
            VerifyText(A11y_NewRecordData, Data_SupplierContractor_Name);
        }

        public void DeleteRecordSummaryScreen()
        {
            FindA11y_ID(A11y_ManageNewRecordDrp).Click();
            FindA11y_ID(A11y_ManageNewRecordDrp_DeleteBtn).Click();
            FindA11y_ID(A11y_DeleteRecord_ConfirmBtn).Click();
            VerifyDeleted(Data_SupplierContractor_Name);
        }

        public void LogOutDashboard()
        {
            FindA11y_ID(A11y_UserSettingsDrp).Click();
            FindA11y_ID(A11y_UserSettingsDrp_LogOutBtn).Click();
            VerifyDisplayed(A11y_LogOutScreen_LogOutTtl);
        }

        public void CloseDriver()
        {
            driver.Close();
        }
    }
}