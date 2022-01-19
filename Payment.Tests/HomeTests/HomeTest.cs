using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Payment.Tests.HomeTests
{
    [Parallelizable(ParallelScope.Self)]
    public class HomeTest : LoggedInPageTest
    {
        [Test]
        public async Task ManualLogin()
        {
            await Page.GotoAsync("https://www.nexon.com/Home/Game");
            
            
        }
    }
}