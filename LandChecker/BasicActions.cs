using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace LandChecker
{
    class BasicActions
    {
        public static void VerifyPageTitle(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            String title = driver.Title;
            //wait.Until(e => e.FindElement(By.XPath("//*[@id='root']/div/header[1]")));
        }

        public static void VerifyHeader(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(EC.ElementExists(By.XPath("//*[@id='root']/div/header[1]")));
        }

        public static void TriggerRequiredFieldsError(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement ele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[7]/button")));
            js.ExecuteScript("arguments[0].click()", ele);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void CheckFirstNameRequirementError(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox = wait.Until(e => e.FindElement(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[1]/div[1]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox);
            js.ExecuteScript("arguments[0].click()", textbox);
            textbox.Clear();
            textbox.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement ele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[7]/button")));
            js.ExecuteScript("arguments[0].click()", ele);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wait.Until(e => e.FindElement(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[1]/div[1]/p")));
        }


        public static void CheckFirstNameStringEntry(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox_firstname = wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[1]/div[1]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox_firstname);
            js.ExecuteScript("arguments[0].click()", textbox_firstname);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            textbox_firstname.Clear();
            textbox_firstname.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void CheckLastNameStringEntry(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox_lastname = wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[1]/div[2]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox_lastname);
            js.ExecuteScript("arguments[0].click()", textbox_lastname);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            textbox_lastname.Clear();
            textbox_lastname.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void CheckEmailStringEntry(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox_email = wait.Until(e => e.FindElement(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[2]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox_email);
            js.ExecuteScript("arguments[0].click()", textbox_email);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            textbox_email.Clear();
            textbox_email.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void CheckPasswordStringEntry(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox_password = wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[3]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox_password);
            js.ExecuteScript("arguments[0].click()", textbox_password);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            textbox_password.Clear();
            textbox_password.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void CheckCompanyStringEntry(IWebDriver driver, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement textbox = wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[4]/div[1]/div/input")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", textbox);
            js.ExecuteScript("arguments[0].click()", textbox);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            textbox.Clear();
            textbox.SendKeys(value);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        public static string SetDropdownOption(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement occupationDropdown = wait.Until(e => e.FindElement(By.Id("select-occupation")));
            Actions action = new Actions(driver);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", occupationDropdown);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            action.MoveToElement(occupationDropdown); 
            occupationDropdown.SendKeys(Keys.Enter);                                                
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            IWebElement selectedOption2 = wait.Until(e => e.FindElement(By.XPath("/html/body/div[5]/div[2]/ul/li[4]")));
            js.ExecuteScript("arguments[0].click()", selectedOption2);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return occupationDropdown.Text.Trim();
        }

        

        public static void CheckStates(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[5]/div/div[1]/div/label/span[1]/span[1]/input"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[5]/div/div[2]/div/label/span[1]/span[1]/input"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[5]/div/div[3]/div/label/span[1]/span[1]/input"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[5]/div/div[4]/div/label/span[1]/span[1]/input"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[5]/div/div[5]/div/label/span[1]/span[1]/input"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public static void CheckTermsOfUse(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            IWebElement termsOfUseCheckbox = wait.Until(e => e.FindElement(By.Name("accepted_terms")));
            if (!termsOfUseCheckbox.Selected)
            {
                termsOfUseCheckbox.Click();
            }
        }

        public static void CheckTermsOfUseRedirect(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[6]/label/span[2]/legend/a"))).Click();
            wait.Until(e => e.WindowHandles.Count > 1);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        public static void CheckFooterExistence(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(e => e.FindElement(By.XPath("//*[@id='root']/div/header[1]")));
        }

        public static void CheckLoginRedirect(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/h6/a"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void VerifyFooter(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(EC.ElementExists(By.XPath("/html/body/div[1]/div/header[2]/div")));
        }

        public static void LoginRedirect(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(e => e.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/h6/a"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

    }
}
