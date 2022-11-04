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
    public Documento(string id, string titolo, string settore, int anno, string scafalle, Persona autore)
    {
        Id = id;
        Titolo = titolo;
        Settore = settore;
        Anno = anno;
        Scaffale = scafalle;
        Autore = autore;
        Disponibile = true;
    }

    public string Id { get; }
    public string Titolo { get; set; }
    public string Settore { get; set; }
    public int Anno { get; set; }
    public bool Disponibile { get; set; }
    public string Scaffale { get; set; }
    public Persona Autore { get; set; }

}
