


namespace DesignWorkflowEngine
{
    public class Workflow : IWorkflow
    {

        private readonly IList<IActivity> _activityList;
        

        public Workflow()                       // cosructor of Workflow class 
        {
            _activityList = new List<IActivity>();
        }
        
       

        public void AddActivity(IActivity activity)
        {
            _activityList.Add(activity);
        }


        public IEnumerable<IActivity> GetActivities()
        {
            return _activityList;
        }


    }
}


//IEnumerable interface is used when we want to iterate among our classe
//using a foreach loop.


// We have to add this Ienumebrable to the IWorkflow interface otherwise 
// inside workflowengines Run method we will not have acces to
// the workflow.Getactivities().