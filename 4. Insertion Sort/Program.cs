int[] arr = {3,4,-8,0,45,1 };
InsertionSort(arr);
Array.ForEach(arr, Console.WriteLine);


static void InsertionSort(int[] arr)
{
	for (int i = 0; i < arr.Length - 1; i++)
	{
		for (int j = i+1; j >0; j--)
		{
			if (arr[j] < arr[j - 1])
			{
				int temp = arr[j];
				arr[j] = arr[j - 1];
				arr[j - 1] = temp;
			}else
			{
                break;
            }

		}
	}
}
