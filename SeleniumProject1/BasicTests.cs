using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Threading;

namespace Project1
{
    public class BasicTests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Intialize()
        {
            // Maximize the browser
            driver.Manage().Window.Maximize();

            //Navigate to TurnUp portal
           driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
        }

        public void Login()
        {
            //Enter the text in Username
            SeleniumSetMethod.EnterText(driver, "UserName", "hari", "Id");

            // Enter the text in Password
            SeleniumSetMethod.EnterText(driver, "Password", "123123", "Id");

            // click the button
            SeleniumSetMethod.Click(driver, "input[type='submit']", "CSS");
        }

        public void AdminDropdown()
        {
            IWebElement Admnistration = driver.FindElement(By.LinkText("Administration"));
            Admnistration.Click();
            IWebElement TimeMaterial = driver.FindElement(By.LinkText("Time & Materials"));
            TimeMaterial.Click();
            


        }

     public void CreateNew()
        {
            IWebElement CreateNew = driver.FindElement(By.LinkText("Create New"));
            CreateNew.Click();
        }


        [Test]
        public void LoginTest()
        {
            Login();


            //validate the text on hyperlink as Hello Hari
            IWebElement helloHari = driver.FindElement(By.CssSelector("form ul li.dropdown a.dropdown-toggle"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged In successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }

        }
        [Test]
        public void TimeTest()
        {
            Login();
            AdminDropdown();
            CreateNew();

            //select Time in Dropdown

            var dropDownArrow = driver.FindElement(By.CssSelector(".k-icon.k-i-arrow-s"));
            dropDownArrow.Click();
            var timeElement = driver.FindElements(By.CssSelector("#TypeCode-list ul li")).First(e => e.Text == "Time");
            timeElement.Click();

            /*IWebElement TypeCode = driver.FindElement(By.XPath("@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span "));
            TypeCode.Click();
            Thread.Sleep(2000);
            IWebElement TimeElement = driver.FindElement(By.XPath("*[@id=\"TypeCode_listbox\"]/li[2]"));
            TimeElement.Click();*/

            //Enter  text in the code text box
            SeleniumSetMethod.EnterText(driver, "Code", "123123", "Id");

            //Enter text int description

            string d = new Random().Next(1000, 99999).ToString();
            SeleniumSetMethod.EnterText(driver, "Description", "Testing" + d, "Id");

            //Enter text in price per unit

            IWebElement activateElement = driver.FindElement(By.CssSelector(".k-numeric-wrap.k-state-default.k-expand-padding"));
            activateElement.Click();
         
            SeleniumSetMethod.EnterText(driver, "input#Price", "2.00", "CSS");

            //click the save button
            SeleniumSetMethod.Click(driver, "SaveButton", "Id");

            Thread.Sleep(2000);

            // #tmsGrid a[title= 'Go to the last page'] --> for go to last page

            SeleniumSetMethod.Click(driver, " #tmsGrid a[title= 'Go to the last page']", "CSS");

            Console.WriteLine("Test Paased");

            var AddedRow = driver.FindElements(By.CssSelector("#tmsGrid tbody tr")).First(e => e.Text.Contains("Testing" + d));
            

            if(AddedRow == null) {

                Console.WriteLine("test Failed after Row Added");

             }
            else
            {
                Console.WriteLine("Test Passed after Row Added with description"+ d);
            }

            // Delete

            var DeleteButton = AddedRow.FindElement(By.LinkText("Delete"));
            DeleteButton.Click();

            driver.SwitchTo().Alert().Accept();
            var DeletedRow = driver.FindElements(By.CssSelector("#tmsGrid tbody tr")).First(e => e.Text.Contains("Testing" + d));


            if (DeletedRow == null)
            {

                Console.WriteLine(" Test Passed after Delete");

            }
            else
            {
                Console.WriteLine("Test Failed after Delete");
            }





        }


        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
