using OpenQA.Selenium;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Context
{
    public class CurrenciesContext
    {

        private readonly Currencies _currencies;

        public CurrenciesContext(IWebDriver webDriver)
        {
            _currencies = new Currencies(webDriver);
        }

        public CurrenciesContext AddMinAmdMaxSalary(string minimumSalary, string maximumSalary)
        {
            _currencies.SeleniumActions
                .Click(_currencies._addButton)
                .Click(_currencies._currencyField)
                .Click(_currencies._currencyFieldFirst)
                .EntTextInTextBox(_currencies._minimumSalary, minimumSalary)
                .EntTextInTextBox(_currencies._maximumSalary, maximumSalary)
                .Click(_currencies._saveButton);
            return this;
        }

        public CurrenciesContext VefifyThatEnteredSalaryIsCorrect(string minimumSalary, string maximumSalary)
        {
            _currencies.SeleniumActions
                .VerifyTextPresentInElement(_currencies._minimumSalaryText, minimumSalary)
                .VerifyTextPresentInElement(_currencies._maximumSalaryText, maximumSalary);
            return this;
        }

        public CurrenciesContext CancelMinAmdMaxSalary(string minimumSalary, string maximumSalary)
        {
            _currencies.SeleniumActions
                .Click(_currencies._addButton)
                .Click(_currencies._currencyField)
                .Click(_currencies._currencyFieldFirst)
                .EntTextInTextBox(_currencies._minimumSalary, minimumSalary)
                .EntTextInTextBox(_currencies._maximumSalary, maximumSalary)
                .Click(_currencies._cancelButton);
            return this;
        }


        public CurrenciesContext VefifyThatEnteredSalaryIsEmpty(string textToVerify)
        {
            _currencies.SeleniumActions
                .VerifyTextPresentInElement(_currencies._emptyCurrenciesText, textToVerify);
            return this;
        }

        public CurrenciesContext DeleteNewPayGrade()
        {
            _currencies.SeleniumActions
                .Click(_currencies._deleteAction);
            return this;
        }
    }
}
