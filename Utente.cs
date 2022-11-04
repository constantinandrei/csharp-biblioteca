
//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,


//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
//



//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.


//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente

public class Utente : Persona
{
    
    public string Email { get; }
    public string Password { get; }
    public string Telefono { get; }

}

