namespace Num2WordApp.Core
{
    public static class App
    {
        public static void Run()
        {
            Console.WriteLine("Type a number that you want to be written as word:");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Type [1] for English output or [2] for Portuguese output:");
            int codeLanguage = int.Parse(Console.ReadLine()!);
            Console.WriteLine(WriteNumber.WriteNumberAsWord(number, codeLanguage));
        }

        public static bool Exit()
        {
            Console.WriteLine("Do you want to stop the application? Type [Y] or [N]:");
            string answer = Console.ReadLine()!;
            if (answer.ToUpper() == "Y")
            {
                return true;
            }
            return false;
        }
    }
}
