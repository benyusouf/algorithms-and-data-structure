/*
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/
/// <summary>
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
/// </summary>

public class Solution {
    public int MaxProfit(int[] prices) {
        int leastPrice = int.MaxValue;
        int curProfit = 0;
        int maxProfit = 0;
        
        for(int i = 0; i < prices.Length; i++){
            leastPrice = Math.Min(leastPrice, prices[i]);
            
            curProfit = prices[i] - leastPrice;
            
            maxProfit = Math.Max(maxProfit, curProfit);
        }
        
        return maxProfit;
    }
}