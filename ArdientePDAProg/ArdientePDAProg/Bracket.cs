using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdientePDAProg
{
    public class Bracket : ILanguage
    {
        private Stack  _stack = new Stack();
        private Stack _inputCopy = new Stack();
        public bool Run(string input)
        {
            int count = 0;

            //pushing
            foreach (char c in input)
            {
                try
                {
                    if (c == '(')
                    {
                        _stack.Push(c);
                    }
                    else if (c == ')' && (char)_stack.Peek()! == '(')
                    {
                        _stack.Pop();
                    }
                    else if (c == '[')
                    {
                        _stack.Push(c);
                    }
                    else if (c == ']' && (char)_stack.Peek()! == '[')
                    {
                        _stack.Pop();
                    }
                    else if (c == '{')
                    {
                        _stack.Push(c);
                    }
                    else if (c == '}' && (char)_stack.Peek()! == '{')
                    {
                        _stack.Pop();
                    }
                }
                catch
                {
                    return false;
                }

            }
            if (_stack.Count == 0 )
            {
                return true;
            }
            
            return false;
            
        }
    }
}
