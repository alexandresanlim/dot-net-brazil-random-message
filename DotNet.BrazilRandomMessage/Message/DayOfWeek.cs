using DotNet.BrazilRandomMessage.Message.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.BrazilRandomMessage.Message
{
    public class DayOfWeek
    {
    }

    public class Weekend : IMessageBase
    {
        public IEnumerable<string> Messages => new List<string>
        {
            "Final de semana chegouuuuu! 🎶",
            "Iae, o que vai fazer neste FDS?",
            "Balada ou Netflix, o q tem pra hj?"
        };
    }

    public class Friday : IMessageBase
    {
        public IEnumerable<string> Messages
        {
            get
            {
                var listReturn = new List<string>
                {
                    "#Sextou? ;)",
                    "Hoje é sexta feiraaaaa o/"
                };

                listReturn.AddRange(new Weekend().Messages);

                return listReturn;
            }
        }
    }

    public class Sunday : IMessageBase
    {
        public IEnumerable<string> Messages
        {
            get
            {
                var listReturn = new List<string>
                {
                    "Tenha um ótimo domingo! ;)",
                    "Hoje é domingo, dia de parque?"
                };

                listReturn.AddRange(new Welcome().Messages);

                return listReturn;
            }
        }
    }

    public class Monday : IMessageBase
    {
        public IEnumerable<string> Messages
        {
            get
            {
                var listReturn = new List<string>
                {
                    "Ótimo começo de semana!",
                    "Ótima segunda-feira!"
                };

                listReturn.AddRange(new Welcome().Messages);

                return listReturn;
            }
        }
    }
}
