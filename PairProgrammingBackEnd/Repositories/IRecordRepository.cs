namespace PairProgrammingBackEnd.Repositories
{
    public interface IRecordRepository
    {
        IEnumerable<IRecord> GetAllRecords(string? title = null, string? artist = null, int? duration = null, int? publicationYear = null);
        public void AddRecord(IRecord record);
        public IRecord? GetById(int id);
        public IRecord? DeleteRecord(int id);
    }
}