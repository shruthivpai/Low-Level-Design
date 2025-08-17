namespace AbstractFactoryDesignPattern
{
    public class WindowsSystem1 : IWindowsSystem
    {
        public void Button()
        {
            Console.WriteLine("Windows System 1 Button");
        }

        public void Menu()
        {
            Console.WriteLine("Windows System 1 Menu");
        }
    }
}