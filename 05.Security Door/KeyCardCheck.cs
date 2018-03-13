namespace _05.Security_Door
{
    using System;

    public class KeyCardCheck : SecurityCheck, IKeyCardUI
    {

        public KeyCardCheck()
        {
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string code = this.RequestKeyCard();
            if (IsValid(code))
            {
                return true;
            }

            return false;
        }

        public string RequestKeyCard()
        {
            Console.WriteLine("Slide your key card");
            return Console.ReadLine();
        }
    }
}