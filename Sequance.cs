using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Text
{
    public class Sequance : IPattern
    {
        private readonly IPattern[] patterns;

        public Sequance(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            string remainingText = string.Empty;
            foreach (var pattern in patterns) 
            {
                var match = pattern.Match(text);
                remainingText = match.RemainingText();
                if (!match.Success())
                    return new Match(false, match.RemainingText());
                else
                    text = match.RemainingText();
            }
            return new Match(true, remainingText);
        }
    }
}
