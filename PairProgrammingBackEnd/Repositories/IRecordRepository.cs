namespace PairProgrammingBackEnd.Repositories
{
    public interface IRecordRepository
    {
        IEnumerable<IRecord> GetAllRecords(string? title = null, string? artist = null, int? duration = null, int? publicationYear = null);
    }
}