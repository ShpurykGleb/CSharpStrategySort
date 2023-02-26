using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Context
{
    //Context for user interface
    internal class Context
    {
        //Sort strategy
        private IStrategySort _strategySort;

        //Parametric constructor
        public Context(IStrategySort strategySort)
        {
            _strategySort = strategySort;
        }

        //Strategy setter
        public void SetStrategy(IStrategySort strategySort)
        {
            _strategySort = strategySort;
        }

        //Execute sort ascending
        public int ExecuteSortAscending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = _strategySort.SortAscending(arr);
            return operationCount;
        }

        //Execute sort descending
        public int ExecuteSortDescending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = _strategySort.SortDescending(arr);
            return operationCount;
        }
    }
}
