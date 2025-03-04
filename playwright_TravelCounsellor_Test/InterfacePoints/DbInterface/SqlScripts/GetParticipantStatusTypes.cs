namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public partial class Sql
    {
        public static string GetParticipantStatusTypes => @"
            select
                [fId],
                [fName]
            from Virtual.tabFixtureParticipantStatus
        ";
    }
}
