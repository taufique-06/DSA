//If it is something with sorted array, try Binary Search first. 

//First Question: Ceiling of a Number

//Ceiling of a given number means find the smallest element in array greater or equal to target. 
//Consider the below array. If it's been told that the target element is 10. Then your answer should be 10. What if it's been told
//that the target element is 11. In our case, there is no 11. So what is the next greater element in this array? 14. So answer should be 14.

int[] arr = { 2, 3, 5, 6, 10, 14, 16, 18, 20 };
int target = 1;

Console.WriteLine(ceilingOfAGivenNumber(arr, target));
Console.WriteLine(floorOfAGivenNumber(arr,target));

static int ceilingOfAGivenNumber(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length -1;

    if (target > arr[arr.Length - 1]) return -1;

    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (arr[mid] < target)
        {
            start = mid + 1;
        }
        else if(arr[mid] > target)
        {
            end = mid - 1;
        }
        else
        {
            return mid;
        }
    }
    return start;
}

//Second Question: Find the floor of a Number

// Floor means find the greatest number smaller or target
//Consider the above array. If it's been told that the target element is 10. Then your answer should be 10. What if it's been told
//that the target element is 11. In our case, there is no 11. So what is the next greatest smaller element in this array? 10.
//So answer should be 10.

static int floorOfAGivenNumber(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length - 1;

    if (target < arr[0]) return -1;
    while (start <= end)
    {
        int mid = start + (end - start) / 2;

        if (arr[mid] < target)
        {
            start = mid + 1;
        }
        else if (arr[mid] > target)
        {
            end = mid - 1;
        }
        else
        {
            return mid;
        }
    }
    return end;
}