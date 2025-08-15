namespace FactoryDesignPattern.WithoutFactoryDesignPattern
{
    public class CustomGroups
    {
        public ICustomGroups CustomGroupOperations(string userType)
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

        public static void Main(string[] args)
        {
            CustomGroups customGroups = new CustomGroups();

            ICustomGroups adminGroup = customGroups.CustomGroupOperations("admin");
            adminGroup.Add();
            adminGroup.Modify();
            adminGroup.Delete();
            adminGroup.Fetch();

            ICustomGroups employeeGroup = customGroups.CustomGroupOperations("employee");
            employeeGroup.Add();
            employeeGroup.Modify();
            employeeGroup.Delete();
            employeeGroup.Fetch();

            ICustomGroups nonAdminGroup = customGroups.CustomGroupOperations("nonadmin");
            nonAdminGroup.Add();
            nonAdminGroup.Modify();
            nonAdminGroup.Delete();
            nonAdminGroup.Fetch();
        }
    }
}