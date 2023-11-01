public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       
    for(int i = 0; i < n; i++){ //add the values of nums2 to nums1. n is the max length of nums2
        
        nums1[m+i] = nums2[i]; //m+i means to add values after the max of nums1
        
    }

    Array.Sort(nums1); //use sort method to sort the array!

    }
}
