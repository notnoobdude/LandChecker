using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace LandChecker
{
    public class Registration
    {
        private readonly string LoginUrl = "https://app.landchecker.com.au/join";
        IWebDriver _driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Login()
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            _driver.Url = LoginUrl;
        }

        /// <summary>
        /// Registration - Check if the Page Title is consistent or not
        /// </summary>
        [Test, Order(1)]
        public void VerifyPageTitle()
        {
         //   BasicActions.VerifyPageTitle(_driver);
            Assert.AreEqual("Join | Landchecker", _driver.Title);
        }

        /// <summary>
        /// Registration - Check existence of the registration page header
        /// </summary>
        [Test, Order(2)]
        public void VerifyHeaderExistence()
        {
            BasicActions.VerifyHeader(_driver);
            Assert.Pass();
        }

        /// <summary>
        /// Registration - First Name Requirement Error works as intended
        /// </summary>
        [Test, Order(3)]
        public void VerifyFirstNameRequirementError()
        {
            BasicActions.TriggerRequiredFieldsError(_driver);
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[1]/div[1]/p")).GetAttribute("innerText").Contains("First Name is required"));
        }

        /// <summary>
        /// Registration - Last Name Requirement Error works as intended
        /// </summary>
        [Test, Order(4)]
        public void VerifyLastNameRequirementError()
        {
            BasicActions.TriggerRequiredFieldsError(_driver);
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[1]/div[2]/p")).GetAttribute("innerText").Contains("Last Name is required"));
        }

        /// <summary>
        /// Registration - Email Address Requirement Error works as intended
        /// </summary>
        [Test, Order(5)]
        public void VerifyEmailAddressRequirementError()
        {
            BasicActions.TriggerRequiredFieldsError(_driver);
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[2]/p")).GetAttribute("innerText").Contains("Email is required"));
        }

        /// <summary>
        /// Registration - Password Requirement Error works as intended
        /// </summary>
        [Test, Order(6)]
        public void VerifyPasswordRequirementError()
        {
            BasicActions.TriggerRequiredFieldsError(_driver);
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[3]/p")).GetAttribute("innerText").Contains("Password is required"));
        }

        /// <summary>
        /// Registration - Terms of Use Requirement Error works as intended
        /// </summary>
        [Test, Order(7)]
        public void VerifyTermsOfUseRequirementError()
        {
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[6]/p")).GetAttribute("innerText").Contains("Terms of Use must be accepted"));
        }

        /// <summary>
        /// Registration - First Name input field allows entry of string value
        /// </summary>
        [Test, Order(8)]
        public void VerifyFirstNameStringInput()
        {
            BasicActions.CheckFirstNameStringEntry(_driver, "John");
            Assert.IsTrue(_driver.FindElement(By.Name("first_name")).GetAttribute("value").Contains("John"));

        }

        /// <summary>
        /// Registration - Last Name input field allows entry of string value
        /// </summary>
        [Test, Order(9)]
        public void VerifyLastNameStringInput()
        {
            BasicActions.CheckLastNameStringEntry(_driver, "Cena");
            Assert.IsTrue(_driver.FindElement(By.Name("last_name")).GetAttribute("value").Contains("Cena"));
        }

        /// <summary>
        /// Registration - Email input field allows entry of string value
        /// </summary>
        [Test, Order(10)]
        public void VerifyEmailStringInput()
        {
            BasicActions.CheckEmailStringEntry(_driver, "cantseeme@gmail.com");
            Assert.IsTrue(_driver.FindElement(By.XPath("//*[@id='root']/div/div/div/div/div[1]/form/div[2]/div/input")).GetAttribute("value").Contains("cantseeme@gmail.com"));
        }

        /// <summary>
        /// Registration - Password input field allows entry of string value
        /// </summary>
        [Test, Order(11)]
        public void VerifyPasswordStringInput()
        {
            BasicActions.CheckPasswordStringEntry(_driver, "johncena123");
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[3]/div/input")).GetAttribute("value").Contains("johncena123"));
        }

        /// <summary>
        /// Registration - Company Name input field allows entry of string value
        /// </summary>
        [Test, Order(12)]
        public void VerifyCompanyStringInput()
        {
            BasicActions.CheckCompanyStringEntry(_driver, "CantSeeMe Company");
            Assert.IsTrue(_driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/form/div[4]/div[1]/div/input")).GetAttribute("value").Contains("CantSeeMe Company"));
        }

        /// <summary>
        /// Registration - Company Name input field allows entry of string value
        /// </summary>
        [Test, Order(13)]
        public void VerifyOccupationDropdown()
        {
            var selected = BasicActions.SetDropdownOption(_driver);
            Assert.AreEqual("Architect", selected);
        }

        /// <summary>
        /// Registration - Verify State Checkboxes if clickable or not
        /// </summary>
        [Test, Order(14)]
        public void VerifyStateCheckboxes()
        {
            BasicActions.CheckStates(_driver);
            BasicActions.CheckStates(_driver);
            Assert.Pass();
        }

        /// <summary>
        /// Registration - Verify Terms of Use checkbox if clickable or not
        /// </summary>
        [Test, Order(15)]
        public void VerifyTermsOfUseCheckbox()
        {
            BasicActions.CheckTermsOfUse(_driver);
            Assert.Pass();
        }

        /// <summary>
        /// Registration - Verify Terms Of Use Redirect
        /// </summary>
        [Test, Order(16)]
        public void VerifyTermsOfUseRedirection()
        {
            BasicActions.CheckTermsOfUseRedirect(_driver);
            Assert.IsTrue(_driver.Url.Contains("https://s3-ap-southeast-2.amazonaws.com/landchecker-images/legals/terms-and-conditions.pdf"));
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
        }

        /// <summary>
        /// Registration - Verify Existence of Footer
        /// </summary>
        [Test, Order(16)]
        public void VerifyFooterExistence()
        {
            BasicActions.VerifyFooter(_driver);
            Assert.Pass();
        }

        /// <summary>
        /// Registration - Verify Login Redirection
        /// </summary>
        [Test, Order(17)]
        public void VerifyLoginRedirect()
        {
            BasicActions.LoginRedirect(_driver);
            Assert.AreEqual("Login | Landchecker", _driver.Title);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

    }
}