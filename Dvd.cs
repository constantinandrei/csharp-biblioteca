public class Dvd : Documento
{
   

    public Dvd(string id, string titolo, string settore, int anno, string scafalle, Persona autore, int durata) : base(id, titolo, settore, anno, scafalle, autore)
    {
        Durata = durata;
    }

    public int Durata { get; set; }
}