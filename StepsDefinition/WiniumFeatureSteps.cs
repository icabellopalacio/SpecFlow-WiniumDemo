using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using TechTalk.SpecFlow;

namespace Altenium.StepsDefinition
{
    [Binding]
    public class WiniumFeatureSteps
    {

        #region Properties

        public enum TypeofOperators { 
            Add= 1,
            Sub= 2,
            Mul=3,
            Div=4}; 

        private WiniumDriver _driver { get; set; }

        const string  mainFormName = "frmCalculator";

        private IWebElement _operator1 { get; set; }
        const string operator1Name = "txtOperator1";

        private IWebElement _operator2 { get; set; }
        const string operator2Name = "txtOperator2";

        private IWebElement _result { get; set; }
        const string resultName = "txtResult";

        private TypeofOperators _typeOfOperator { get; set; }

        private IWebElement _btnAdd { get; set; }
        const string btnAddName = "btnAdd";
        const string btnSubName = "btnSubstract";
        const string btnMulName = "btnMultiply";
        const string btnDivName = "btnDivide";

        #endregion

        #region Feature Steps

        [Given(@"I have entered (.*) into the Operator1")]
        public void GivenIHaveEnteredIntoTheOperator1(int Operator)
        {
            InitDriver();
            _operator1 = _driver.FindElementById(mainFormName).FindElement(By.Id(operator1Name));
            _operator1.SendKeys(Operator.ToString());
        }

        [Given(@"I have entered (.*) into the Operator2")]
        public void GivenIHaveEnteredIntoTheOperator2(int Operator)
        {
            _operator2 = _driver.FindElementById(mainFormName).FindElement(By.Id(operator2Name));
            _operator2.SendKeys(Operator.ToString());
        }

        [When(@"I press (.*)")]
        public void WhenIPressAdd(int typeOfOperator)
        {
            _typeOfOperator = (TypeofOperators)typeOfOperator;
            switch (_typeOfOperator) {
                case TypeofOperators.Add:
                    _btnAdd = _driver.FindElementById(mainFormName).FindElement(By.Id(btnAddName));
                    break;
                case TypeofOperators.Sub:
                    _btnAdd = _driver.FindElementById(mainFormName).FindElement(By.Id(btnSubName));
                    break;
                case TypeofOperators.Mul:
                    _btnAdd = _driver.FindElementById(mainFormName).FindElement(By.Id(btnMulName));
                    break;
                case TypeofOperators.Div:
                    _btnAdd = _driver.FindElementById(mainFormName).FindElement(By.Id(btnDivName));
                    break;
            }
            _btnAdd.Click();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            _result = _driver.FindElementById(mainFormName).FindElement(By.Id(resultName));

            Assert.AreEqual(_result.Text, result.ToString());

            ScreenShot();

            Close();
        }

        #endregion

        #region Methods

        private void InitDriver() {
            var options = new DesktopOptions()
            {
                ApplicationPath = @"C:\Projects\Altenium\AlteniumWindowsForm\bin\Debug\AlteniumWindowsForm.exe"
            };
            var service = WiniumDriverService
                        .CreateDesktopService(@"C:\Projects\Altenium\packages\Winium.Desktop");
            service.Start();
            _driver = new WiniumDriver(service, options, TimeSpan.FromSeconds(60));
        }

        private void Close() {
           _driver.Close();
            _driver.Dispose();
        }

        private void ScreenShot() {
            var screenShot = _driver.GetScreenshot();

            var screnShotFolder = $@"C:\Altenium\scrrenShot_{DateTime.UtcNow.Year.ToString().PadLeft(2, '0')}_{DateTime.UtcNow.Month.ToString().PadLeft(2, '0')}_{DateTime.UtcNow.Day.ToString().PadLeft(2, '0')}_{DateTime.UtcNow.Hour.ToString().PadLeft(2, '0')}_{DateTime.UtcNow.Minute.ToString().PadLeft(2, '0')}";
            if (!Directory.Exists(screnShotFolder))
            {
                Directory.CreateDirectory(screnShotFolder);
            }
            screenShot.SaveAsFile($@"{screnShotFolder}\{_typeOfOperator}.jpg", ImageFormat.Jpeg);
        }

        #endregion

    }
}
