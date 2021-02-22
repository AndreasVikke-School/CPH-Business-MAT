using System;

namespace RealSetExercise.RealSets
{
    class RangedRealSet : IRealSet
    {
        double min, max;
        bool minincluded, maxincluded;

        public RangedRealSet(double min, double max, bool minincluded, bool maxincluded) {
            this.min = min;
            this.max = max;

            this.minincluded = minincluded;
            this.maxincluded = maxincluded;
        }

        public bool contains(double real) {
            if(!minincluded && !maxincluded) 
                return (real < max && real > min);
            if (!minincluded && maxincluded) 
                return (real <= max && real > min);
            if (minincluded && !maxincluded) 
                return (real < max && real >= min);
            if (minincluded && maxincluded) 
                return (real <= max && real >= min);
            return false;
        }
    }
}
