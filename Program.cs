using System.Runtime.ConstrainedExecution;

Utente io = new Utente("Todirascu", "Constantin", "andrei@mail.it", "637389233");

Console.WriteLine(io.Cognome);

Libro libro1 = new Libro("56478", "Libro");
Console.Write(libro1.GetType());
public class Biblioteca
{
    public List<Documento> documenti = new List<Documento>();
    public List<Utente> utenti = new List<Utente>();
    public List<Prestito> prestiti = new List<Prestito>();
}
