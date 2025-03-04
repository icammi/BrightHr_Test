namespace playwright_TravelCounsellors_Test.PageObjects
{
    public class elementsobjects
    {
        public const string fromdatepicker       = "#virtual-from-date-picker";
        public const string fromdatepickerclear  = "#virtual-from-date-picker svg";
        public const string todatepicker         = "#virtual-to-date-picker";
        public const string todatepickerclear    = "#virtual-to-date-picker svg";
        public const string btnsearchdetail      = "#virtual-btn-search-detail-search";
        public const string btndetailsearch      = "#virtual-btn-detail-search";
        public const string btnfixtureid         = "#virtual-btn-fixture-id";

        public const string selectsportclear     = "#virtual-select-sport nz-select-clear svg";
        public const string selectsportlist      = "#virtual-select-sport";

        public const string selectstatusclear    = "#virtual-select-status nz-select-clear svg";
        public const string selectstatuslist     = "#virtual-select-status";

        public const string Norecordsfound       = "No records found";
        public const string actionpath           = "//div[@class='ant-picker-time-panel-cell-inner']";
        public const string fixturesid           = "Fixtures";

        public const string btnantswitch         = "button.ant-switch";

        //button[@class='ant-btn view-button active-view-button']
        public const string anttabscontentpath   = ".ant-tabs-content > div:nth-child(2)";
        public const string antdrawermask        = ".ant-drawer-mask";

        //span[@class='title-wrapper'
    }

    public class elementstotalpoints
    {
        public const string enterfixtureId        = "Enter Fixture Id";
        public const string totalpointsId         = "Total Points [Id:13580]";
        public const string totalpointsdateFormat = ".ant-tabs-content > div:nth-child(2)";
        public const string correctscoreId        = "Correct Score [Id:13581";
        public const string matchwinnerId         = "Match Winner [Id:13582]";
        public const string mainmarketsvirtual    = "Main Markets Virtual Tennis";
        public const string mainmarkets           = "Main Markets";
    }
   
    public class elementdateformat
    {
        public const string dateFormat     = "dd/MMMM/yyyy hh:mm:ss tt";
        public const string dateFormatdd   = "dd";
        public const string dateFormatMM   = "MM";
        public const string dateFormatMMMM = "MMMM";
        public const string dateFormatyyyy = "yyyy";

        public const string timeFormathh   = "hh";
        public const string timeFormatmm   = "mm";
        public const string timeFormatss   = "ss";

        public const string timeFormattt   = "tt";
    }
    
    public class elementname
    {
        public const string CLOSE  = "close";
        public const string SEARCH = "Search";

    }

    public class dropdownlist
    {
        public const string selectionlist = "//nz-select-item[@class='ant-select-selection-item ng-star-inserted'][1]";
    }

    public class dropdownlisttitles
    {
        public const string TitleALL               = "//div[text()='All']";
        public const string TitleVIRTUALBASKETBALL = "//div[text()='Virtual Basketball']";
        public const string TitleVIRTUALTENNIS     = "//div[text()='Virtual Tennis']";
        public const string TitleAMERICANFOOTBALL  = "//div[text()='Virtual American Football']";
        public const string TitleVIRTUALFOOTBALL   = "//div[text()='Virtual Football']";
        public const string TitleCREATED           = "//div[text()='Created']";
        public const string TitlePUBLISHED         = "//div[text()='Published']";
        public const string TitleUNPUBLISHED       = "//div[text()='Unpublished']";
        public const string TitleABANDONED         = "//div[text()='Abandoned']";
        public const string TitlePOSTPONED         = "//div[text()='Postponed']";
        public const string TitleCANCELLED         = "//div[text()='Cancelled']";
    }
}
