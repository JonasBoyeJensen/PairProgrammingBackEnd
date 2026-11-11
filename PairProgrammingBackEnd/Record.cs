using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd;

public class Record : IRecord
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }

    public Record(int id, string titel, string artist, int duration, int publicationYear)
    {
        Id = id;
        Titel = titel;
        Artist = artist;
        Duration = duration;
        PublicationYear = publicationYear;
    }

    public Record()
    {
    }

    public override string ToString()
    {
        return $"Id: {Id}, Titel: {Titel}, Artist: {Artist}, Duration: {Duration}, PublicationYear: {PublicationYear}";
    }
}


