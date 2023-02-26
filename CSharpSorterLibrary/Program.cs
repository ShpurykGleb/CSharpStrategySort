using CSharpSorterLibrary.Context;
using CSharpSorterLibrary.Strategys;

int[] arr = new int[10];

Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(101);
}

Context context = new Context(new StrategyQuickSort());
Console.WriteLine(context.ExecuteSortAscending(arr));

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}