namespace CSharpSorterLibrary.Interfaces
{
    internal interface IStrategySort
    {
        int SortAscending<T>(T[] arr) where T : IComparable<T>;
        int SortDescending<T>(T[] arr) where T : IComparable<T>;
    }
}
