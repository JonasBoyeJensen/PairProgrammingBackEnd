using Moq;

using PairProgrammingBackEnd;
using PairProgrammingBackEnd.Repositories;

namespace PairProgrammingBackEnd.UnitTests.Userstory1;

[TestClass]
public class RecordRepositoryTests
{
    [TestMethod]
    public void RecordRepository_GetAllRecords_ReturnsExpectedRecords()
    {
        // Arrange
        var repo = new RecordRepository();

        // Act
        IEnumerable<IRecord> records = repo.GetAllRecords();

        // Assert
        Assert.IsNotEmpty(records);

    }

}
