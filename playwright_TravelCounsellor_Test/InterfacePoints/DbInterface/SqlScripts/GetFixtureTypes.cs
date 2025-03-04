namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public partial class Sql
    {
        public static string GetFixtureTypes => @"
            select
                [fId],
                [fName]
            from virtual.tabFixturetype
        ";
    }
}
