using System;

using System;
namespace Inchirieri.Modele
public class Inchiriere
{
    public Masina Masina { get; set; }
    public Client Client { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public double Total { get; set; }

    public Inchiriere(Masina masina, Client client, DateTime start, DateTime end, double total)
    {
        Masina = masina;
        Client = client;
        Start = start;
        End = end;
        Total = total;
    }
}