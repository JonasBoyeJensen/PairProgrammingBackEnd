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

    public IEnumerable<IRecord> GetAllRecords(string? title = null, string? artist = null, int? duration = null, int? publicationYear = null)
    {
        IEnumerable<IRecord> records = _records.OrderBy(r => r.Id);

        if (title != null)
        {
            records = records.Where(r => r.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        if (artist != null)
        {
            records = records.Where(r => r.Artist.Contains(artist, StringComparison.OrdinalIgnoreCase));
        }

        if (duration != null)
        {
            records = records.Where(r => r.Duration == duration);
        }

        if (publicationYear != null)
        {
            records = records.Where(r => r.PublicationYear == publicationYear);
        }

        return records;
    }

    public void AddRecord(IRecord record)
    {
        record.Id = _nextId++;
        _records.Add(record);
    }
}
