namespace FactoryDesignPattern.WithFactoryDesignPattern
{
    public class AdminCustomGroups : ICustomGroups
    {
        public void Add()
        {
            Console.WriteLine("Admin has the ability to add all types of custom group");
        }

        public void Modify()
        {
            Console.WriteLine("Admin has the ability to modify all the custom groups");
        }

        public void Delete()
        {
            Console.WriteLine("Admin has the ability to delete all the custom groups");
        }

        public void Fetch()
        {
            Console.WriteLine("Admin has the ability to fetch all the custom groups");
        }
    }
}