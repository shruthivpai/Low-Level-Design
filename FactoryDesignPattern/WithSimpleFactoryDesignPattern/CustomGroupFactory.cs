namespace FactoryDesignPattern.WithFactoryDesignPattern
{
    public class CustomGroupFactory
    {
        public static ICustomGroups CustomGroupType(string userType)
        {
            switch (userType.ToLower())
            {
                case "admin":
                    return new AdminCustomGroups();
                case "employee":
                    return new EmployeeCustomGroups();
                case "nonadmin":
                    return new NonAdminCustomGroups();
                default:
                    throw new ArgumentException("Invalid user type");
            }
        }
    }
}