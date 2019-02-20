using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Text
{
    public class Character : IPattern
    {
        readonly char pattern;

        public Character(char pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new Match(false, text);
            if(text[0] == pattern)
                return new Match(true, text.Trim(pattern));
            return new Match(false, text);
        }
    }
}
