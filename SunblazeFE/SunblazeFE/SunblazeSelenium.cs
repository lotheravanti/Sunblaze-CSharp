using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SunblazeFE.PagesSE;

namespace SunblazeFE
{
    public class SeleniumTests
      {
        IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            //Need to match IWebDriver type between _driver and driver by getting .driver object from SeleniumDriver class
            IWebDriver driver = new SeleniumDriver().driver;
            _driver = driver;
            Console.WriteLine("Starting Tests");
        }

        [Test]
        public void OpenHomepage()
        {
            Homepage homePage = new(_driver);
            String verifyHomePage = homePage.GetText(homePage._txtHomePagetitle);
            Assert.That(verifyHomePage, Is.EqualTo("Welcome to the-internet"), "Homepage text should appear");
        }

        [Test]
        public void AddRemove()
        {
            AddRemove addRemove = new(_driver);
            int timesClick = 3;
            addRemove.ClickMultiple(addRemove._btnAddElement, timesClick);
            Thread.Sleep(1000);
            int numDeleteButtons = addRemove.GetElements(addRemove._btnDeleteElement).Count;
            Assert.That(numDeleteButtons, Is.EqualTo(timesClick), $"The Add button was clicked {timesClick} times and that many Delete buttons appeared");
            addRemove.ClickMultiple(addRemove._btnDeleteElement, timesClick - 1);
            int remainingDeleteButtons = addRemove.GetElements(addRemove._btnDeleteElement).Count;
            Assert.That(remainingDeleteButtons, Is.EqualTo(1), "One Delete button remaining");
            Thread.Sleep(1000);
        }

        [Test]
        public void SelectFromDropdown()
        {
            Dropdown dropdown = new(_driver);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 2");
            //So we can observe it actually changed
            Thread.Sleep(1000);
            dropdown.SelectByTextDropdown(dropdown.dropdownField, "Option 1");
        }

        [Test]
        public void InputNumber()
        {
            Inputs inputs = new(_driver);
            //Inputs Class inherits FieldSendKeys method from Homepage Class
            inputs.FieldSendKeys(inputs.inputNumber, "23");
        }

        [Test]
        public void SortableDataTables()
        {
            SortableDataTables sortableDataTables = new(_driver);
            //Get table entries in List of LinkedHashMaps format(will always be sorted as it is on the web page)
            List<Dictionary<string, string>> initialTable = sortableDataTables.GetTable(sortableDataTables._tblTable1);
            //Sort by Last Name Ascending and check if data matches
            string sortByValue = "Last Name";
            List<Dictionary<string, string>> tableDataSortedAsc = sortableDataTables.TableDataSortedBy(initialTable, sortByValue, true);
            sortableDataTables.SortTableBy(sortByValue);
            List<Dictionary<string, string>> sortedTableAsc = sortableDataTables.GetTable(sortableDataTables._tblTable1);
            Assert.That(tableDataSortedAsc, Is.EqualTo(sortedTableAsc), "One Delete button remaining");
            //Sort by Last Name Descending and check if data matches
            List<Dictionary<string, string>> tableDataSortedDesc = sortableDataTables.TableDataSortedBy(initialTable, sortByValue, false);
            sortableDataTables.SortTableBy(sortByValue);
            List<Dictionary<string, string>> sortedTableDesc = sortableDataTables.GetTable(sortableDataTables._tblTable1);
            Assert.That(tableDataSortedDesc, Is.EqualTo(sortedTableDesc), "One Delete button remaining");
            Console.Write($"\n{{");
            //Method for printing items in List of Dictionaries to console
            foreach (var dict in sortedTableAsc)
            {
                Console.Write($"{{");
                foreach (var keyValuePair in dict)
                {
                    Console.Write($"{keyValuePair.Key}: {keyValuePair.Value}, ");
                }
                Console.Write($"}}");
            }
            Console.Write($"}}");
        }

        //Add a wait at the end of every test for visibility when running manually
        //Ensure driver is closed
        [TearDown]
        public void Dispose()
        {
            Thread.Sleep(2000);
            _driver.Quit();
            Console.WriteLine("Test(s) completed");
        }
      }
}