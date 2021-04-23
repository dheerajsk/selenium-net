using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace AdvanceAutomation
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AboutUsPOMTest
    {
        [TestMethod]
        public void TestPOM()
        {
            using (var driver = new ChromeDriver())
            {
                AboutUsPOM about = new AboutUsPOM(driver);
                about.Goto();
                Assert.IsTrue(driver.PageSource.Contains("About Simplilearn"));
            }
        }
    }
}
