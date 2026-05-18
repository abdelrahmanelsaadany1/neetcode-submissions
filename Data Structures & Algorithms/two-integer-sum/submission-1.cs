public class Solution {
   public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            int search = target - nums[i];

            if (dictionary.ContainsKey(search)) {
                return new int[] { dictionary[search], i };
            }

            dictionary[nums[i]] = i;
        }

        return new int[] { };
    }
}
