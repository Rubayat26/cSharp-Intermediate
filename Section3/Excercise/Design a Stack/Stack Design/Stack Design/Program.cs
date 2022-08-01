namespace StackDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
         // stack1.Push(); // throws exception


            //Console.WriteLine(stack1.Count) ; //if this Count method is not described here
                                               //in stack, stack1.Count will not be available
                                               //in Main method

            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
        //  Console.WriteLine(stack1.Pop());   //will throw exception, because empty stack

        }
    }
}




//Here if we have not added the Count method inside the Stack Class, stack1 would
//not have the Count method in it.  