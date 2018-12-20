using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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
            //driver.Url = "https://ya.ru/";

            IWebElement buttonCreate = driver.FindElement(By.Name("button-create"));
            Assert.AreEqual("����� ������", buttonCreate.Text);
            buttonCreate.Click();

            Assert.AreEqual("������ ����������", driver.Title);
            driver.FindElement(By.XPath("//*[@id='text-1543683954933']")).SendKeys("������"); 
            driver.FindElement(By.XPath("//*[@id='text-1543683960726']")).SendKeys("����");
            driver.FindElement(By.XPath("//*[@id='text-1543683963925']")).SendKeys("��������");
            driver.FindElement(By.XPath("//*[@id='date-1543683967732']")).SendKeys("01-01-2001");
            driver.FindElement(By.XPath("//*[@id='select-1543683974615-1']")).Click(); //���
            IWebElement radioBtn = driver.FindElement(By.XPath("//*[@id='checkbox-group-1543684026689-1']"));
            radioBtn.Click(); //�#
            IWebElement familia = driver.FindElement(By.Id("text-1543683954933"));
            Assert.AreEqual("������", familia.GetAttribute("value"));
            IWebElement buttonSave = driver.FindElement(By.XPath("//*[contains(text(),'���������')]"));
            buttonSave.Click();
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("����� ������", driver.FindElement(By.Name("button-create")).Text);

            //driver.Close();
        }
    }

    
}