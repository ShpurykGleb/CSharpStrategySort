using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for megre sort
    internal class StrategyMergeSort : IStrategySort
    {
        //Merge ascending
        private static void MergeAscending<T>(T[] arr, int lowIndex, int middleIndex, int highIndex, ref int operationCount) where T : IComparable<T>
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new T[highIndex - lowIndex + 1];
            var index = 0;
            operationCount += 4;//assignments

            operationCount++;//if
            while (left <= middleIndex && right <= highIndex)
            {
                operationCount++;//if
                if (arr[left].CompareTo(arr[right]) < 0)
                {
                    tempArray[index] = arr[left];
                    left++;
                    operationCount += 2;//assignment,left++
                }
                else
                {
                    tempArray[index] = arr[right];
                    right++;
                    operationCount += 2;//assignment,right++
                }

                index++;
                operationCount++;//index++

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            operationCount++;//i=left
            for (var i = left; i <= middleIndex; i++)
            {
                operationCount++;//i++

                tempArray[index] = arr[i];
                index++;
                operationCount += 2;//assignment,index++

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            operationCount++;//i=right
            for (var i = right; i <= highIndex; i++)
            {
                operationCount++;//i++

                tempArray[index] = arr[i];
                index++;
                operationCount += 2;//assignment,index++

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            operationCount++;//i=0
            for (var i = 0; i < tempArray.Length; i++)
            {
                operationCount++;//i++

                arr[lowIndex + i] = tempArray[i];
                operationCount++;//swap

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit
        }

        //Merge sort ascending
        private int MergeSortAscending<T>(ref T[] arr, int lowIndex, int highIndex, ref int operationCount) where T : IComparable<T>
        {
            operationCount++;//if
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                operationCount++;//assignment

                operationCount++;//function call
                MergeSortAscending(ref arr, lowIndex, middleIndex, ref operationCount);
                operationCount++;//function call
                MergeSortAscending(ref arr, middleIndex + 1, highIndex, ref operationCount);
                operationCount++;//function call
                MergeAscending(arr, lowIndex, middleIndex, highIndex, ref operationCount);
            }

            return operationCount;
        }

        //Sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            MergeSortAscending(ref arr, 0, arr.Length - 1, ref operationCount);
            return operationCount;
        }

        //Merge descending
        private static void MergeDescending<T>(T[] arr, int lowIndex, int middleIndex, int highIndex, ref int operationCount) where T : IComparable<T>
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new T[highIndex - lowIndex + 1];
            var index = 0;
            operationCount += 4;//assignments

            operationCount++;//if
            while (left <= middleIndex && right <= highIndex)
            {
                operationCount++;//if
                if (arr[left].CompareTo(arr[right]) > 0)
                {
                    tempArray[index] = arr[left];
                    left++;
                    operationCount += 2;//assignment,left++
                }
                else
                {
                    tempArray[index] = arr[right];
                    right++;
                    operationCount += 2;//assignment,right++
                }

                index++;
                operationCount++;//index++

                operationCount++;//while loop jump
            }
            operationCount++;//while loop exit

            operationCount++;//i=left
            for (var i = left; i <= middleIndex; i++)
            {
                operationCount++;//i++

                tempArray[index] = arr[i];
                index++;
                operationCount += 2;//assignment,index++

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            operationCount++;//i=right
            for (var i = right; i <= highIndex; i++)
            {
                operationCount++;//i++

                tempArray[index] = arr[i];
                index++;
                operationCount += 2;//assignment,index++

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            operationCount++;//i=0
            for (var i = 0; i < tempArray.Length; i++)
            {
                operationCount++;//i++

                arr[lowIndex + i] = tempArray[i];
                operationCount++;//swap

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit
        }

        //Merge sort descending
        private int MergeSortDescending<T>(ref T[] arr, int lowIndex, int highIndex, ref int operationCount) where T : IComparable<T>
        {
            operationCount++;//if
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                operationCount++;//assignment

                operationCount++;//function call
                MergeSortDescending(ref arr, lowIndex, middleIndex, ref operationCount);
                operationCount++;//function call
                MergeSortDescending(ref arr, middleIndex + 1, highIndex, ref operationCount);
                operationCount++;//function call
                MergeDescending(arr, lowIndex, middleIndex, highIndex, ref operationCount);
            }

            return operationCount;
        }

        //Sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;
            MergeSortDescending(ref arr, 0, arr.Length - 1, ref operationCount);
            return operationCount;
        }
    }
}
