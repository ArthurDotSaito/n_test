using System;
using System.Collections.Generic;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> newStack = new Stack<object>();

            newStack.Push("Banana");
            newStack.Push("Batata");
            newStack.Push(3);
            newStack.Push(3.14);
            newStack.Push(false);
            newStack.Push("a");

            object valueToRemove = 3;

            Console.WriteLine("Before removing value '{0}': [{1}]", valueToRemove, string.Join(", ", newStack));

            RemoveFromStack(newStack, valueToRemove);

            Console.WriteLine("Stack After removing '{0}': [{1}]", valueToRemove, string.Join(", ", newStack));
        }

        static void RemoveFromStack<T>(Stack<T> stack, T valueToRemove)
        {
            Stack<T> auxStack = new Stack<T>();

            while (stack.Count > 0)
            {
                T current = stack.Pop();
                if (!current.Equals(valueToRemove))
                {
                    auxStack.Push(current);
                }
            }
            while (auxStack.Count > 0)
            {
                T current = auxStack.Pop();
                stack.Push(current);
            }
        }
    }
}