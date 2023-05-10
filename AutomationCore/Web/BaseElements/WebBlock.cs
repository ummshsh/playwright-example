using Microsoft.Playwright;

namespace AutomationCore.Web.Elements
{
    public class WebBlock
    {
        public IPage ParentPage { get; init; }
        public ILocator Self { get; set; }

        public WebBlock(IPage parentPage, ILocator self)
        {
            ParentPage = parentPage;
            Self = self;
        }
    }
}
