namespace Inchirieri.Modele
public class Angajat
{
    public string Username { get; set; }
    public string Parola { get; set; }

    public Angajat(string user, string parola)
    {
        Username = user;
        Parola = parola;
    }
}
