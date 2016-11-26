using System;
using System.Collections.Generic;

namespace Core
{
    public static class Utils
    {
        private static readonly Random _random = new Random();

        public static int Random(int max)
        {
            return _random.Next(max);
        }

        public static int Random(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static Element GetRandomElement()
        {
            var values = Enum.GetValues(typeof(Element));
            return (Element) values.GetValue(Random(values.Length - 1));
        }

        public static class Constants
        {
            public const int ActiveInventoryCount = 5;
            public const int InitGoldCount = 1000;
        }

    }

}