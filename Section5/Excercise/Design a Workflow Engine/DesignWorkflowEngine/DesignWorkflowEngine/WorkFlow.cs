// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace DesignWorkflowEngine
{
    public class WorkFlow
    {

        private readonly IList<IActivity> _activityList;
        

        public WorkFlow()       // cosructor of Workflow class 
        {
            _activityList = new List<IActivity>();
        }
        
        public void Run()
        {
            foreach (var activity in _activityList)
            {
                activity.Execute(new Message());
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activityList.Add(activity);
        }
    }
}


