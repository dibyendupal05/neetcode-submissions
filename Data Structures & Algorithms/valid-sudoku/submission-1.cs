public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        //Prefix Product

        result[0] =1;
        for(int i=1;i<nums.Length;i++)
        {
            result[i] = nums[i-1]*result[i-1];

        }

        //Suffix Pass
        int suffixProduct =1;
        for(int j=nums.Length-1;j>=0;j--)
        {
            result[j]=result[j]*suffixProduct;
            suffixProduct= suffixProduct*nums[j];
        }

        return result;
    }
}
