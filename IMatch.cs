using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Text
{
    public interface IMatch
    {
        bool Success();
        string RemainingText();
    }
}
