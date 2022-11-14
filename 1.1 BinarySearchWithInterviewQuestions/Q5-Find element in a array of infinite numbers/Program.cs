//Find position of an element in a sorted array of infinite numbers

//Since array is sorted, the first thing clicks into mind is binary search, but the problem here is that we don’t know size of array. 
//If the array is infinite, that means we don’t have proper bounds to apply binary search. So in order to find position of key,
//first we find bounds and then apply binary search algorithm.

int[] arr = { 2, 5, 7, 9, 11, 14, 17, 19, 22, 27, 30, 45, 50, 67 };
int target = 27;

Console.WriteLine(findTheStartAndStop(arr, target));


static int findTheStartAndStop(int[] arr, int target)
{
    //first find the range and start with a box of size 2
    int start = 0;
    int end = 1;

    while (target > arr[end])
    {
        int tempStart = end + 1;
        // find the size of your next box. Initially the box size was 2. 
        end =  end + (end - start + 1) *2;
        start = tempStart;
    }

    return binarySearch(arr, target, start, end);
}


static int binarySearch(int[] arr, int target, int start, int end)
{
    while (start <= end)
    {
        int mid =  start + (end - start) / 2;

        if (target < arr[mid]) { end = mid - 1; }
        else if (target > arr[mid]) { start = mid + 1; }
        else { return mid; }
    }

    return -1;
}