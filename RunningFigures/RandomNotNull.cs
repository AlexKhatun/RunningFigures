namespace RunningFigures
{
    using System;

    /// <summary>
    /// Custom Random without Null
    /// </summary>
    public class RandomNotNull : Random
    {
        public override int Next()
        {
            int result = 0;
            while (result == 0)
            {
                result = base.Next();
            }

            return result;
        }

        public override int Next(int maxValue)
        {
            int result = 0;
            while (result == 0)
            {
                result = base.Next(maxValue);
            }

            return result;
        }

        public override int Next(int minValue, int maxValue)
        {
            int result = 0;
            while (result == 0)
            {
                result = base.Next(minValue, maxValue);
            }

            return result;
        }
    }
}
