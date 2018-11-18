using OpenQA.Selenium.Appium.PageObjects.Attributes.Abstract;
using System;

namespace OpenQA.Selenium.Appium.PageObjects.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = true)]
    public class FindsByWindowsAutomationAttribute : FindsByUIAutomatorsAttribute
    {        
        /// <summary>
        /// Sets the target UI automation locator
        /// </summary>
        public string AutomationId
        {
            set { byList.Add(new ByWindowsAutomation(value)); }
            get { return null; }
        }
    }
}
