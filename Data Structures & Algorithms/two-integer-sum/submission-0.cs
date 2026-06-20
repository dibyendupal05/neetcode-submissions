public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (seenNumbers.ContainsKey(complement)) {
                return new int[] { seenNumbers[complement], i };
            }
            seenNumbers[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
