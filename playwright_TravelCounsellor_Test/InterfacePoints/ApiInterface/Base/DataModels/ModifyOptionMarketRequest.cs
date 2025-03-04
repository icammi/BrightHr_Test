namespace playwright_TravelCounsellors_Test.InterfacePoints.ApiInterface.Base.DataModels;

public class ModifyOptionMarketRequest
{
    [JsonPropertyName("DeadHeatDivisor")]
    public string DeadHeatDivisor { get; set; } = "1";

    [JsonPropertyName("Options")]
    public List<ModifyOption> Options { get; set; } = new();
}