namespace playwright_TravelCounsellors_Test.InterfacePoints.ApiInterface.Base.DataModels.Fixture
{
    public class OptionMarketQueryFilter
    {
        [JsonPropertyName("MarketIdsOrNull")]
        public List<int>? MarketIds { get; set; }

        [JsonPropertyName("MarketTypeQueryFilterOrNull")]
        public MarketTypeQueryFilter? MarketTypeQueryFilter { get; set; }
    }
}
