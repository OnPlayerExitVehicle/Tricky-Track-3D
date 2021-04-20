using System;
using System.Collections.Generic;
using System.Linq;

namespace TrickyTrack.Base.Utility
{
    public static class EventCaller
    {
        public static void CallEvents<T>(this IEnumerable<BaseScript> enumerable, Action<T> action)
        {
            foreach (T temp in enumerable.OfType<T>())
            {
                action(temp);
            }
        }

        public static void CallEvents(this IEnumerable<BaseScript> enumerable, Action<BaseScript> action)
        {
            foreach (BaseScript temp in enumerable)
            {
                action(temp);
            }
        }
    }
}