//int[] nums = { 1, 3, 4, 2, 2 };
//int[] nums = { 3, 1, 3, 4, 2 };
int[] nums = { 1, 1 };
Console.WriteLine(FindDuplicate(nums));
//Array.ForEach(nums, Console.WriteLine);

static int FindDuplicate(int[] nums)
{
    int i =0;
    while(i < nums.Length)
    {
        int currentIndex = nums[i] - 1;
        if (nums[i] != nums[currentIndex])
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
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != j + 1)
        {
            return nums[j];
        }
    }
    return 0 ;
}

//Second way to find the duplicate

static int FindDuplicate2(int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        if (nums[i] != i + 1) 
        { 
            int currentIndex = nums[i] - 1;
            if (nums[i] != nums[currentIndex])
            {
                int temp = nums[i];
                nums[i] = nums[currentIndex];
                nums[currentIndex] = temp;
            }
            else
            {
                return nums[i];
            }
        }
        else
        {
            i++;
        }
    }
    return -1;
}