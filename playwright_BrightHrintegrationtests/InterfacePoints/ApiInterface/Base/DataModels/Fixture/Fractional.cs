﻿namespace playwright_newintegrationtests.InterfacePoints.ApiInterface.Base.DataModels.Fixture
{
    public partial class Fractional
    {
        [JsonPropertyName("Numerator")]
        public long Numerator { get; set; }

        [JsonPropertyName("Denominator")]
        public long Denominator { get; set; }
    }
}
