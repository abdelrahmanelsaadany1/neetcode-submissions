public class Solution {
    public int MaxProfit(int[] prices) {
        int left =0 ;
        int right=1;
        int max=0;
        while(right<prices.Length){
            if(prices[right]>prices[left]){
          int profit=prices[right]-prices[left];
            max=Math.Max(profit,max);
            }
            else{
                left=right;
            }
            right++;
           
        }
        return max;

    }
}
