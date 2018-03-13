namespace _05.Security_Door
{
    using System;
    using System.Collections.Generic;

    public class SecurityManager
    {
        private Dictionary<int, SecurityCheck> checkOptions;

        public SecurityManager()
        {
            this.checkOptions = new Dictionary<int, SecurityCheck>()
            {
                {1, new KeyCardCheck() },
                {2, new PinCodeCheck() }
            };
        }

        public void Check()
        {
            Console.WriteLine("Choose option: 1 - KeyCard, 2 - PinCode:");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine(this.checkOptions[option].ValidateUser());
        }
    }
}