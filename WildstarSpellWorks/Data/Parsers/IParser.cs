using System;
using System.Collections.Generic;
using System.Text;

namespace WildstarSpellWorks.Data.Parsers
{
    public interface ICSVParser
    { 
        List<T> Parse<T>(string fileName);  
    }
}
