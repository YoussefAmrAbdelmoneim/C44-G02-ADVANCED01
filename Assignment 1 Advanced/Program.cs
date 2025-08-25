using System.Collections;

namespace Assignment_1_Advanced
{
    internal class Program
    {
        #region Q2
        //public static void ReversedArrayList(ArrayList? arrayList)
        //{
        //    for (int i = (arrayList?.Count - 1) ?? 0; i >= 0; i--)
        //    {
        //        Console.WriteLine((int?)arrayList?[i] ?? 0);
        //    }
        //}
        #endregion
        #region Q3
        //public static List<int> EvenNumbersList(List<int> list)
        //{
        //    List<int> evenList = new List<int>();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] % 2 == 0)
        //        {
        //            evenList.Add(list[i]);
        //        }
        //    }
        //    return evenList;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Range<int> range = new Range<int>(1,10);
            //bool isAvailable = range.IsInRange(5);
            //Console.WriteLine(isAvailable);
            //int rangeNumbers = range.Length();
            //Console.WriteLine(rangeNumbers);
            #endregion
            #region Q2
            //ArrayList arrayList = new ArrayList() { 1,2,3,4,5};
            //ReversedArrayList(arrayList);
            #endregion
            #region Q3
            //List<int> list = new List<int>() {0,1,2,3,4,5,6};
            //List<int> evenList= EvenNumbersList(list);
            //foreach (int item in evenList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(5);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(4);
            //Console.WriteLine(fixedSizeList.Get(2));
            #endregion
        }
        }
}
