// If you wanna use the binary search, the array has to be sorted;

int[] arrAscending = { 2, 5, 6, 10, 11, 15, 17, 18, 45, 50 };
int[] arrDescending = { 50, 45, 30, 20, 10, 8, 5, 2 };
int target = 10;

//Console.WriteLine(binarySearchForAscending(arrAscending, target));
//Console.WriteLine(binarySearchForDescending(arrDescending, target));
Console.WriteLine(orderAgnosticBinarySearch(arrDescending,target));

static int binarySearchForAscending(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (target < arr[mid])
        {
            end = mid - 1;
        }else if(target > arr[mid])
        {
            start = mid + 1;
        }else
        {
            return mid;
        }
    }


    return -1;
}


static int binarySearchForDescending(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (target < arr[mid])
        {
            start = mid + 1;
        }
        else if (target > arr[mid])
        {
            end = mid - 1;
        }
        else
        {
            return mid;
        }
    }


    return -1;
}

// Order-Agnostic Binary Search - if you dont know whether the array sorted in descending or ascending, how you gonna implement binary search.

//In terms of Order-Agnostic Binary Search, you need to find out whether the array is sorted descending or ascending order first

static int orderAgnosticBinarySearch(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length - 1;
    Boolean isAsc = arr[start] < arr[end] ? true : false;

    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (arr[mid] == target)
        {
            return mid;
        }

        if (isAsc)
        {
            if (target < arr[mid])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        else
        {
            if (target < arr[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
    }

    return -1;
}