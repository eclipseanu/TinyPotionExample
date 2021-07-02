using System;
using System.Collections.Generic;

namespace HellaTinyPotionExample
{
    public static class Extensions
    {
        public static T Random<T>(this IList<T> items) => items[_random.Next(0, items.Count)];
        
        static Random _random = new Random();
    }
}