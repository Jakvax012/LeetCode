public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numMap = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            int neededNum = target - nums[i];

            if (numMap.TryGetValue(neededNum, out int neededNumIndex)) {
                int[] indexes = [neededNumIndex, i];
                return indexes;
            }
            numMap[nums[i]] = i;
            //numMap.Add(nums[i], i); -> cannot use in the case that there are more same numbers in nums array
        }
    return null;
    }
}