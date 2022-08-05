


namespace DesignWorkflowEngine
{
    public interface IWorkflow 
    {
        void AddActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}





// Here IWorkFLow interface will ensure that WorkFlow class have these two methods




// Here IENumerable List was added later on 

// IEnumerable interface is used when we want to iterate among our classes
// using a foreach loop.