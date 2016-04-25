﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Extensions;
using ClassLibrary1.Steps;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace ClassLibrary1.Locators
{
  
  public class XdBpanel
  {
    public static IWebDriver Driver => FeatureContext.Current.Get<IWebDriver>();

    public static IEnumerable<IWebElement> OpenXdbSlidebar
      => 
      Driver.WaitUntilElementsPresent(By.CssSelector(".btn.btn-info.sidebar-closed"));

    public static IEnumerable<IWebElement> XDBpanelHeader
      => Driver.WaitUntilElementsPresent(By.CssSelector("a.panel-title"));

    public static IEnumerable<IWebElement> EngagementPlansList
      => Driver.FindElements(By.CssSelector(".table.table-condensed.table-borderless>tbody>tr>td>small"));

    public static IEnumerable<IWebElement> EngagementPlanState
      => Driver.FindElements(By.CssSelector(".table.table-condensed.table-borderless>tbody>tr>td"));

    public static IEnumerable<IWebElement> MediaBody
      => Driver.FindElements(By.CssSelector(".media-body>dl>dd"));

   public static  IWebElement OnsiteBehavior
      => Driver.FindElement(By.CssSelector("#onsiteBehaviorPanel"));

    public static IEnumerable<IWebElement> OnsiteBehaviorSections
      => XdBpanel.OnsiteBehavior.FindElements(By.CssSelector(".media"));



          => Driver.WaitUntilElementsPresent(By.CssSelector(".panel-title.collapsed"));

        public static IEnumerable<IWebElement> XdBpanelMediaTitle
              => Driver.WaitUntilElementsPresent(By.CssSelector(".panel-collapse.collapse.in h4.media-title"));
        public static IEnumerable<IWebElement> XdBpanelText
          => Driver.WaitUntilElementsPresent(By.CssSelector("div.alert.alert-info"));
  }
}
