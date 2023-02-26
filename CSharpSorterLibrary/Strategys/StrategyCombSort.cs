using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for comb sort
    internal class StrategyCombSort : IStrategySort
    {
        //Comb sort ascending
        private static void CombSortAscending<T>(ref T[] arr, ref int operationCount) where T : IComparable<T>
        {
            double gap = arr.Length;
            bool swaps = true;
            operationCount += 2;//assignments

            operationCount++;//if
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                operationCount++;//assignment

                operationCount++;//if
                if (gap < 1)
                {
                    gap = 1;
                }

                int i = 0;
                swaps = false;
                operationCount += 2;//assignments

                operationCount++;//if
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    operationCount++;//assignment

                    operationCount++;//if
                    if (arr[i].CompareTo(arr[igap]) > 0)
                    {
                        (arr[igap], arr[i]) = (arr[i], arr[igap]);
                        swaps = true;
                        operationCount += 2;//assignments
                    }

                    ++i;
                    operationCount++;//++i

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit
        }

        //Sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            CombSortAscending(ref arr, ref operationCount);
            return operationCount;
        }

        //Comb sort descending
        private static void CombSortDescending<T>(ref T[] arr, ref int operationCount) where T : IComparable<T>
        {
            double gap = arr.Length;
            bool swaps = true;
            operationCount += 2;//assignments

            operationCount++;//if
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                operationCount++;//assignment

                operationCount++;//if
                if (gap < 1)
                {
                    gap = 1;
                }

                int i = 0;
                swaps = false;
                operationCount += 2;//assignments

                operationCount++;//if
                while (i + gap < arr.Length)
                {
                    int igap = i + (int)gap;
                    operationCount++;//assignment

                    operationCount++;//if
                    if (arr[i].CompareTo(arr[igap]) < 0)
                    {
                        (arr[igap], arr[i]) = (arr[i], arr[igap]);
                        swaps = true;
                        operationCount += 2;//assignments
                    }

                    ++i;
                    operationCount++;//++i

                    operationCount++;//while loop jump
                }
                operationCount++;//while loop exit

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit
        }

        //Sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            CombSortDescending(ref arr, ref operationCount);
            return operationCount;
        }
    }
}
