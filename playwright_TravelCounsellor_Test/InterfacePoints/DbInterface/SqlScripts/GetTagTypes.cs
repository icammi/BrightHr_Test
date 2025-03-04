namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public partial class Sql
    {
        public static string GetTagTypes => @"
            select
                [fId],
                [fName]
            from virtual.tabTagType
        ";
    }
}
