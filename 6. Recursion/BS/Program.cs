int[] arr = { 1, 2, 4, 9, 10, 15, 17 };
int target = 2;

Console.WriteLine(BS(arr,target,0, arr.Length));

static int BS(int[] arr, int target, int s , int e)
{
    if (s > e)
    {
        return -1;
    }

    int mid = s + (e - s) / 2;

    if (arr[mid] == target)
    {
        return mid;
    }
    if(target < arr[mid])
    {
        return BS(arr,target,s,mid-1);
    }
    return BS(arr,target,mid-1,e);
}
