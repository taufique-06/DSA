//int[] nums = { 1, 2, 2, 4 };
int[] nums = { 2, 1, 4, 2, 6, 5 };

FindErrorNums(nums);

static int[] FindErrorNums(int[] nums)
{
    int i = 0;
    while(i < nums.Length)
    {
        int current = nums[i]-1;
        if (nums[i] != nums[current])
        {
            int temp = nums[i];
            nums[i] = nums[current];
            nums[current] = temp;
        }
        else
        {
            i++;
        }
    }

    List<int> list = new List<int>();
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != j+1)
        {
            list.Add(nums[j]);
            list.Add(j+1);

        }
    }

    var result = list.ToArray();
    return result;
}
