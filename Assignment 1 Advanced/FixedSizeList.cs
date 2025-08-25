namespace Assignment_1_Advanced
{
    internal class FixedSizeList<T>
    {
        private readonly int capacity;
        private List<T> list;
        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            list = new List<T>(capacity);
        }
        public void Add(T item)
        {
            if (list.Count < capacity)
            {
                list.Add(item);
            }
            else
            {
                throw new InvalidOperationException($"Cannot add more elements. The list has reached its fixed capacity of {capacity}.");
            }
        }
        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index),$"Invalid index {index}. Valid range is [0..{list.Count - 1}].");
            }
            return list[index];
        }
    }
}
