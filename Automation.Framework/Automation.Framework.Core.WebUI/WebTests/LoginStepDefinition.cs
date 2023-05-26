
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.WebTests
{
    [Binding]
    public class LoginStepDefinition
    {
        [Given(@"User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            Console.WriteLine("User is on the login page");
        }

        [When(@"User enter username as ""([^""]*)""")]
        public void WhenUserEnterUsernameAs(string userName)
        {
            Console.WriteLine($"User enters username: {userName}");
        }

        [When(@"User enter password as ""([^""]*)""")]
        public void WhenUserEnterPasswordAs(string password)
        {
            Console.WriteLine($"User enters password: {password}");
        }

        [When(@"User clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("User clicks on login button");
        }

        [Then(@"User is logged in")]
        public void ThenUserIsLoggedIn()
        {
            Console.WriteLine("User is logged in");
        }

        [Then(@"User navigates to member page")]
        public void ThenUserNavigatesToMemberPage()
        {
            Console.WriteLine("User navigates to members page");
        }

    }
}
