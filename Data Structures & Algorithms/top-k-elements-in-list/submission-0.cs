public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequencies = new Dictionary<int,int>();

        //fill the dictionary with the frequency of each element
        foreach(int num in nums)
        {
            frequencies[num] = frequencies.GetValueOrDefault(num,0)+1;
        }

        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        foreach(var kvp in frequencies)
        {
            minHeap.Enqueue(kvp.Key,kvp.Value);

            if(minHeap.Count>k)
            {
                minHeap.Dequeue();
            }
        }

        int[] result =new int[k];
        for(int i=0;i<k;i++)
        {
            result[i]=minHeap.Dequeue();
        }

        return result; 


    }
}
