public class Solution {
    public void Rotate(int[] nums, int k) {
        //Useful link: https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-7.0
         Array.Reverse( nums ); // Reverse the whole array first [1,2,3,4,5,6,7] -> [7,6,5,4,3,2,1]
         Array.Reverse( nums, 0, k ); //Reverse the elments from 0 to k (3 in this case), so [5,6,7,4,3,2,1]
         Array.Reverse( nums, k, nums.Length-k ); //Reverse the rest of the elements back to its normal order [5,6,7,1,2,3,4]

    }
}
