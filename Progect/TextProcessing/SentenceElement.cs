using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    public class SentenceElement : ISentenceElement
    {
        public string Value { get; set; }
        public SentenceElementType SentenceElementType { get; private set; }

        public SentenceElement(string sentenceElementValue, SentenceElementType type)
        {
            this.Value = sentenceElementValue;
            this.SentenceElementType = type;
        }

    }
}