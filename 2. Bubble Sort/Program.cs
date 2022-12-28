//Bubble Sort

int[] arr = { 3, 1, 5,0,-43 };
BubbleSort(arr);

static void BubbleSort(int[] arr)
{
	Boolean swapped;
	for (int i = 0; i < arr.Length; i++)
	{
		swapped = false;
		//Why arr.length - i? Because you dont wanna check the last element as it is already sorted. With every pass, the largest element will go to the end. 
		for (int j = 1; j < arr.Length - i; j++)
		{
			//swap the value if the item is smaller than the previous one
			if (arr[j] < arr[j - 1])
			{
				int temp = arr[j];
				arr[j] = arr[j - 1];
				arr[j - 1] = temp;
				swapped = true;
			}
		}
		if(!swapped) break;
	}

    Array.ForEach(arr, Console.WriteLine);
}