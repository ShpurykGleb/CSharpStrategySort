using CSharpSorterLibrary.Interfaces;

namespace CSharpSorterLibrary.Strategys
{
    //Strategy for shell sort
    internal class StrategyShellSort : IStrategySort
    {
        //Shell sort ascending
        public int SortAscending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;

            int i, j, step;

            operationCount++;//step=arr.Length / 2
            for (step = arr.Length / 2; step > 0; step /= 2)
            {
                operationCount++;//step/=2

                operationCount++;//i=step
                for (i = step; i < arr.Length; i++)
                {
                    operationCount++;//i++

                    T tmp = arr[i];
                    operationCount++;//assignment

                    operationCount++;//j=i
                    for (j = i; j >= step; j -= step)
                    {
                        operationCount++;//j-=step

                        operationCount++;//if
                        if (tmp.CompareTo(arr[j - step]) < 0)
                        {
                            arr[j] = arr[j - step];
                        }
                        else
                        {
                            break;
                        }

                        operationCount++;//for loop jump
                    }
                    operationCount++;//for loop exit

                    arr[j] = tmp;
                    operationCount++;//swap

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            return operationCount;
        }

        //Shell sort descending
        public int SortDescending<T>(T[] arr) where T : IComparable<T>
        {
            int operationCount = 0;

            int i, j, step;

            operationCount++;//step=arr.Length / 2
            for (step = arr.Length / 2; step > 0; step /= 2)
            {
                operationCount++;//step/=2

                operationCount++;//i=step
                for (i = step; i < arr.Length; i++)
                {
                    operationCount++;//i++

                    T tmp = arr[i];
                    operationCount++;//assignment

                    operationCount++;//j=i
                    for (j = i; j >= step; j -= step)
                    {
                        operationCount++;//j-=step

                        operationCount++;//if
                        if (tmp.CompareTo(arr[j - step]) > 0)
                        {
                            arr[j] = arr[j - step];
                        }
                        else
                        {
                            break;
                        }

                        operationCount++;//for loop jump
                    }
                    operationCount++;//for loop exit

                    arr[j] = tmp;
                    operationCount++;//swap

                    operationCount++;//for loop jump
                }
                operationCount++;//for loop exit

                operationCount++;//for loop jump
            }
            operationCount++;//for loop exit

            return operationCount;
        }
    }
}
