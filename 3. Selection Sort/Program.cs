int[] arr = { 4, 5, 1, 2,3 };

SelectionSort(arr);


static void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int last = arr.Length - i - 1;
        int maxIndex  = MaxIndex(arr, 0, last);
        int temp = arr[last];
        arr[last] = arr[maxIndex];
        arr[maxIndex] = temp;
    }

    Array.ForEach(arr, Console.WriteLine);
}

static int MaxIndex(int[] arr, int start, int end)
{
    int max = start;
    for (int i = start; i <= end; i++)
	{
        if (arr[max] < arr[i])
        {
            max = i;
		}
	}
    return max;
}
