/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let j;
    for(let i = 0; i < nums.length; i++) {
        j = i + 1
        while(j < nums.length) {
            let ans = nums[i] + nums[j];
            if (ans === target) return [i, j];
            j++;
        }
    }
};