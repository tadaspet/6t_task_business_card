using II._19.Advanced.Exam;

namespace ExamUnitTests
{
    [TestClass]
    public class TableMenuTest
    {
        [TestMethod]
        public void SetTableTakenToFalse()
        {
            //Arrange
            var tableMenuClass = new TableMenu();
            var tables = tableMenuClass.CreateTables();
            int tableNo = 1;

            // Act
            TableItem selectedTable = tables.FirstOrDefault(no => no.TableNo == tableNo);
            tableMenuClass.SetTableTaken(tableNo);

            // Assert
            Assert.IsFalse(selectedTable.IsFree);
        }
        [TestMethod]
        public void SetTableEmptyTrue()
        {
            //Arrange
            var tableMenuClass = new TableMenu();
            var tables = tableMenuClass.CreateTables();
            int tableNo = 3;


            // Act
            TableItem selectedTable = tables.FirstOrDefault(no => no.TableNo == tableNo);
            tableMenuClass.SetTableEmpty(tableNo);

            // Assert
            Assert.IsTrue(selectedTable.IsFree);
        }
    }
}