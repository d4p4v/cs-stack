using stack;

namespace genericStack.Test
{
    [TestClass]
    public class GenericStackUnitTests
    {
        /// <summary>
        /// Tests whether passed value is a palindrome.
        /// </summary>
        [TestMethod]
        public void PalindromeTrue()
        {
            string palindrome = "hallo ollah";

            GenericStack<string> stack = new GenericStack<string>(palindrome.Length);

            foreach (char c in palindrome)
            {
                stack.Push(c.ToString());
            }

            Assert.IsTrue(stack.IsPalindrome());
        }

        /// <summary>
        /// Tests whether passed value is not a palindrome.
        /// </summary>
        [TestMethod]
        public void PalindromeFalse()
        {
            string palindrome = "hello world";

            GenericStack<string> stack = new GenericStack<string>(palindrome.Length);

            foreach (char c in palindrome)
            {
                stack.Push(c.ToString());
            }

            Assert.IsFalse(stack.IsPalindrome());
        }
    }
}