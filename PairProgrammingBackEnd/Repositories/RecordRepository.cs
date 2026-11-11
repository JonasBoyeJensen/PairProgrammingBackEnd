using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd.Repositories;

public class RecordRepostory : IRecordRepostory
{
    private List<IRecord> _records;

    public RecordRepostory()
    {
        _records = new List<IRecord>();
    }

    public IEnumerable<IRecord> GetAllRecords()
    {
        return _records;
    }
}
