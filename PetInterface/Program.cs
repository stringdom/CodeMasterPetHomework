using System;

namespace PetInterface
{
    class Program
    {
        public static void Main()
        {
            PetInterface menu = new();
            Console.WriteLine("{0}", menu.welcomeMessage);
        }
    }

    class PetInterface
    {
        public readonly string welcomeMessage = "Welcome to your menagerie";
        public enum State
        {
            Exit,
            MainSelect,
            Create,
            Act
        }

    }
}