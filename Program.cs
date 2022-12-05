using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeneme
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Test test = new Test();
            test.Browser();
            test.start();
            test.search();
        }

        

    }
}
