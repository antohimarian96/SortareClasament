using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Text
{
    public class Range : IPattern
    {
        private readonly char start;
        private readonly char end;

        public Range(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public IMatch Match(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new Match(false , text);
            if (start <= text[0] && text[0] <= end)
                return new Match(true, text.Trim(text[0]));
            return new Match(false, text);
        }
    }
}
