namespace _05.Security_Door
{
    using System;

    public class PinCodeCheck : SecurityCheck, IPinCodeUI
    {

        public PinCodeCheck()
        {
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = this.RequestPinCode();
            if (IsValid(pin))
            {
                return true;
            }

            return false;
        }

        public int RequestPinCode()
        {
            Console.WriteLine("Enter your pin code:");
            return int.Parse(Console.ReadLine());
        }
    }
}