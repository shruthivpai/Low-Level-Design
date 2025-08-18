using System;

namespace SingletonDesignPattern 
{
    public sealed class SimpleSingletonPattern 
    {
        //private static field to store the instace value
        private static SimpleSingletonPattern _instace;

        // Private constructor to prevent instace creation from outside
        private SimpleSingletonPattern() {};

        //public static method to get the instace of the class
        public static SimpleSingletonPattern GetInstace() 
        {
            if(_instace == null) 
            {
                _instace = new SimpleSingletonPattern();
            }
            return _instace;
        }
    }
}