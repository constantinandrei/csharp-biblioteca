public class Libro : Documento
{
    public Libro(string id, string titolo) : base(id, titolo)
    {
    }

    public int Pagine { get; }
}