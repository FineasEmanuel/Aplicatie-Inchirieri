using System;
namespace Inchirieri.Modele
public class Masina
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Model { get; set; }
    public double PretPeZi { get; set; }
    public bool Disponibila { get; set; }

    public Masina(int id, string marca, string model, double pret, bool disponibila)
    {
        Id = id;
        Marca = marca;
        Model = model;
        PretPeZi = pret;
        Disponibila = disponibila;
    }
}