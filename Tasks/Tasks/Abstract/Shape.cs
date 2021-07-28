using System;

namespace Tasks.Abstract
{
    public abstract class Shape : IComparable<Shape>
    {
        protected abstract double Area { get; set; }

        public int CompareTo(Shape that)
        {
            if (this.Area <  that.Area) return -1;
            if (this.Area == that.Area) return 0;
            return 1;
        }
    }
}