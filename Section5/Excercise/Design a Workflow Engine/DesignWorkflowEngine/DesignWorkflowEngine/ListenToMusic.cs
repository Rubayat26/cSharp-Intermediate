// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DesignWorkflowEngine
{
    public class ListenToMusic : IActivity
    {
        public void Execute(Message message)
        {
            Console.WriteLine("Listen to music");
        }
    }
}


