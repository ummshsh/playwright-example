using AspectInjector.Broker;

namespace Steps.BaseSteps
{
    [Aspect(Scope.Global)]
    [Injection(typeof(ReportingStepsAttribute))]
    [AttributeUsage(AttributeTargets.Class)]
    public class ReportingStepsAttribute : Attribute
    {
        [Advice(Kind.Before)]
        public void LogStep([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Calling '{name}' method...");
            // TODO: add integration with reporting tools
        }
    }
}