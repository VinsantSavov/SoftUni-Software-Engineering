﻿using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count > 0;
        }

        public Stack<string> AddRange(Stack<string> stack)
        {
            this.AddRange(stack);
            return this;
        }
    }
}
