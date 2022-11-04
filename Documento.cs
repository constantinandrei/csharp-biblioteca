//I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
public class Documento
{
    public Documento(string id, string titolo)
    {
        Id = id;
        Titolo = titolo;
    }

    public string Id { get; }
    public string Titolo { get; set; }
    public string Settore { get; set; }
    public int Anno { get; set; }
    public bool Stato { get; set; }
    public string Scaffale { get; set; }
    public Persona autore { get; set; }

}
