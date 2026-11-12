namespace PairProgrammingBackEnd
{
    public interface IRecord
    {
        string Artist { get; set; }
        int Duration { get; set; }
        int Id { get; set; }
        int PublicationYear { get; set; }
        string Title { get; set; }

        string ToString();
    }
}