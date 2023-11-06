public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0; //need a value to store the amount of elements not equal to val

        for (int a=0; a<nums.Length; a++){ //loop through nums
            if (nums[a] != val){ //if element is not val, add it to the begnning
                nums[k] = nums[a]; 
                k++; //increment k 
            }
        }
        return k; //the size of the new array
    }
}
