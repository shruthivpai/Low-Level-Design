namespace AbstractFactoryDesignPattern
{
    public class OperatingSystemFactory2 : IOperatingSystemFactory
    {
        public IWindowsSystem WindowsSystemOperation()
        {
            return new WindowsSystem2();
        }

        public IMacSystem MacSystemOperation()
        {
            return new MacSystem2();
        }
    }
} 