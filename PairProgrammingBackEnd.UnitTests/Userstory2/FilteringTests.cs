using Moq;

using PairProgrammingBackEnd;
using PairProgrammingBackEnd.Repositories;

namespace PairProgrammingBackEnd.UnitTests.Userstory2;

[TestClass]
public class FilteringTests
{
    [TestMethod]
    [DataRow("Dark Side of The Moon", null, null, null)]
    [DataRow(null, "Pink Floyd", null, null)]
    [DataRow(null, null, 180, null)]
    [DataRow(null, null, null, 1971)]
    public void FilteringNotEmpty(string? title, string? artist, int? duration, int? publicationYear)
    {
        // Arrange
        var repo = new RecordRepository();
        repo.AddRecord(new Record { Title = "Dark Side of The Moon", Artist = "Pink Floyd", Duration = 180, PublicationYear = 1971 });

        // Act
        IEnumerable<IRecord> records = repo.GetAllRecords(title, artist, duration, publicationYear);

        // Assert
        Assert.IsNotEmpty(records);
    }

    [TestMethod]
    [DataRow("Nonexistent Title", null, null, null)]
    [DataRow(null, "Nonexistent Artist", null, null)]
    [DataRow(null, null, 9999, null)]
    [DataRow(null, null, null, 9999)]
    public void FilteringEmpty(string? title, string? artist, int? duration, int? publicationYear)
    {
        // Arrange
        var repo = new RecordRepository();
        repo.AddRecord(new Record { Title = "Dark Side of The Moon", Artist = "Pink Floyd", Duration = 180, PublicationYear = 1971 });

        // Act
        IEnumerable<IRecord> records = repo.GetAllRecords(title, artist, duration, publicationYear);

        // Assert
        Assert.IsEmpty(records);
    }

}
