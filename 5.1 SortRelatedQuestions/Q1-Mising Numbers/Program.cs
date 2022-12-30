//https://leetcode.com/problems/missing-number/
int[] arr = {3, 0, 1};
Console.WriteLine(MissingNumberWithCyclicSort(arr));


static int MissingNumberWithCyclicSort(int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        int currentIndex = nums[i];
        if (nums[i] < nums.Length && nums[i] != nums[currentIndex])
        {
            int temp = nums[i];
            nums[i] = nums[currentIndex];
            nums[currentIndex] = temp;
        }
        else
        {
            i++;
        }
    }

    //now loop through to find the missing numbers
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != j)
        {
            return j;
        }
    }
    return nums.Length;
}

