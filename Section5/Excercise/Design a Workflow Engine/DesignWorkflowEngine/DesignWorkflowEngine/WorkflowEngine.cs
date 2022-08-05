


namespace DesignWorkflowEngine
{
    public class WorkflowEngine : IWorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute(new Message());
           }
        }
    }
}




// To get access to GetACtivities method we nee to implement Ienumerable inside
// IWorkflow interface otherwise this method this method will not be available 
