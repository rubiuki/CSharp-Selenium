namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int[] MoveZeroes(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                        MoveZeroToEnd(nums, i);
                }
                return nums;
            }
            static void MoveZeroToEnd(int[] nums, int index)
            {
                for (int i = index; i < nums.Length - 1; i++)
                {
                    int temp = nums[i]; 
                    nums[i] = nums[i + 1]; 
                    nums[i + 1] = temp;
                }
            }

            int[] nums = { 0, 0, 8, 5, 0, 8, 5, 0, 5, 9, 8 };

            int [] x = MoveZeroes(nums);
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        
        }
    }
}