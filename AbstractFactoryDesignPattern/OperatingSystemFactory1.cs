namespace AbstractFactoryDesignPattern
{
    public class OperatingSystemFactory1 : IOperatingSystemFactory
    {
        public IWindowsSystem WindowsSystemOperation()
        {
            return new WindowsSystem1();
        }

        public IMacSystem MacSystemOperation()
        {
            return new MacSystem1();
        }
    }
}