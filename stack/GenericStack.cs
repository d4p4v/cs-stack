using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class GenericStack<T>
    {
        private T[] stack;
        private int index;

        /// <summary>
        /// Konstruiert einen Stack in gewünschter Grösse von gewünschtem Typ T.
        /// </summary>
        /// <param name="size">die gewünschte Grösse</param>
        public GenericStack(int size)
        {
            this.index = -1;
            this.stack = new T[size];
        }

        /// <summary>
        /// Legt einen Wert auf den Stack.
        /// </summary>
        /// <param name="value">der Wert</param>
        public void Push(T value)
        {
            this.index++;
            this.stack[this.index] = value;
        }

        /// <summary>
        /// Gibt den zuletzt auf den Stack gelegten Wert zurück und löscht diesen.
        /// </summary>
        /// <returns>der letzte Wert</returns>
        public T Pop()
        {
            T val = this.stack[this.index];

            this.index--;

            return val;
        }

        /// <summary>
        /// Gibt das auf dem Stack oberste Element zurück.
        /// </summary>
        /// <returns>das oberste Element</returns>
        public T Peek()
        {
            return this.stack[this.index];
        }

        /// <summary>
        /// Vertauscht die obersten beiden Elemente auf dem Stack.
        /// </summary>
        public void Swap()
        {
            T first = this.Pop();
            T second = this.Pop();

            this.Push(first);
            this.Push(second);
        }

        /// <summary>
        /// Löscht alle Daten im Stack.
        /// </summary>
        public void Clear()
        {
            this.index = -1;
        }

        /// <summary>
        /// Gibt zurück, ob der Stack leer ist.
        /// </summary>
        /// <returns>bool ob der Stack leer ist.</returns>
        public bool IsEmpty()
        {
            return this.index == -1;
        }

        /// <summary>
        /// Gibt zurück, ob der Stack voll ist.
        /// </summary>
        /// <returns>bool ob der Stack voll ist.</returns>
        public bool IsFull()
        {
            return this.index == this.stack.Length - 1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i <= this.index; i++)
            {
                sb.Append(this.stack[i].ToString());
                sb.Append(", ");
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        /// <summary>
        /// Schaut ob der Stack ein Palindrom beinhaltet.
        /// z.b. "hallo ollah"
        /// </summary>
        /// <returns>bool ob Palindrom oder nicht</returns>
        public bool IsPalindrome()
        {
            bool isPalindrome = true;

            foreach (T v in this.stack)
            {
                if (!this.Pop().Equals(v))
                    isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
