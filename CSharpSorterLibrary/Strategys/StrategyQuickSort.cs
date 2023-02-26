using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for quick sort
    internal class StrategyQuickSort : IStrategySort
    {
        //Quick sort ascending
        private int QuickSortAscending<T>(T[] arr, int low, int high, ref int operationCount) where T : IComparable<T>
        {
            int i = low;
            int j = high;
            T middle = arr[(i + j) / 2];
            operationCount += 3;//assignments

            operationCount++;//while if
            while (i <= j)
            {
                operationCount++;//while if
                while (arr[i].CompareTo(middle) < 0)
                {
                    i++;
                    operationCount++;//i++

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//while if
                while (arr[j].CompareTo(middle) > 0)
                {
                    j--;
                    operationCount++;//j--

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//if
                if (i <= j)
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    i++;
                    j--;
                    operationCount += 3;//swap,i++,j--
                }

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            operationCount++;//if
            if (j > low)
            {
                operationCount++;//function call
                QuickSortAscending(arr, low, j, ref operationCount);
            }

            operationCount++;//if
            if (i < high)
            {
                operationCount++;//function call 
                QuickSortAscending(arr, i, high, ref operationCount);
            }

            return operationCount;
        }

        //Sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            QuickSortAscending(arr, 0, arr.Length - 1, ref operationCount);
            return operationCount;
        }

        //Quick sort descending
        private int QuickSortDescending<T>(T[] arr, int low, int high, ref int operationCount) where T : IComparable<T>
        {
            int i = low;
            int j = high;
            T middle = arr[(i + j) / 2];
            operationCount += 3;//assignments

            operationCount++;//while if
            while (i <= j)
            {
                operationCount++;//while if
                while (arr[i].CompareTo(middle) > 0)
                {
                    i++;
                    operationCount++;//i++

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//while if
                while (arr[j].CompareTo(middle) < 0)
                {
                    j--;
                    operationCount++;//j--

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//if
                if (i <= j)
                {
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                    i++;
                    j--;
                    operationCount += 3;//swap,i++,j--
                }

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            operationCount++;//if
            if (j > low)
            {
                operationCount++;//function call
                QuickSortDescending(arr, low, j, ref operationCount);
            }

            operationCount++;//if
            if (i < high)
            {
                operationCount++;//function call 
                QuickSortDescending(arr, i, high, ref operationCount);
            }

            return operationCount;
        }

        //Sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            QuickSortDescending(arr, 0, arr.Length - 1, ref operationCount);
            return operationCount;
        }

    }
}
