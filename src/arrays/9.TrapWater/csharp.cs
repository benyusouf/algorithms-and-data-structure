public class Solution {
    public int Trap(int[] heights) {        
//         int totalWater = 0;
        
//         for(int i = 0; i < heights.Length; i++){
//             int maxLeft = int.MinValue, maxRight = int.MinValue, currentWater = 0;
            
//             for(int j = i; j < heights.Length; j++){
//                 maxRight = Math.Max(maxRight, heights[j]);
//             }
            
//             for(int j = i; j >= 0; j--){
//                 maxLeft = Math.Max(maxLeft, heights[j]);
//             }
            
//             currentWater = Math.Min(maxLeft, maxRight) - heights[i];
            
//             if(currentWater > 0){
//                 totalWater += currentWater;
//             }
//         }
        
//         return totalWater;
        
//         int totalWater = 0, maxLeft = int.MinValue, maxRight = int.MinValue, left = 0, right = heights.Length - 1;
        
//         while(left < right){
//             if(heights[left] < heights[right]){
//                 if(maxLeft > heights[left]){
//                     totalWater += maxLeft - heights[left];
//                 }
//                 else{
//                     maxLeft = heights[left];
//                 }
//                 left++;
//             }
//             else{
//                 if(maxRight > heights[right]){
//                     totalWater += maxRight - heights[right];
//                 }
//                 else{
//                     maxRight = heights[right];
//                 }
//                 right--;
//             }
//         }
        
//         return totalWater;
        
        int capacity = 0, left = 0, right = heights.Length - 1, leftMax = int.MinValue, rightMax = int.MinValue;
        
        while(left < right){
            leftMax = Math.Max(leftMax, heights[left]);
            rightMax = Math.Max(rightMax, heights[right]);
            
            if(leftMax < rightMax){
                capacity += leftMax - heights[left];
                left++;
            }
            else{
                capacity += rightMax - heights[right];
                right--;
            }
        }
        
        return capacity;
    }
}