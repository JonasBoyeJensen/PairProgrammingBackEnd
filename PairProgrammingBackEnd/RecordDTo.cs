using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd;

public class RecordDTO
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }

    public RecordDTO(string title, string artist, int duration, int publicationYear)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        PublicationYear = publicationYear;
    }

}
