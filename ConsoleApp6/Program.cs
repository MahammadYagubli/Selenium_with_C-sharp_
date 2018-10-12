using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
                static void Main(string[] args)
        {
            String Url = "http:///";
            int option = 2;
            String ID = "nick";
            String dropdownItemagename = "age";
  String dropdownItemagevalue = "#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(2) > td:nth-child(4) > select > option:nth-child(20)";
            String dropdownItemlevelname = "level";
 String dropdownItemlevelvalue = "#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(2) > td:nth-child(6) > select > option:nth-child(1)";
            String dropdownIteminfoname = "info";
  String dropdownIteminfovalue = "#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(3) > td:nth-child(2) > select > option:nth-child(2)";
            String dropdownItemsexname = "sex";
            String dropdownItemsexvalue = "#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(3) > td:nth-child(4) > select > option:nth-child(1)";
            String dropdownItemcountryname = "country";
  String dropdownItemcountryvalue= "#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(3) > td:nth-child(6) > select > option:nth-child(39)";
            String sypename = "Iyoqivi";

            for (int a=0; a<100;a++) {
                sypename += "a";
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(Url);
                Dropdown(driver,dropdownItemagename, dropdownItemagevalue);
            Dropdown(driver, dropdownItemlevelname, dropdownItemlevelvalue);
            Dropdown(driver, dropdownIteminfoname, dropdownIteminfovalue);
            Dropdown(driver, dropdownItemsexname, dropdownItemsexvalue);
            Dropdown(driver, dropdownItemcountryname, dropdownItemcountryvalue);



            //  IWebElement dropdownelemetn = driver.FindElement(By.Name(dropdownItemagename));
            //set text for sype name
            IWebElement skypenamenameTextBox = driver.FindElement(By.Name("skype"));
            skypenamenameTextBox.SendKeys("iyoqivo");
            //checkbox show me 
           IWebElement textBox = driver.FindElement(By.Id(ID));
             IWebElement checkBox = driver.FindElement(By.CssSelector("#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(3) > input[type=\"checkbox\"]"));

            if (textBox.Displayed)
            {
                textBox.SendKeys("news");
                GreenMessage("Yes i can see the element, It is right here");
            }
            if (checkBox.GetAttribute("checked")=="true")
            {
                
                GreenMessage("CheckedBox is already CHECKED");
                Console.WriteLine("I want to change the checked status of the CheckBox");
               // checkBox.Click();
                if (checkBox.GetAttribute("checked")=="false")
                {
                    textBox.SendKeys("Me");
                    GreenMessage("Yes i can see the element, It is right here");
                }


            }

            if (!textBox.Displayed)
            {
                     RedMessage("I am not able to find elemetn and");
            }

            Thread.Sleep(000);
            driver.Close();


            }
          


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
         //   Console.WriteLine("Hello World!");
           // Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static void RedMessage(String message) {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Dropdown(IWebDriver driver,String dropdownelement, String dropdownvalue) {

            IWebElement dropdownelemetn = driver.FindElement(By.Name(dropdownelement));
            IWebElement dropddownvalue = driver.FindElement(By.CssSelector(dropdownvalue));
            IWebElement checkBox = driver.FindElement(By.CssSelector("#userForm > div:nth-child(6) > div.boxbody > table > tbody > tr:nth-child(4) > td > table > tbody > tr > td:nth-child(3) > input[type=\"checkbox\"]"));
            dropddownvalue.Click();
            Console.WriteLine("Dropdown choosen value"+dropdownelemetn.GetAttribute("value"));

        }
        public static void GreenMessage(String message)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
