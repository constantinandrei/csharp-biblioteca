public class Dvd : Documento
{
    public Dvd(string id, string titolo) : base(id, titolo)
    {
    }

    public string Durata { get; }
}