public class TimeMap {

    private class TimeEntry {

        public string Value {get;set;}
        public int TimeStamp{get;set;}

        public TimeEntry(string value,int timestamp)
        {
            this.Value = value;
            this.TimeStamp= timestamp;
        }        
        
    }

    private Dictionary<string, List<TimeEntry>> _store;

    public TimeMap() {
        _store = new Dictionary<string,List<TimeEntry>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!_store.ContainsKey(key))
        {
            _store[key] = new List<TimeEntry>();

        }
        _store[key].Add(new TimeEntry(value,timestamp));
    }
    
    public string Get(string key, int timestamp) {

        if(!_store.ContainsKey(key))
        {
            return "";
        }

        List<TimeEntry> entries = _store[key];

        int left =0;
        int right = entries.Count -1;
        string result="";

        while(left<=right)
        {
            int mid = left +(right-left)/2;
            
            if(entries[mid].TimeStamp <= timestamp)
            {
                result = entries[mid].Value;
                left = mid +1;
            }
            else
            {
                right = mid -1;
            }

        }

        return result;
    }
}
