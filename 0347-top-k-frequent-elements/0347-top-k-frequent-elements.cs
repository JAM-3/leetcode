public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numCounter = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(numCounter.ContainsKey(num)) {
                numCounter[num]++;
            }
            else {
                numCounter[num] = 1;
            }
        }
        int[] topKs = new int[k];
        int count = 0;
        while (count < k) {
            int maxVal = 0;
            int maxFreq = 0;
            foreach(int key in numCounter.Keys) {
                if (numCounter[key] > maxVal) {
                     maxVal = numCounter[key];
                     maxFreq = key;
                }
            }
            topKs[count] = maxFreq;
            numCounter.Remove(maxFreq);
            count++;
        }
        return topKs;
    }
}