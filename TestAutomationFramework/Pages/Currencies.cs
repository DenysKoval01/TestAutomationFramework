using OpenQA.Selenium;
using TestAutomationFramework.Context;
using TestAutomationFramework.Framework;

namespace TestAutomationFramework.Pages
{
    public class Currencies : PageBase
    {
        public readonly LocatorObject _addButton = new(".//div[@class='orangehrm-header-container']//button[@type='button']", LocatorObject.XPATH);
        public readonly LocatorObject _currencyField = new(".oxd-select-text-input", LocatorObject.CSS);
        public readonly LocatorObject _currencyFieldFirst = new(".oxd-form-row:nth-child(2) .oxd-grid-item:nth-child(1) .oxd-input", LocatorObject.CSS);
        public readonly LocatorObject _minimumSalary = new("//label[contains(text(), 'Minimum Salary')]/parent::div/following-sibling::div/input", LocatorObject.XPATH);
        public readonly LocatorObject _maximumSalary = new("//label[contains(text(), 'Maximum Salary')]/parent::div/following-sibling::div/input", LocatorObject.XPATH);
        public readonly LocatorObject _saveButton = new("//h6[text()='Add Currency']/following-sibling::form//button[normalize-space()='Save']", LocatorObject.XPATH);
        public readonly LocatorObject _cancelButton = new("//h6[text()='Add Currency']/following-sibling::form//button[normalize-space()='Cancel']", LocatorObject.XPATH);
        public readonly LocatorObject _minimumSalaryText = new("//div[@class='oxd-table-cell oxd-padding-cell'][3]/div", LocatorObject.XPATH);
        public readonly LocatorObject _maximumSalaryText = new("//div[@class='oxd-table-cell oxd-padding-cell'][4]/div", LocatorObject.XPATH);
        public readonly LocatorObject _emptyCurrenciesText = new("//span[@class='oxd-text oxd-text--span' and text()='No Records Found']", LocatorObject.XPATH);
        public readonly LocatorObject _deleteAction = new("//div[@class='oxd-table-cell-actions']/button[1]", LocatorObject.XPATH);
        public Currencies(IWebDriver iWebDriver) : base(iWebDriver)
        {
        }

        public static CurrenciesContext CreateCurrenciesContextContext()
        {
            return new CurrenciesContext(_iWebDriver);
        }
    }
}
