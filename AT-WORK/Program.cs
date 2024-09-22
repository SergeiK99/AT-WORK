namespace AT_WORK
{
    internal class Program
    {
        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Введенная строка пустая!");

            text = text.ToLower().Replace(" ", "");
            return text == new string(text.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text) ? "Палиндромом" : "Не палиндромом");
        }
    }
}
