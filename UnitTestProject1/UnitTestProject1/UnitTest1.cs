using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
	
		public void CalculatorTest()
		{
			Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

			WindowsDriver<WindowsElement> Calculator;
	

			AppiumOptions Options = new AppiumOptions();
			Options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
			Options.AddAdditionalCapability("devicName", "WindowsPC");
			Calculator = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), Options);
			Calculator.FindElementByAccessibilityId("num5Button").Click();
			Calculator.FindElementByAccessibilityId("plusButton").Click();
			Calculator.FindElementByAccessibilityId("num3Button").Click();
			Calculator.FindElementByAccessibilityId("equalButton").Click();


		}
	}

}
