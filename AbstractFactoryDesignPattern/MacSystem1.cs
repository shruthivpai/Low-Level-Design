namespace AbstractFactoryDesignPattern
{
    public class MacSystem1 : IMacSystem
    {
        public void Button()
        {
            Console.WriteLine("Mac System 1 Button");
        }

        public void Menu()
        {
            Console.WriteLine("Mac System 1 Menu");
        }
        
        public void Display()
        {
            Console.WriteLine("Mac System 1 Display");
        }
    }
}