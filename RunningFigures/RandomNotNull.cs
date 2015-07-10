using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningFigures
{
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
