using AutomationExercise.Helpers;
using AutomationExercise.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationExercise.Steps
{
    [Binding]
    public class PLPSteps : Base
    {

        Utilities ut = new Utilities(Driver);
        HeaderPage hp = new HeaderPage(Driver);

        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ut.ClickOnElement(hp.ProductsLink);
        }
        
        [When(@"user enters name of the product in the search bar")]
        public void WhenUserEntersNameOfTheProductInTheSearchBar()
        {
            PLP Plpage = new PLP(Driver);
            ut.EnterTextInElement(Plpage.SearchBar, TestConstants.Product);
        }
        
        [When(@"click on the magnifying glass icon")]
        public void WhenClickOnTheMagnifyingGlassIcon()
        {
            PLP Plpage = new PLP(Driver);
            ut.ClickOnElement(Plpage.SearchBarButton);
        }

        [Then(@"user will be able to see searched value on page ""(.*)""")]
        public void ThenUserWillBeAbleToSeeSearchedValueOnPage(string searchedValue)
        {
            Assert.True(ut.TextPresentInElement(searchedValue), "Searched value doesn´t appear");

         }
    }
}
