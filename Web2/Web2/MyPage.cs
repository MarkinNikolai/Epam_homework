using System;
using OpenQA.Selenium;

namespace NUnit.Tests1
{
   class MyPage
    {
       
        public MyPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPATH, Using = "//*[@id='text-1543683954933']")]
        private IWebElement FamiliField;

        [FindsBy(How = How.XPATH, Using = "//*[@id='text-1543683960726']")]
        private IWebElement nameField;

        [FindsBy(How = How.XPATH, Using = "//*[@id='text-1543683963925']")]
        private IWebElement GFamiliField;

        [FindsBy(How = How.XPATH, Using = "//*[@id='date-1543683967732']")]
        private IWebElement DateField;

        [FindsBy(How = How.XPATH, Using = "//*[@id='select-1543683974615-1']")]
        private IWebElement SexField;

        internal void FillForm(string v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }

        [FindsBy(How = How.XPATH, Using = "/*[@id='checkbox-group-1543684026689-1']")]
        private IWebElement ChekbocksBtn;

        [FindsBy(How = How.XPATH, Using = "//*[contains(text(),'Сохранить')]")]
        private IWebElement SaveBtn;

        [FindsBy(How = How.Id, Using = "button-1543684046403")] //Новая анкета
        private IWebElement StatusLb1;

        public void FillForm(String Famili , String name , String GFamili , String Date)
        {
            FamiliField.SendKeys(Famili);
            nameField.SendKeys(name);
            GFamiliField.SendKeys(GFamili);
            DateField.SendKeys(Date);
            SexField.Click();
            ChekbocksBtn.Click();
            SaveBtn.Click();
        }
        public Boolean isSaved()
        {
            return StatusLb1.Text.Equals("Новая Анкета");
        }
       
    }
}

