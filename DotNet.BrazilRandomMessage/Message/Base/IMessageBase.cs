using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.BrazilRandomMessage.Message.Base
{
    public interface IMessageBase
    {
        IEnumerable<string> Messages { get; }
    }
}
