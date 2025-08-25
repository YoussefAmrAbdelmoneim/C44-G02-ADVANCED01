using System.Numerics;

namespace Assignment_1_Advanced
{
    internal class Range<T> where T : IComparable<T>,INumber<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) > 0 && value.CompareTo(Maximum) < 0;
        }
        public T Length()
        {
            return Maximum - Minimum;
        }
    }
}
