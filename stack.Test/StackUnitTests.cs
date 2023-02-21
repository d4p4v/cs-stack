namespace stack.Test
{
    
    /// <summary>
    /// Unit tests for the stack class.
    /// </summary>
    [TestClass]
    public class StackUnitTests
    {
        private Stack stack = new Stack(10);

        /// <summary>
        /// Cleans up the stack for next test.
        /// </summary>
        private void Cleanup()
        {
            this.stack.Clear();
        }

        /// <summary>
        /// Tests the Push() method
        /// </summary>
        [TestMethod]
        public void Pushing()
        {
            this.stack.Push(13);

            Assert.AreEqual(13, this.stack.Peek());

            Cleanup();
        }

        /// <summary>
        /// Tests the Pop() method
        /// </summary>
        [TestMethod]
        public void Popping()
        {
            this.stack.Push(1);
            this.stack.Push(2);

            int value = this.stack.Pop();

            Assert.AreEqual(value, 2);
            Assert.AreEqual(1, this.stack.Pop());

            Cleanup();
        }

        /// <summary>
        /// Tests the Peek() method
        /// </summary>
        [TestMethod]
        public void Peeking()
        {
            this.stack.Push(43);

            Assert.AreEqual(43, this.stack.Peek());

            this.Cleanup();
        }

        /// <summary>
        /// Tests the Swap() method
        /// </summary>
        [TestMethod]
        public void Swapping()
        {
            this.stack.Push(13);
            this.stack.Push(5);

            this.stack.Swap();

            Assert.AreEqual(13, this.stack.Peek());

            Cleanup();
        }

        /// <summary>
        /// Tests the Clear() and IsEmpty() methods
        /// </summary>
        [TestMethod]
        public void ClearingAndIsEmpty()
        {
            this.stack.Push(13);
            this.stack.Clear();

            Assert.IsTrue(this.stack.IsEmpty());

            Cleanup();
        }

        /// <summary>
        /// Tests the IsFull() method
        /// </summary>
        [TestMethod]
        public void IsFull()
        {
            for (int i = 1; i <= 10; i++)
            {
                this.stack.Push(i);
            }

            Assert.AreEqual(true, this.stack.IsFull());

            Cleanup();
        }

        /// <summary>
        /// Tests the ToString() method
        /// </summary>
        [TestMethod]
        public void ToStringTest()
        {
            this.stack.Push(12);
            this.stack.Push(65);

            Assert.AreEqual("12, 65", this.stack.ToString());

            Cleanup();
        }
    }
}