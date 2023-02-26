using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for insertion sort
    internal class StrategyInsertionSort : IStrategySort
    {
        //Insertion sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            operationCount++;//i=1
            for (int i = 1; i < arr.Length; i++)
            {
                operationCount++;//i++

                operationCount += 2;//j=i,if
                for (int j = i; j > 0 && arr[j - 1].CompareTo(arr[j]) > 0; j--)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    operationCount++;//swap

                    operationCount++;//j loop jump
                }
                operationCount++;//j loop exit

                operationCount++;//i loop jump
            }
            operationCount++;//i loop exit

            return operationCount;
        }

        //Insertion sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            operationCount++;//i=1
            for (int i = 1; i < arr.Length; i++)
            {
                operationCount++;//i++

                operationCount += 2;//j=i,if
                for (int j = i; j > 0 && arr[j - 1].CompareTo(arr[j]) < 0; j--)
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    operationCount++;//swap

                    operationCount++;//j loop jump
                }
                operationCount++;//j loop exit

                operationCount++;//i loop jump
            }
            operationCount++;//i loop exit

            return operationCount;
        }
    }
}
