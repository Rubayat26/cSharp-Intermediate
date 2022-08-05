// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DesignWorkflowEngine
{
    public class GoForAWalk : IActivity
    {
        public void Execute(Message message)
        {
            Console.WriteLine("Go for a walk");
        }
    }
}


