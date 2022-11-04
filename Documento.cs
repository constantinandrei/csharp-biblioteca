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
    public string Id { get; }
    public string Titolo { get; }
    public string Settore { get; }
    public int Anno { get; }
    public bool Stato { get; }
    public string Scaffale { get; }
    public Persona autore { get; }

}
