﻿namespace playwright_TravelCounsellors_Test.InterfacePoints.KafkaInterface
{
    public class KafkaMessage
    {
        public byte[] Key { get; set; } = Array.Empty<byte>();
        public byte[] Value { get; set; } = Array.Empty<byte>();

        public Dictionary<string, byte[]> Headers = new();
    }
}
