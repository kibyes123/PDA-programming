using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArdientePDAProg
{
    public class Palindrome : ILanguage
    {
        private Stack _stack = new Stack();
        public bool Run(string input)
        {
            var tobePush = input.Substring(0, input.Length / 2); //first half
            string tobePop;

            //if odd skip mid
            if(input.Length % 2 != 0)
            {
                tobePop = input.Substring((input.Length / 2) + 1, input.Length - (input.Length / 2) - 1); // 2nd half
            }
            //else if even just take the half
            else
            {
                tobePop = input.Substring((input.Length / 2) , input.Length - (input.Length / 2)); // 2nd half
            }
            
            foreach(var c in tobePush)
            {
                _stack.Push(c);
            }
            foreach(var c in tobePop)
            {
                if(c == 'a' && (char)_stack.Peek()! == 'a')
                {
                    _stack.Pop();
                }
                else if (c == 'b' && (char)_stack.Peek()! == 'b')
                {
                    _stack.Pop();
                }

            }
           if( _stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
