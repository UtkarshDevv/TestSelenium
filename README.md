# CloudQA Developer Internship: Automation Practice Form Test

This project demonstrates how to use **Selenium** in **C#** to automatically test three fields on the **CloudQA Automation Practice Form**. The goal of the automation is to ensure that the form fields still work correctly, even if the positions or other properties of the HTML elements change.

## Task Description

The goal of this task is to:
- Automate the testing of three fields on the web page: **Name**, **Email**, and **Mobile**.
- Test the functionality by:
  1. Entering a value in each of the fields.
  2. Verifying that the value entered matches the field value after submission.

## Steps to Run the Project

### Prerequisites
To run this project, you need the following:
1. **C# (Microsoft .NET)**: Ensure that you have **.NET Core** or **.NET Framework** installed.
2. **Selenium WebDriver**: The Selenium WebDriver for Chrome is used to automate the browser. You can install it using **NuGet**.
3. **ChromeDriver**: Ensure you have the correct version of ChromeDriver for your Chrome browser. You can download it from the [official site](https://sites.google.com/a/chromium.org/chromedriver/).

### Setup

1. **Create a New C# Console Application**
   Create a new C# console application in Visual Studio or another IDE.

2. **Install Selenium WebDriver**
   Open the **Package Manager Console** and run:
   ```bash
   Install-Package Selenium.WebDriver
   Install-Package Selenium.WebDriver.ChromeDriver

### Result(Output)
    DevTools listening on ws://127.0.0.1:61622/devtools/browser/0b66da56-2bcc-4587-b78b-398b924973aa
Name field test passed!
Email field test passed!
Test failed: no such element: Unable to locate element: {"method":"xpath","selector":"//input[@placeholder='Mobile']"}
