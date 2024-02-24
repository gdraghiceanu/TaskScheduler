using Quartz;

namespace QuartzProject.Quartz
{
    [DisallowConcurrentExecution]
    public class DemoJob : IJob
    {
        public DemoJob()
        {
                
        }

        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Job started at {DateTime.Now:U}");
            return Task.CompletedTask;
        }
    }
}
