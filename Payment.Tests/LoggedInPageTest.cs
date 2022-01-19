using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace Payment.Tests
{
    public class LoggedInPageTest : PageTest
    {
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions
            {
                StorageStatePath = "auth.json"
            };
        }
    }
}