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

        public static float HumanizeRatio()
        {
            var humanizeValue = (int) (Constants.HumanizeFactor*100);
            var result = (float)Random(humanizeValue + 1) - (humanizeValue/2f);
            return result + 1;
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
            public const int MaxActiveMonstersCount = 5;
            public const float HumanizeFactor = 0.2f;
        }

    }

}