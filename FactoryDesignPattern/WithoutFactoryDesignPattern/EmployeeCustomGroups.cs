public namespace FactoryDesignPattern.WithoutFactoryDesignPattern
{
    public class EmployeeCustomGroups : ICustomGroups
    {
        public void Add()
        {
            Console.WriteLine("Employee has the ability to add custom groups");
        }

        public void Modify()
        {
            Console.WriteLine("Employee has the ability to modify only seleted custom groups");
        }

        public void Delete()
        {
            Console.WriteLine("Employee has the ability to delete only employee created custom groups");
        }

        public void Fetch()
        {
            Console.WriteLine("Employee has the ability to fetch all custom groups");
        }
    }
}