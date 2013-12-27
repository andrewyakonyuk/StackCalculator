using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
using System.Linq;
using System.Text;

namespace StackCalc
{
    class Stack<T>
    {
        ArrayList stack;

        public Stack()
        {
            stack = new ArrayList();
        }

        public void Push(T val)
        {
            stack.Add(val);
        }

        public T Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Стек пуст");
            object val = stack[stack.Count - 1];
            stack.Remove(val);
            return (T)val;
        }

        public T Peek()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Стек пуст");
            object val = stack[stack.Count - 1];
            return (T)val;
        }

        public double Count
        {
            get { return stack.Count; }
        }

        public void Clear()
        {
            stack = new ArrayList();
        }
    }
}
