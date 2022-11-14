//Find the Smallest letter greater than the target

//Given a charcters array letters that is sorted in non-decreasing(Ascending) order and a character target, return the smallest character 
//in the array that is larger than the target

char[] arr = { 'c', 'f', 'j' };
char target = 'j';

Console.WriteLine(findingSmallestLetter(arr,target));

static char findingSmallestLetter(char[] arr, char target)
{
    int start = 0;
    int end = arr.Length - 1;

    while(start <= end)
    {
        int mid = start + (end - start)/2;

        if (target > arr[mid])
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        } 
    }
    return arr[start % arr.Length];
}