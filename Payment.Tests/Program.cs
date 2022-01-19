using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Payment.Tests
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Devtools = true
            });
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://www.nexon.com/Home/Game");
            await page.ClickAsync("div > .myInfo > .login > .nexon");

        }
    }
}