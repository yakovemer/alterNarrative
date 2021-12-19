using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltNarrativeLibrary.Core
{
    public interface ITextNodeService
    {
        List<TextNodeDb> GetTextNodes();
    }
}
