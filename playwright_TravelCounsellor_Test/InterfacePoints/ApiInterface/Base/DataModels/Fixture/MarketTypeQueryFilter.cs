namespace playwright_TravelCounsellors_Test.InterfacePoints.ApiInterface.Base.DataModels.Fixture
{
    public class MarketTypeQueryFilter
    {
        [JsonPropertyName("MarketTypes")]
        public List<string> MarketTypes { get; set; } = new();
        [JsonPropertyName("IsWhitelist")]
        public bool IsWhitelist { get; set; } = true;
    }
}
