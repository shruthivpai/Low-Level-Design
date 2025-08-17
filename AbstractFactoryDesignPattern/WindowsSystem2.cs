namespace AbstractFactoryDesignPattern
{
    public class WindowsSystem2 : IWindowsSystem
    {
        public void Button()
        {
            Console.WriteLine("Windows System 2 Button");
        }

        public void Menu()
        {
            Console.WriteLine("Windows System 2 Menu");
        }
    }
}