using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class AutomationPracticeFormTest
{
    static void Main(string[] args)
    {
        // Setup ChromeDriver
        IWebDriver driver = new ChromeDriver();
        try
        {
            // Navigate to the Automation Practice Form
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            driver.Manage().Window.Maximize();
            
            // Wait for the page to load
            Thread.Sleep(3000);



            // Test 1: Name field
            var nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.Clear();
            nameField.SendKeys("John Doe");
            Console.WriteLine("Name field test passed!");

            // Test 2: Email field
            var emailField = driver.FindElement(By.XPath("//input[@placeholder='Email']"));
            emailField.Clear();
            emailField.SendKeys("johndoe@example.com");
            Console.WriteLine("Email field test passed!");

            // Test 3: Mobile Number field
            var mobileField = driver.FindElement(By.XPath("//input[@placeholder='Mobile']"));
            mobileField.Clear();
            mobileField.SendKeys("1234567890");
            Console.WriteLine("Mobile number field test passed!");

            // Verify the fields contain the entered values
            if (nameField.GetAttribute("value") == "John Doe" &&
                emailField.GetAttribute("value") == "johndoe@example.com" &&
                mobileField.GetAttribute("value") == "1234567890")
            {
                Console.WriteLine("All field tests passed successfully!");
            }
            else
            {
                Console.WriteLine("Field validation failed!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Test failed: {ex.Message}");
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}
