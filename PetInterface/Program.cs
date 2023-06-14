using static System.Console;
using System.Globalization;
using PetUniverse;

namespace PetInterface
{
    class Program
    {
        public static void Main()
        {
            Menagerie menagerie = new();
            PetInterface menu = new(menagerie);
        }
    }

    class PetInterface
    {
        public readonly string welcomeMessage = "Welcome to your menagerie";
        public PetInterface.State CurrentState { get; private set; }
        public Menagerie InterfaceMenagerie { get; private set; }
        public enum State
        {
            Exit,
            MainSelect,
            Create,
            Act
        }
        public PetInterface(Menagerie menagerie)
        {
            CurrentState = PetInterface.State.Create;
            InterfaceMenagerie = menagerie;
            Write(welcomeMessage);
            while (CurrentState != PetInterface.State.Exit)
            {
                switch (CurrentState)
                {
                    case State.Create:
                        InterfaceMenagerie = CreateList(InterfaceMenagerie);
                        break;
                    default:
                        break;
                }
            }
        }
        public static Menagerie CreateList(Menagerie menagerie)
        {
            return menagerie; // TODO Implement the creation menu.
        }
        public static string GetTextFromUser(string prompt)
        {
            string? result = null;
            while (string.IsNullOrWhiteSpace(result))
            {
                Clear();
                Write(prompt);
                result = ReadLine();
                if (string.IsNullOrWhiteSpace(result))
                {
                    WriteLine("Not valid input string, try again.");
                }
            }
            return result;
        }
    }
}