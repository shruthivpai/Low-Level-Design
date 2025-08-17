namespace AbstractFactoryDesignPattern
{
    public class MacSystem2 : IMacSystem
    {
        public void Button()
        {
            Console.WriteLine("Mac System 2 Button");
        }

        public void Menu()
        {
            Console.WriteLine("Mac System 2 Menu");
        }

        public void Display()
        {
            Console.WriteLine("Mac System 2 Display");
        }
    }
}