namespace playwright_TravelCounsellors_Test.DriversApp
{
    public interface IDriver
    {
        IPage Page { get; }

        Task<IPage> InitializePlaywright();
    }
}