using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeneme
{
    class Test
    {
        IWebDriver driver;

        public void Browser()
        {
            driver = new ChromeDriver();
            
        }

        public void start()
        {
            string link = "https://www.network.com.tr/";
            driver.Navigate().GoToUrl(link);
            
        }

        public void search()
        {

            try
            {
                driver.FindElement(By.XPath("//*[@id='search']")).SendKeys("ceket"); //tag kısmının tam id'sini bulamadığım için bu şekilde bıraktım
                Actions tus = new Actions(driver);
                tus.SendKeys(Keys.Enter); //burada web sitesinde arama butonu olmadığı için aramayı yapmak için enter tuşuna basıyorum


                Console.WriteLine("Element found by id");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            
        }

    }
}
