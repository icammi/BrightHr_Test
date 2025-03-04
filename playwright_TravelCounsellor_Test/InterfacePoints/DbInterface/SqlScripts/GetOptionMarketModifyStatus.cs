namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.SqlScripts
{
    public partial class Sql
    {
        public static string GetOptionMarketModifyStatus => @"
            select
                [fId],
                [frOptionMarketId],
                [frResultStatusId]
            from [virtual].[tabOption]
            where [frOptionMarketId] = @OptionMarketId
        ";
    }
}