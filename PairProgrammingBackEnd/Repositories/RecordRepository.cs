using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd.Repositories;

public class RecordRepository : IRecordRepository
{
    private List<IRecord> _records;

    private static int _nextId = 1;

    public RecordRepository()
    {
        _records = new List<IRecord>();

        AddRecord(new Record { Title = "Dark Side of The Moon", Artist = "Pink Floyd", Duration = 2579, PublicationYear = 1973 });
        AddRecord(new Record { Title = "Abbey Road", Artist = "The Beatles", Duration = 2580, PublicationYear = 1969 });
        AddRecord(new Record { Title = "Thriller", Artist = "Michael Jackson", Duration = 2581, PublicationYear = 1982 });
    }

    public IEnumerable<IRecord> GetAllRecords()
    {
        return _records;
    }

    public void AddRecord(IRecord record)
    {
        record.Id = _nextId++;
        _records.Add(record);
    }
}
