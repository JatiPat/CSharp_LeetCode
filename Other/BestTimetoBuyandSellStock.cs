public class Solution {
    public int MaxProfit(int[] prices) {
        int minimumValue = 10000; //set min to the biggest value to be a base case
        int maximumProfit = 0; //lowest profit can go (base case)

       for(int i = 0; i < prices.Length; i++){
           if (prices[i] < minimumValue){
               minimumValue = prices[i]; //if the next price is smaller than the first minimumValue, it becomes the new minimumValue
           } else if(prices[i] - minimumValue > maximumProfit) { 
               maximumProfit = prices[i] - minimumValue; //if the the next price minus the minimumValue is greater than the first maximumProfit, make it the new maximumProfit
           }
       }

        return maximumProfit; //return final max profit
    }
}
