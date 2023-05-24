using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class PayGradesContext
    {

        private readonly PayGrades _payGrades;

        public PayGradesContext(IWebDriver webDriver)
        {
            _payGrades = new PayGrades(webDriver);
        }

        public PayGradesContext AddNewPayGrade(string random)
        {
            _payGrades.SeleniumActions
                .Click(_payGrades._addButton)
                .EntTextInTextBox(_payGrades._payGrade, random)
                .Click(_payGrades._saveButton);
            return this;
        }
    }
}
