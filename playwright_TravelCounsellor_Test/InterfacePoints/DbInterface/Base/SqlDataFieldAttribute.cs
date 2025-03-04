namespace playwright_TravelCounsellors_Test.InterfacePoints.DbInterface.Base
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class SqlDataFieldAttribute : Attribute
    {
        private readonly string _name;

        public SqlDataFieldAttribute(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
