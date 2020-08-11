using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class SeleniumSetMethod
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype) 
            {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == "CSS")
                driver.FindElement(By.CssSelector(element)).SendKeys(value);
        }

        //click in to a button
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementtype == "CSS")
                driver.FindElement(By.CssSelector(element)).Click();
        }

        // select dropdown control
        public static void DropDown(IWebDriver driver, string element, string value, string elementtype)
        {

            if (elementtype == "ID")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByValue(value);
            if (elementtype == "LinkText")
                new SelectElement(driver.FindElement(By.LinkText(element))).SelectByValue(value);

        }
            
            
            
    }
}
