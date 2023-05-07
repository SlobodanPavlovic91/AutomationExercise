using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClickOnElement(hp.ContactLink);
        }
        
        [When(@"user enters all required fields")]
        public void WhenUserEntersAllRequiredFields()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.EnterTextInElement(cup.name, TestConstants.FirstName + " " + TestConstants.LastName);
            ut.EnterTextInElement(cup.email, TestConstants.UserName);
            ut.EnterTextInElement(cup.subject, TestConstants.Subject);
            ut.EnterTextInElement(cup.message, TestConstants.Message);
            string path = @"C:\Users\slobodan.pavlovic\Desktop\Deutsch\QA\QA Engineer KURS-dan1.pdf";
            Driver.FindElement(cup.uploadBtn).SendKeys(path);
        }
        
        [When(@"submits contact us form")]
        public void WhenSubmitsContactUsForm()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            //ut.ClickOnElement(cup.submit);
            Driver.FindElement(cup.form).Submit();

        }
        
        [When(@"confirms the prompt message")]
        public void WhenConfirmsThePromptMessage()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
        
        [Then(@"user will receive '(.*)'")]
        public void ThenUserWillReceive(string successMessage)
        {
            Assert.True(ut.TextPresentInElement(successMessage), "Users´s message was not successfully sent via contact us form");

        }
    }
}
