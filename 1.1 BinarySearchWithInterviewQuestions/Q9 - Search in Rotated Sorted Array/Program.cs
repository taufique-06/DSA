//Search in Rotated Sorted Array

//What is Rotated Array ?
//    -Let's Clear with a example
//    int[] arr = { 2, 4, 6, 8, 10, 12 } (This array is unrotated)
//    int[] arr = { 12, 2, 4, 6, 8, 10 } (This is the array after 1st rotation)
//    int[] arr = { 12, 10, 2, 4, 6, 8 } (This is the array after 2nd rotation) 

int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
int target = 3;

//In order to solve:

// 1. First find the pivot in the array which means find the largest number in the array. Pivot means it is number where the next numbers
// are in the ascending order.
Console.WriteLine(findPivot(nums));
Console.WriteLine(rotatedBinarySearch(nums,target)); 

static int rotatedBinarySearch(int[] arr, int target)
{
    int pivot = findPivot(arr);

    if (pivot == -1)
    {
        return binarySearch(arr, target, 0, arr.Length - 1);
    }
    else if (arr[pivot] == target)
    {
        return pivot;
    }
    else if (target >= arr[0])
    {
        return binarySearch(arr, target, 0, pivot - 1);
    }
        return binarySearch(arr, target, pivot + 1, arr.Length - 1);
}


static int binarySearch(int[] arr, int target, int start, int end)
{
    while (start <= end)
    {
        int mid = start + (end - start) / 2;  
        if (target < arr[mid])
        {
            end =  mid - 1;
        }
        else if (target > arr[mid])
        {
            start = mid + 1;
        }
        else
        {
            return mid;
        }
    }
    return -1;
}
static int findPivot(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start <= end)
    {
        int mid = start + (end-start) / 2;

        if (mid < end && arr[mid] > arr[mid + 1])
        {
            return mid;
        }
        else if (mid > start && arr[mid] < arr[mid -1])
        {
            return mid - 1;
        }
        else if(arr[mid] <= arr[start])
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }
    return -1;
}