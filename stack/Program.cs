namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "hallo 5Wollah";

            GenericStack<string> stack = new GenericStack<string>(palindrome.Length);

            foreach (char c in palindrome)
            {
                stack.Push(c.ToString());
            }

            Console.WriteLine(stack.IsPalindrome());
        }
    }
}