using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class UserInput
    {
        public class TextInput
        {
            public string word = "";
            public virtual void Add(char c)
            {
                    word += c;
            }
            public string GetValue()
            {
                return word;
            }
        }

        public class NumericInput : TextInput
        {
            public override void Add(char c)
            {
                if (c <= '9')
                {
                    word += c;
                }
            }
        }
    }
}
