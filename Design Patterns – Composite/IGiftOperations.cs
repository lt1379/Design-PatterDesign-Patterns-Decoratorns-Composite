using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns___Composite
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);
    }
}
