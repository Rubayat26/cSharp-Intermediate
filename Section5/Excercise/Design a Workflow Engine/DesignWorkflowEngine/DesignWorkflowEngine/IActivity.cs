// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DesignWorkflowEngine
{
    public interface IActivity
    {
        void Execute(Message message); // here the Execute method just make sure
                                       // whenever any class is linked with the 
                                       // IActivity interface it has to have the 
                                       // Public void Eexecute method in it 
    }
}


