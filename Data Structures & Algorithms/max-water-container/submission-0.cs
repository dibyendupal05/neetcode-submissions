public class Solution {
    public int MaxArea(int[] heights) {
        int left=0;
        int right =heights.Length -1;
        int maxArea=0;

        while(left<right)
        {
            int breadth=(right-left);
            int length =0;
            if(heights[left]<heights[right])
            {
                length=heights[left];
                left++;
            }
            else if(heights[left]>heights[right])
            {
                length=heights[right];
                right--;
            }
            else if(heights[left]==heights[right])
            {
                length=heights[right];
                right--;
                left++;
            }

            maxArea =Math.Max(breadth*length,maxArea);
        }
        return maxArea;
    }
}
