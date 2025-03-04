namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public static partial class Sql
    {
        public static string GetFixtureData => @"
            select [fId]
                  ,[frName]
                  ,[frStatusId]
                  ,[fStartDate]
                  ,[fCutOffDate]
                  ,[fSequenceNumber]
                  ,[fIsSuspended]
            from [virtual].[tabFixture]
            where [fId] = @FixtureId and [frStatusId] = @StatusId
        ";
    }
}
