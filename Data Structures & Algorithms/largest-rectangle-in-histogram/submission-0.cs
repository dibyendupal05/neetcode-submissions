public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int maxArea =0;

        for(int i=0;i<=heights.Length;i++)
        {
            int currentHeight = i==heights.Length? 0 : heights[i];

            while (stack.Count>0 && currentHeight < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];
                int width = (stack.Count ==0)? i : i - stack.Peek() -1; //-1 because we only want elements within the boundary 
                //if stack is empty width extends till the begining of index 0

                maxArea = Math.Max(maxArea,height*width);

            }
            stack.Push(i);
        }

        return maxArea;
        
    }
}
