using OpenQA.Selenium;

namespace SunblazeFE.PagesSE
{
    public class SortableDataTables : Homepage
    {
        private readonly IWebDriver _driver;
        public By _tblTable1 = By.XPath("//table[@id='table1']");
        public List<Dictionary<string, string>> GetTable(By by)
        {
            List<Dictionary<string, string>> allTableData = new List<Dictionary<string, string>>();
            //Get Headers which will make sorting easier
            //Dynamic XPath expression using base table XPath + path to headers
            By tableHeadersLoc = By.XPath($"{_tblTable1.ToString().Split(" ")[1]}/thead/tr/th");
            IReadOnlyList<IWebElement> allHeaderElements = base.GetElements(tableHeadersLoc);
            List<string> allHeaderNames = new List<string>();
            foreach (WebElement header in allHeaderElements)
            {
                string headerName = header.Text;
                allHeaderNames.Add(headerName);
            }
            //Get List of all rows
            By rowLoc = By.XPath($"{_tblTable1.ToString().Split(" ")[1]}/tbody/tr");
            IReadOnlyList<IWebElement> allRowsElements = base.GetElements(rowLoc);
            //Starting from 1 as XPath index starts from 1
            for (int i = 1; i <= allRowsElements.Count; i++)
            {
                //Iterating over each row in table
                string specificRowLoc = $"{_tblTable1.ToString().Split(" ")[1]}/tbody/tr[{i}]";
                //Locating only cells of specific row.
                IReadOnlyList<IWebElement> allColumnsElements = _driver.FindElement(By.XPath(specificRowLoc)).FindElements(By.TagName("td"));
                //Creating a Dictionary to store key-value pair data
                Dictionary<string, string> eachRowData = new Dictionary<string, string>();
                //Iterating over each cell in row
                for (int j = 0; j < allColumnsElements.Count; j++)
                {
                    //Get cell value and create new Dictionary entry of pair {header name : cell value}
                    string cellValue = allColumnsElements[j].Text;
                    eachRowData.Add(allHeaderNames[j], cellValue);
                }
                //Add Dictionary of row to list
                allTableData.Add(eachRowData);
            }
            return allTableData;
        }
        public List<Dictionary<string, string>> TableDataSortedBy(List<Dictionary<string, string>> tableData, string sortByValue, bool orderAsc)
        {
            List<Dictionary<string, string>> sortedTable = new List<Dictionary<string, string>>();
            //Create a Dictionary of original index order and corresponding Column value, => {0, "Smith"}{1, "Bach"}{2, "Doe"}{3, "Conway"}
            Dictionary<int, string> unsortedValues = new Dictionary<int, string>();
            int iterator = 0;
            foreach (Dictionary<string, string> item in tableData)
            {
                unsortedValues.Add(iterator, item[sortByValue]);
                iterator++;
            }
            //Sort the map by its values => {1, "Bach"}{3, "Conway"}{2, "Doe"}{0, "Smith"}
            //Order by Ascending or Descending, depending on value of orderAsc boolean
            //Conditional direct assignment is required as var type can't be used in If Statement here
            var sortedByValueMap = orderAsc ? unsortedValues.OrderBy(value => value.Value) : unsortedValues.OrderBy(value => value.Value).Reverse();
            //Add values to sortedTable using order and keys from sortedByValueMap
            foreach (var entry in sortedByValueMap)
            {
                sortedTable.Add(tableData.ElementAt(entry.Key));
            }
            return sortedTable;
        }
        public void SortTableBy(string sortByValue)
        {
            By sortLoc = By.XPath($"{_tblTable1.ToString().Split(" ")[1]}/thead/tr/th/span[text()='{sortByValue}']");
            base.ClickOn(sortLoc);
        }
        //Inherit from Homepage Class will initiate its Constructor automatically
        public SortableDataTables(IWebDriver driver) : base(driver)
        {
            //Set driver here or else it will not be correctly referenced resulting in Object Reference Not set to Instance of Object error
            _driver = driver;
            //Go to Test Page
            _driver.FindElement(_lnkSortableDataTables).Click();
        }
    }
}
