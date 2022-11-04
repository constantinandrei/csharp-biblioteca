using System.Runtime.ConstrainedExecution;
// inizializzo una nuova biblioteca
Biblioteca biblioteca = new Biblioteca();

// inserisco dei libri e dvd

biblioteca.documenti.Add(new Libro("8738393", "La ricerca"));
Libro laRicerca = (Libro)biblioteca.TrovaDocumento("8738393");
laRicerca.Pagine = 345;
laRicerca.Titolo = "nuovo titolo";

Console.WriteLine(biblioteca.documenti[0].Titolo);
public class Biblioteca
{
    public List<Documento> documenti = new List<Documento>();
    public List<Utente> utenti = new List<Utente>();
    public List<Prestito> prestiti = new List<Prestito>();

    public Documento TrovaDocumento(string id)
    {
        foreach (Documento documento in documenti)
        {
            if (documento.Id.Equals(id))
            {
                return documento;
            }
        }

        return null;
    }
}
