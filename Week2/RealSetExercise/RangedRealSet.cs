using System;

namespace RealSetExercise
{
    class RangedRealSet : IRealSet
    {
        double max, min;
        bool maxincluded, minincluded;

        public RangedRealSet(double max, double min, bool maxincluded, bool minincluded) {
            this.max = max;
            this.min = min;
            
            this.maxincluded = maxincluded;
            this.minincluded = minincluded;
        }

        public bool contains(double real) {
            if(!minincluded && !maxincluded) {
                return (real < max && real > min);
            } 
            if (!minincluded && maxincluded) {
                return (real <= max && real > min);
            }
            if (minincluded && !maxincluded) {
                return (real < max && real >= min);
            }
            if (minincluded && maxincluded) {
                return (real <= max && real >= min);
            }
            return false;
        }
    }
}
