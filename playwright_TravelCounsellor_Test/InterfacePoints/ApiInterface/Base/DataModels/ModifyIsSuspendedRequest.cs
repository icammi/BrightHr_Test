namespace playwright_TravelCounsellors_Test.InterfacePoints.ApiInterface.Base.DataModels
{
    public class ModifyIsSuspendedRequest
    {
        [JsonPropertyName("IsSuspended")]
        public bool IsSuspended { get; set; } = false;
    }
}
