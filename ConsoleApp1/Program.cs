class Zvire
{
    private string zvuk;
    private string názevZ;
    private string rasa;

    public Zvire(string zvuk, string rasa, string názevZ)
    {
        this.zvuk = zvuk;
        this.rasa = rasa;
        this.názevZ = názevZ;
    }

    public string GetZvuk()
    {
        return zvuk;
    }

    public string GetNazevZ()
    {
        return názevZ;
    }

    public string GetRasa()
    {
        return rasa;
    }

    public void SetZvuk(string novyZvuk)
    {
        zvuk = novyZvuk;
    }

    public void SetNazevZ(string novyNazev)
    {
        názevZ = novyNazev;
    }

    public void SetRasa(string novaRasa)
    {
        rasa = novaRasa;
    }
    
}