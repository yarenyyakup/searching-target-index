public class Solution
{
    public int Search(int[] nums, int target)
    {



        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;

            }



        }


        return -1;

    }

    public static void Main(string[] args)
    {
        int[] str = new int[] { -1, 0, 3, 5, 9, 12 };
        int x = 7;
        Solution s = new Solution();
        Console.WriteLine(s.Search(str, x));
    }
}