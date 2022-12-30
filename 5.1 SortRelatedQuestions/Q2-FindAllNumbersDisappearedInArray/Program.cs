//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };

FindMissingNumbers(nums);


static List<int> FindMissingNumbers(int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        int currentIndex = nums[i] -1 ;
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
    List<int> result = new List<int>();
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != j+1) { result.Add(j+1); }
    }
    result.ForEach(Console.WriteLine);
    return result;
}