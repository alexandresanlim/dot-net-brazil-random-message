using DotNet.BrazilRandomMessage.Message.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.BrazilRandomMessage.Message.Extention
{
    public static class RandomExtention
    {
        public static string PickARandomMessage(this IMessageBase message)
        {
            return message.Messages.PickRandom();
        }

        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
