int[] arr = { 3, 5, 2, 1, 4 };
CyclicSort(arr);
Array.ForEach(arr, Console.WriteLine);

static void CyclicSort(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        int correctIndex = arr[i] - 1;
        if(arr[i] != arr[correctIndex])
        {
            int temp = arr[i];
            arr[i] = arr[correctIndex];
            arr[correctIndex] = temp;
        }else
        {
            i++;
        }
    }
}
