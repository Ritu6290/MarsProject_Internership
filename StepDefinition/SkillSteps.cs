using System;
using Mars_Project.Pages;
using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace Mars_Project.StepDefinition
{
    [Binding]
    public class SkillSteps : CommonDriver
    {
        private readonly ProfileSkill profileSkill;

        public SkillSteps()
        {
            profileSkill = new ProfileSkill(Hooks.Hooks.Driver);
        }

        [Given("I am logged into the application for skills")]
        public void GivenIAmLoggedIn()
        {
            //already handeled in setup
        }

        [When("I add a new skill")]
        public void WhenIAddSkill()
        {
            profileSkill.AddSkill(Hooks.Hooks.Driver); // Validation inside method
        }

        [When("I edit a skill")]
        public void WhenIEditSkill()
        {
            profileSkill.EditSkill(Hooks.Hooks.Driver); // Validation inside method
        }

        [When("I delete a skill")]
        public void WhenIDeleteSkill()
        {
            profileSkill.DeleteSkill(Hooks.Hooks.Driver); // Validation inside method
        }

        [When("I cancel a skill")]
        public void WhenICancelSkill()
        {
            profileSkill.CancelSkill(Hooks.Hooks.Driver); // Validation inside method
        }

        [Then("the skill should be added successfully")]
        [Then("the skill should be updated successfully")]
        [Then("the skill should be removed successfully")]
        [Then("the skill should not be updated successfully")]

        public void ThenSkillAction()
        {
            // Already handled inside Page Object methods
        }
    }
}

