using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SHE_Software_Selenium_Project.Dashboard
{
    [TestClass]
    public class Dashboard_Tests : Dashboard_Base
    {
        [TestMethod]
        public void GIVEN_NewRecord_WHEN_DeleteNewRecord_THEN_NewRecordDeleted()
        {
            GoToDashboardURL_LoggedOut();
            LogInDashboard();
            NavigateToModule_Contractor_SupplierContractor();
            ClickNewRecordBtn();
            EnterSupplierContractorName();
            ClickSaveCloseBtn();
            DeleteRecordSummaryScreen();
            LogOutDashboard();
        }

        [TestCleanup]
        public void TearDown()
        {
            CloseDriver();
        }
    }
}
