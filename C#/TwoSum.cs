public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int seek = target - nums[i];
            if (dict.ContainsKey(seek)) {
                return new int[] { i, dict[seek] };
            }
            else 
            {
                dict[nums[i]] = i;
            }
        }

        return new int[] {};
    }
}