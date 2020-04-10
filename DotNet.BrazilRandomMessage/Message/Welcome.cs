using DotNet.BrazilRandomMessage.Message.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.BrazilRandomMessage.Message
{
    public class Welcome : IMessageBase
    {
        public IEnumerable<string> Messages => new List<string>
        {
            "Seja muito bem vindo.",
            "É muito bom te ver novamente.",
            "O que está procurando hoje?",
            "Como vão as coisas?",
            "Como vai você?",
        };
    }
}
