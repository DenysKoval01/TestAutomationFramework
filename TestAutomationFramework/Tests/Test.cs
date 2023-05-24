using NUnit.Framework;
using TestAutomationFramework.Pages;
using TestAutomationFramework.Utilities;

namespace TestAutomationFramework.Tests
{
    public class Test : BaseTest
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string minimumSalary = "1000";
        private readonly string maximumSalary = "5000";

        [Test]
        public void CheckTharChangesInCurrenciesBlockIsVisibleAndDelete()
        {
            string randomString = new(Enumerable.Repeat(chars, 6).Select(s => s[new Random().Next(s.Length)]).ToArray());

            LoginPage
                .CreateLoginPageContext()
                .OpenHomePageUrl(Data.ApplicationUrl)
                .LoginIntoSystem(Data.UserName, Data.UserPassword);

            SearchPage
                .CreateSearchPageContext()
                .ClickOnAdminTab();

            AdminHeader
                .CreateAdminHeaderContext()
                .ClickOnJob()
                .ClickOnPayGradesElement();

            PayGrades
                .CreatePayGradesContextContext()
                .AddNewPayGrade(randomString);

            Currencies
                .CreateCurrenciesContextContext()
                .AddMinAmdMaxSalary(minimumSalary, maximumSalary)
                .VefifyThatEnteredSalaryIsCorrect(minimumSalary, maximumSalary)
                .DeleteNewPayGrade();

            SurePopUp
                .CreateSurePopUpContext()
                .ClickDeleteButton();

            Currencies
                .CreateCurrenciesContextContext()
                .VefifyThatEnteredSalaryIsEmpty("No Records Found");
        }


       [Test]
        public void CheckTharChangesInCurrenciesBlockIsNotVisible()
        {
            string randomString = new(Enumerable.Repeat(chars, 6).Select(s => s[new Random().Next(s.Length)]).ToArray());

            LoginPage
                .CreateLoginPageContext()
                .OpenHomePageUrl(Data.ApplicationUrl)
                .LoginIntoSystem(Data.UserName, Data.UserPassword);

            SearchPage
                .CreateSearchPageContext()
                .ClickOnAdminTab();

            AdminHeader
                .CreateAdminHeaderContext()
                .ClickOnJob()
                .ClickOnPayGradesElement();

            PayGrades
                .CreatePayGradesContextContext()
                .AddNewPayGrade(randomString);

            Currencies
                .CreateCurrenciesContextContext()
                .CancelMinAmdMaxSalary(minimumSalary, maximumSalary)
                .VefifyThatEnteredSalaryIsEmpty("No Records Found");
        }

    }
}
