using System;

namespace ShakespeareAssignment.Utils
{
    public class StringLength : IComparable
    {
        public string s;

        public StringLength(string s) {
            this.s = s;
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;

            if(s.Length > ((StringLength)obj).s.Length)
                return 1;
            else if(s.Length < ((StringLength)obj).s.Length)
                return -1;
                
            return 0;
        }

        public override string ToString() {
            return s;
        }
    }
}