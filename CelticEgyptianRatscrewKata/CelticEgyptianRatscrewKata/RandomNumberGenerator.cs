using System;

namespace CelticEgyptianRatscrewKata
{
    class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random m_Random;

        public RandomNumberGenerator()
        {
            m_Random = new Random();
        }

        public RandomNumberGenerator(int seed)
        {
            m_Random = new Random(seed);
        }

        public int Get(int minValue, int maxValue)
        {
            return m_Random.Next(minValue, maxValue);
        }
    }
}