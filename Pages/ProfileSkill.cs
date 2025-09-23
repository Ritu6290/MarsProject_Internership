using System;
using Mars_Project.Utilities;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Mars_Project.Pages
{
	public class ProfileSkill
	{
        private readonly IWebDriver _driver;

        public ProfileSkill(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }
        public void GoToSkillTab()
        {
            IWebElement skilltab = _driver.FindElement(By.CssSelector("a[data-tab='second']"));
            skilltab.Click();
        }
        public void AddSkill(IWebDriver driver)
        {
            GoToSkillTab();
            IWebElement addNewbutton = driver.FindElement(By.CssSelector("div[class='ui teal button']"));
            addNewbutton.Click();
            IWebElement skillText = driver.FindElement(By.CssSelector("input[placeholder='Add Skill']"));
            skillText.SendKeys("Testing");
            IWebElement SkillLevelDropdown = driver.FindElement(By.CssSelector("select[name='level']"));
            SkillLevelDropdown.Click();
            SelectElement select = new SelectElement(SkillLevelDropdown);
            select.SelectByText("Expert");
            IWebElement addbutton = driver.FindElement(By.CssSelector("span[class='buttons-wrapper'] input[value='Add']"));
            addbutton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            IWebElement toastMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(toastMessage.Text.Contains("added"), Is.True, "Skill was not added");
        }
        public void EditSkill(IWebDriver driver)
        {
            GoToSkillTab();
            IWebElement editbutton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]"));
            editbutton.Click();
            IWebElement inputSkillText = driver.FindElement(By.CssSelector("input[placeholder='Add Skill']"));
            inputSkillText.Clear();
            inputSkillText.SendKeys("Testing With Selenium");
            IWebElement updateButton = driver.FindElement(By.CssSelector("input[value='Update']"));
            updateButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            IWebElement ToastMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(ToastMessage.Text.Contains("updated"), Is.True, "Skill was not edited");
        }
        public void DeleteSkill(IWebDriver driver)
        {
            GoToSkillTab();
            Wait.WaitToBeClickable(driver, "Css", "i[class$='remove icon']", 10);
            IWebElement deleteButton = driver.FindElement(By.CssSelector("i[class$='remove icon']"));
            deleteButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            IWebElement ToastMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            Assert.That(ToastMessage.Text.Contains("deleted"), Is.True, "Skill was not removed");
        }
        public void CancelSkill(IWebDriver driver)
        {
            GoToSkillTab();
            IWebElement addNewButton = driver.FindElement(By.CssSelector("div[class='ui teal button']"));
            addNewButton.Click();
            IWebElement skillText = driver.FindElement(By.CssSelector("input[placeholder='Add Skill']"));
            skillText.SendKeys("Java");
            IWebElement cancelButton = driver.FindElement(By.CssSelector("input[value='Cancel']"));
            cancelButton.Click();
            IWebElement addnewButtonAfterCancel = driver.FindElement(By.CssSelector("div[class='ui teal button']"));
            Assert.That(addnewButtonAfterCancel.Displayed);
        }
    }
}

