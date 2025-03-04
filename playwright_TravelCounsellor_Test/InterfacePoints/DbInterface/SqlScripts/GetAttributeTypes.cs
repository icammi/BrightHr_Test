namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public partial class Sql
    {
        public static string GetAttributeTypes => @"
            select
                [fId],
                [fName]
            from virtual.tabAttribute
        ";
    }
}
