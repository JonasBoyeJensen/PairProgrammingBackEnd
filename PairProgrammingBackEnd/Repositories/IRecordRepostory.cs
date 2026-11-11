namespace PairProgrammingBackEnd.Repositories
{
    public interface IRecordRepostory
    {
        IEnumerable<IRecord> GetAllRecords();
    }
}