using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Text
{
    public interface IPattern
    {
       IMatch Match(string text);
    }
}
