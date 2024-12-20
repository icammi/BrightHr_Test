﻿namespace playwright_newintegrationtests.InterfacePoints.ApiInterface.Base.DataModels.Fixture
{
    public partial class Price
    {
        [JsonPropertyName("Fractional")]
        public Fractional Fractional { get; set; } = new();

        [JsonPropertyName("Decimal")]
        public string Decimal { get; set; } = string.Empty;
    }
}
