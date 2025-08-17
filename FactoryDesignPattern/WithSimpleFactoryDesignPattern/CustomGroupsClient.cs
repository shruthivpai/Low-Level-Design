namespace FactoryDesignPattern.WithFactoryDesignPattern
{
    public class CustomGroupsClient
    {
        private readonly CustomGroupFactory _customGroupFactory;
        public CustomGroupsClient(CustomGroupFactory customGroupFactory)
        {
            _customGroupFactory = customGroupFactory;
        }
        public ICustomGroups CustomGroupOperations(string userType)
        {
            var customGroup = _customGroupFactory.CustomGroupType(userType);
            customGroup.Add();
            customGroup.Modify();
            customGroup.Delete();
            customGroup.Fetch();
            return customGroup;
        }

        public static void Main(string[] args)
        {
            CustomGroupFactory customGroupFactory = new CustomGroupFactory();
            CustomGroupsClient customGroups = new CustomGroupsClient(customGroupFactory);

            ICustomGroups adminGroup = customGroups.CustomGroupOperations("admin");

            ICustomGroups employeeGroup = customGroups.CustomGroupOperations("employee");

            ICustomGroups nonAdminGroup = customGroups.CustomGroupOperations("nonadmin");
        }
    }
}