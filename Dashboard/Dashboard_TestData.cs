namespace SHE_Software_Selenium_Project.Dashboard
{
    public class Dashboard_TestData
    {
        //Fixed Data
        public string Data_DashboardURL = "https://stirling.she-development.net/automation";

        //Variable Data
        public string Data_Username = "RobbieD";
        public string Data_Password = "Robbie6254!";
        public string Data_SupplierContractor_Name = "Aa1 !#$%&'()*+,-./:;<=>?@[]^_`{|}~";

        //Accessibility Names
        public string A11y_UsernameFld = "#username";
        public string A11y_PasswordFld = "#password";
        public string A11y_LoginBtn = "#login";
        public string A11y_ModulesDrp = "#main-content > div.headercontainer.she-userrole-Users > div.headercolumn-center > div:nth-child(2) > div > ul > li.she-has-submenu > a";
        public string A11y_RiskModuleBtn = "#site-wrapper > section > div.modules.clearfix > ul > div > a:nth-child(1)";
        public string A11y_ModulesDrp_ContractorDrp = "#main-content > div.headercontainer.she-userrole-Users > div.headercolumn-center > div:nth-child(2) > div > ul > li.she-has-submenu.js-she-dropdown-open.she-dropdown-open > ul > li:nth-child(9) > a:nth-child(1)";
        public string A11y_ContractorDrp_SupplierContractorBtn = "#main-content > div.headercontainer.she-userrole-Users > div.headercolumn-center > div:nth-child(2) > div > ul > li.she-has-submenu.js-she-dropdown-open.she-dropdown-open > ul > li.she-has-submenu.js-she-submenu-open.she-submenu-open > ul > li:nth-child(5) > a:nth-child(1)";
        public string A11y_SupplierContractorTtl = "#site-wrapper > section > h2";
        public string A11y_NewRecordBtn = "#site-wrapper > section > a";
        public string A11y_SupplierContractorTab = "#tabstrip > ul > li.k-item.k-state-default.information.k-state-active.k-tab-on-top.k-first > span.k-link";
        public string A11y_SupplierContractor_NameFld = "#SheSupplierContractor_SupplierName";
        public string A11y_SaveCloseBtn = "#site-wrapper > section > form > div.buttons_line_wrapper > div > div > ul > li:nth-child(3) > button";
        public string A11y_NewRecordData = "#site-wrapper > section > div.item-box.ui-selectable > div:nth-child(5) > div.information > ul > li:nth-child(4) > a";
        public string A11y_ManageNewRecordDrp = "#manageRecord" + "5488575";
        public string A11y_ManageNewRecordDrp_DeleteBtn = "#cogDelete" + "5488575";
        public string A11y_DeleteRecord_ConfirmBtn = "#full_width > div.ui-dialog.ui-corner-all.ui-widget.ui-widget-content.ui-front.ui-dialog-buttons.ui-draggable.ui-resizable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button:nth-child(1)";
        public string A11y_UserSettingsDrp = "#uservoice-activation > a";
        public string A11y_UserSettingsDrp_LogOutBtn = "#uservoice-activation > ul > li:nth-child(5) > a";
        public string A11y_LogOutScreen_LogOutTtl = "body > div > div > div.she-login-body.clearfix > div > div:nth-child(1) > h3";
    }
}
