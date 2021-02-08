using System;

namespace RealSetExercise.RealSets
{
    class IntersectionRealSet : IRealSet
    {
        IRealSet first, second;

        public IntersectionRealSet(IRealSet first, IRealSet second) {
            this.first = first;
            this.second = second;
        }

        public bool contains(double real) {
            return this.first.contains(real) && this.second.contains(real);
        }
    }
}
