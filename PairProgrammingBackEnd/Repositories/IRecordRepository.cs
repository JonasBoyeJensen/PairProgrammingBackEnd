namespace PairProgrammingBackEnd.Repositories
{
    public interface IRecordRepository
    {
        IEnumerable<IRecord> GetAllRecords();
    }
}