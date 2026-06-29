public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int left = 1;
        int right = piles.Max();

        while(left<right)
        {
            int mid = left + (right -left)/2;
            
            long totalHours =0;
            foreach(int pile in piles)
            {
                totalHours += (long)Math.Ceiling((double)pile/mid);
            }

            if(totalHours<=h)
                right =mid;

            else
                left =mid+1;

        }

        return left;


    }
}
