public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                
                // cannot use it twice
                if (i == j) {
                    continue;
                }

                // check if the sum is target
                if (nums[i] + nums[j] == target) {
                    int[] indexes = [i,j];
                    return indexes;
                }
            }
        }
    return null;
    }
}