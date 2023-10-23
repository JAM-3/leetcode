public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int pointerA = 0;
        int pointerB = nums.Length-1;

        while (pointerA < nums.Length) {
            while(pointerA != pointerB) {
            if (nums[pointerA] + nums[pointerB] == target) return new int[]{pointerA, pointerB};
            pointerB--;
            }
            pointerA++;
            pointerB = nums.Length-1;
        }
        return null;        
    }
}