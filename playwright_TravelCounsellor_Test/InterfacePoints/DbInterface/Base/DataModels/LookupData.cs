using playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.Base;

namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.Base.DataModels
{
    public class LookupData
    {
        [SqlDataField("fId")]
        public int Id { get; set; }

        [SqlDataField("fName")]
        public string Name { get; set; } = string.Empty;
    }
}
