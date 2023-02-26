using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for shaker sort
    internal class StrategyShakerSort : IStrategySort
    {
        //Shaker sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            int leftMark = 1;
            int rightMark = arr.Length - 1;
            operationCount += 2;//assignment

            operationCount++;//while if
            while (leftMark <= rightMark)
            {
                operationCount++;//i=rightMark
                for (int i = rightMark; i >= leftMark; i--)
                {
                    operationCount++;//i--

                    operationCount++;//if
                    if (arr[i - 1].CompareTo(arr[i]) > 0)
                    {
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                        operationCount++;//swap
                    }

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                leftMark++;
                operationCount++;//leftMark++

                operationCount++;//i=leftMark
                for (int i = leftMark; i <= rightMark; i++)
                {
                    operationCount++;//i++

                    operationCount++;//if
                    if (arr[i - 1].CompareTo(arr[i]) > 0)
                    {
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                        operationCount++;//swap
                    }

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                rightMark--;
                operationCount++;//rightMark--

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            return operationCount;
        }

        //Shaker sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            //Operation count
            int operationCount = 0;

            int leftMark = 1;
            int rightMark = arr.Length - 1;
            operationCount += 2;//assignment

            operationCount++;//while if
            while (leftMark <= rightMark)
            {
                operationCount++;//i=rightMark
                for (int i = rightMark; i >= leftMark; i--)
                {
                    operationCount++;//i--

                    operationCount++;//if
                    if (arr[i - 1].CompareTo(arr[i]) < 0)
                    {
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                        operationCount++;//swap
                    }

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                leftMark++;
                operationCount++;//leftMark++

                operationCount++;//i=leftMark
                for (int i = leftMark; i <= rightMark; i++)
                {
                    operationCount++;//i++

                    operationCount++;//if
                    if (arr[i - 1].CompareTo(arr[i]) < 0)
                    {
                        (arr[i - 1], arr[i]) = (arr[i], arr[i - 1]);
                        operationCount++;//swap
                    }

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                rightMark--;
                operationCount++;//rightMark--

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            return operationCount;
        }
    }
}
