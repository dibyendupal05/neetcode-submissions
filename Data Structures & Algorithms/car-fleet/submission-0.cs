public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        if(n==0) return 0;

        (int pos, int speed)[] cars = new(int pos, int speed)[n] ;

        for(int i=0;i<n;i++)
        {
            cars[i] = (position[i],speed[i]);
        }

        //sorting
        Array.Sort(cars,(a,b)=>b.pos.CompareTo(a.pos));

        Stack<double> fleetTimes = new ();

        foreach(var car in cars )
        {
            double time = (double)(target -car.pos)/ car.speed;

            if(fleetTimes.Count==0 || time > fleetTimes.Peek())
                fleetTimes.Push(time);
        }

        return fleetTimes.Count ;

    }
}
