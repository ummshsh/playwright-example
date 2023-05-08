using Steps.WebSteps;

namespace Steps.BaseSteps
{
    public static class Do
    {
        private static Lazy<PlaywrightPageSteps> playwrightPageSteps = new Lazy<PlaywrightPageSteps>();
        public static PlaywrightPageSteps PlaywrightPage => playwrightPageSteps.Value;
    }
}
