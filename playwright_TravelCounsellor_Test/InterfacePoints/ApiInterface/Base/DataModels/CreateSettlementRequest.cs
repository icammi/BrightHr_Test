﻿namespace playwright_TravelCounsellors_Test.InterfacePoints.ApiInterface.Base.DataModels
{
    public class CreateSettlementRequest
    {
        [JsonPropertyName("PayoutRequestSourceType")]
        public int PayoutRequestSourceType { get; set; } = 1;


        [JsonPropertyName("IgnoreOverridableValidations")]
        public bool IgnoreOverridableValidations { get; set; } = true;

    }

}
