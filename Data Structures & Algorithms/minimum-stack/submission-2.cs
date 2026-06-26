public class MinStack {
    private Stack<(int val,int min)> stack = new (); 
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(stack.Count==0)
            stack.Push((val,val));
        else{            
            stack.Push((val,Math.Min(val,stack.Peek().min)));
        }

    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().min;
    }
}
