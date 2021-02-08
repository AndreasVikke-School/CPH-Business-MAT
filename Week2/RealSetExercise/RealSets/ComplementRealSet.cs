using System;

namespace RealSetExercise.RealSets
{
    class ComplementRealSet : IRealSet
    {
        IRealSet first;

        public ComplementRealSet(IRealSet first) {
            this.first = first;
        }

        public bool contains(double real) {
            return !this.first.contains(real);
        }
    }
}
