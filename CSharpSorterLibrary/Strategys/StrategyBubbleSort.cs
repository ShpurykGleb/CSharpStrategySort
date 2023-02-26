using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for bubble sort
    internal class StrategyBubbleSort : IStrategySort
    {
        //Bubble sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            operationCount++;//i=0

            for (int i = 0; i < arr.Length - 1; i++)
            {
                operationCount++;//i++

                operationCount++;//j=0
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    operationCount++;//j++

                    operationCount++;//if
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                        operationCount++;//swap
                    }

                    operationCount++;//j loop jump
                }
                operationCount++;//j loop exit

                operationCount++;//i loop jump
            }
            operationCount++;//i loop exit

            return operationCount;
        }

        //Bubble sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            operationCount++;//i=0

            for (int i = 0; i < arr.Length - 1; i++)
            {
                operationCount++;//i++

                operationCount++;//j=0
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    operationCount++;//j++

                    operationCount++;//if
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                        operationCount++;//swap
                    }

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
