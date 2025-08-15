public namespace FactoryDesignPattern.WithoutFactoryDesignPattern
{
    public class NonAdminCustomGroups : ICustomGroups
    {
        public void Add()
        {
            Console.WriteLine("Non-admin user has the ability to add custom groups");
        }

        public void Modify()
        {
            Console.WriteLine("Non-admin user has the ability to modify only selected custom groups");
        }

        public void Delete()
        {
            Console.WriteLine("Non-admin user has the ability to delete only non-admin created custom groups");
        }

        public void Fetch()
        {
            Console.WriteLine("Non-admin user has the ability to fetch all custom groups");
        }
    }
}