using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MyPage;

namespace NUnit.Tests1
{
    [TestFixture]
    public class UnitTest1
    {

        [Test]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "F:\\html_hw\\Index.html";

            IWebElement buttonCreate = driver.FindElement(By.Name("button-create"));
            Assert.AreEqual("����� ������", buttonCreate.Text);
            buttonCreate.Click();


            MyPage page = new MyPage(driver);
            Assert.AreEqual("������ ����������", driver.Title);

            page.FillForm("�������", "���", "��������", "01-01-2001");

            Assert.IsTrue(page.isSaved(), "�� ���������");

            //driver.Close();
        }
    }


}