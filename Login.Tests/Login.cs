using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Login.Tests
{
    [Parallelizable(ParallelScope.Self)]
    public class Login : PageTest
    {
        [Test]
        public async Task ManualLogin()
        {
            await Page.GotoAsync("https://www.nexon.com/Home/Game");

            // Click [placeholder="넥슨ID (아이디 또는 이메일)"]
            await Page.ClickAsync("div > .myInfo > .login > .nexon");

            await Page.FillAsync("#txtNexonID", "id");
            await Page.FillAsync("#txtPWD", "password");
            await Page.ClickAsync(".btLogin");
            await Page.ScreenshotAsync(new PageScreenshotOptions {Path = "screenshot.png"});
        }
    }
}