

using System.Collections;


namespace StackDesign
{
    public class Stack
    {
        ArrayList stack = new ArrayList();
        public object pop=0;        //if we do not declare k as object 

        

        internal void Push()
        {
            throw new InvalidOperationException();
        }

        public void Push(Object obj)
        {
            stack.Add(obj);
            //Console.WriteLine(stack.Count);
        }
        
        public object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            pop = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return pop; 
               
        }

        /*
        public int Count()
        {
            return stack.Count;      //if this Count method is not described here
                                     //in stack, stack1.Count will not be available
                                     //in Main method
                                     
        }
        */


        public void Clear()
        {
            stack.Clear();
        }

       
    }
}




//Here if we have not added the Count method inside the Stack Class, stack1 would
//not have the Count method in it.  