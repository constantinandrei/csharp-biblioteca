using System.Globalization;
using System.Runtime.ConstrainedExecution;
// inizializzo una nuova biblioteca
Biblioteca biblioteca = new Biblioteca();

// inserisco dei libri e dvd

biblioteca.documenti.Add(new Libro("873", "La ricerca", "Narrativa", 1956, "B54", new Persona("Brondi", "Fabio"), 234));
biblioteca.documenti.Add(new Libro("726", "La poetessa", "Narrativa", 1989, "A24", new Persona("Prince", "Mattia"), 456));
biblioteca.documenti.Add(new Libro("123", "Il tempo brutto", "Storia", 2022, "C03", new Persona("Biestra", "Edoardo"), 1234));
biblioteca.documenti.Add(new Libro("821", "Cinque terre", "Geografia", 1956, "A14", new Persona("Innocenti", "Claudia"), 340));
biblioteca.documenti.Add(new Dvd("183", "Film lungo", "Avventura", 2009, "F54", new Persona("Kackson", "Pietro"), 234));
biblioteca.documenti.Add(new Dvd("293", "Film Corto", "Cortometraggio", 1956, "F54", new Persona("Little", "Mike"), 14));
biblioteca.documenti.Add(new Dvd("393", "La ricerca", "Investigativo", 2013, "G54", new Persona("Bruni", "Brunio"), 110));
biblioteca.documenti.Add(new Dvd("262", "La mummia", "Horror", 1924, "H54", new Persona("Ultimo", "Michele"), 434));

// inserisco dei utenti

biblioteca.utenti.Add(new Utente("Todirascu", "Andrei", "andrei@gmail.it", "34628839303"));
biblioteca.utenti.Add(new Utente("Bulleri", "Daniele", "andrei@gmail.it", "34628833833"));
biblioteca.utenti.Add(new Utente("Varramista", "Giulia", "giulia@gmail.it", "382903489303"));


// inserisco dei prestiti

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[0], biblioteca.documenti[2], "04/11/22", "24/11/22"));
biblioteca.documenti[2].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[2], biblioteca.documenti[5], "04/11/22", "24/11/22"));
biblioteca.documenti[5].Disponibile = false;

biblioteca.prestiti.Add(new Prestito(biblioteca.utenti[1], biblioteca.documenti[1], "04/11/22", "24/11/22"));
biblioteca.documenti[1].Disponibile = false;

// INIZIO PROGRAMMA

// ricerca se l'utente è registrato

biblioteca.RicercaPrestito();


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

    public Utente TrovaUtente(string cognome, string nome)
    {
        foreach (Utente utente in utenti)
        {
            if (utente.Cognome.Equals(cognome) && utente.Nome.Equals(nome))
            {
                    return utente;
            }
        }

        return null;
    }

    public Persona ChiediDatiUtente() {

        
        Console.WriteLine("Inserisci il cognome dell'utente");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci il nome dell'utente");
        string nome = Console.ReadLine();

        return new Persona(cognome, nome);
    }

    public Utente UtenteRegistrato()
    {
        Persona daCercare = ChiediDatiUtente();

        Utente utente = TrovaUtente(daCercare.Cognome, daCercare.Nome);
        if (utente != null)
        {
            Console.WriteLine($"{utente.Cognome} {utente.Nome} è registrato");
            Console.WriteLine("I suoi dati sono: ");
            Console.WriteLine($"telefono : {utente.Telefono}");
            Console.WriteLine($"email    : {utente.Email}");
            return utente;
        } else
        {
            Console.WriteLine("L'utente NON è registrato");
            return null;
        }
    }

    public void InserisciPrestito()
    {
        Utente utente = UtenteRegistrato();
        if (utente != null)
        {
            Console.WriteLine("Inserire il codice del documento");
            Documento documento = TrovaDocumento(Console.ReadLine());
            if (documento != null)
            {
                if (!documento.Disponibile)
                {
                    Console.WriteLine($"Il libro attualmente è preso in prestito");
                    return;
                }
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataInizio = Console.ReadLine();
                Console.WriteLine("Inserire la data d'inizio del prestito");
                string dataFine = Console.ReadLine();

                prestiti.Add(new Prestito(utente, documento, dataInizio, dataFine));
                documento.Disponibile = false;
                Console.WriteLine($"Il prestito è stato inserito corettamene");
                return;
            }
            Console.WriteLine("Documento non trovato");
        }
    }

    public List<Prestito> RicercaPrestito()
    {
        Persona utente = ChiediDatiUtente();
        List<Prestito> ret = new List<Prestito>();

        foreach (Prestito prestito in prestiti)
        {
            if (prestito.Utente.Cognome.Equals(utente.Cognome) && prestito.Utente.Nome.Equals(utente.Nome)){
                ret.Add(prestito);
            }
        }

        StampaPrestiti(ret);

        return ret;
    }

    public void StampaPrestiti(List<Prestito> prestiti)
    {
        foreach (Prestito prestito in prestiti)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Titolo: {prestito.Documento.Titolo}");
        }
    }
}
