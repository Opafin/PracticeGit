namespace WeekTwo
{
    public interface IWorkFlow
    {
        public void Execute();
    }

    public class GreatWorkFlow : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Great results and great well being");
        }
    }

    public class Workflow : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Average results and average wellbeing");
        }
    }

    public class WorkFlowEngine
    {
        private readonly IList<IWorkFlow> workFlows;
        public void RegisterWorkFlows(IWorkFlow workFlow)
        {
            workFlows.Add(workFlow);
        }

        public WorkFlowEngine()
        {
            workFlows = new List<IWorkFlow>();
        }
        public void Run()
        {
            foreach (IWorkFlow flow in workFlows)
                flow.Execute();
        }
    }
}

// Main 
/* var engine = new WorkFlowEngine();
   engine.RegisterWorkFlows(new GreatWorkFlow());
   engine.RegisterWorkFlows(new Workflow());
   engine.Run(); */
