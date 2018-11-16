using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    public interface ISentenceElement
    {
        string Value { get; set; }
        SentenceElementType SentenceElementType { get; }
    }
}
