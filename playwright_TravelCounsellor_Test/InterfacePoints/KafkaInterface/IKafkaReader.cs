using playwright_TravelCounsellors_Test.InterfacePoints.KafkaInterface;

namespace playwright_TravelCounsellors_Test.InterfacePoints.KafkaInterface
{
    public interface IKafkaReader
    {
        public IEnumerable<KafkaMessage> ReadTopic(string topicName, string server);
    }
}