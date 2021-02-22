using System;

namespace RealSetExercise.RealSets
{
    public interface IRealSet
    {
       public bool contains(double real);
       public IRealSet union(IRealSet other) {
           return new UnionRealSet(this, other);
       }
       public IRealSet intersection(IRealSet other) {
           return new IntersectionRealSet(this, other);
       }
       public IRealSet complement() {
           return new ComplementRealSet(this);
       }
    }
}
