
public class Zvire
{
    private string zvuk;
    private string názevZ;
    private string rasa;

    public Zvire(string zvuk, string názevZ, string rasa)
    {
        this.zvuk = zvuk;
        this.názevZ = názevZ;
        this.rasa = rasa;
    }

    public void VydatZvuk()
    {
        Console.WriteLine(zvuk);
    }

    public string GetNazevZ()
    {
        return názevZ;
    }

    public string GetRasa()
    {
        return rasa;
    }
}

public class Pes : Zvire
{
    public Pes(string rasa) : base("Haf haf", "Pes", rasa) { }
}

public class Kocka : Zvire
{
    public Kocka(string rasa) : base("Mňau mňau", "Kočka", rasa) { }
}

public class Ptak : Zvire
{
    public Ptak(string rasa) : base("Píp píp", "Pták", rasa) { }
}

public class Had : Zvire
{
    public Had(string rasa) : base("Ssssssss", "Had", rasa) { }
}

public class Kralik : Zvire
{
    public Kralik(string rasa) : base("Vrrrrr (potichu)", "Králík", rasa) { }
}





public class Kun : Zvire
{
    public Kun(string rasa) : base("Ihahaha", "Kůň", rasa) { }
}
public class Osel : Zvire
{
    public Osel(string rasa) : base("Ia ia", "Osel", rasa) { }
}
public class Uzovka : Zvire
{
    public Uzovka(string rasa) : base("Ssssssss", "Užovka", rasa) { }
}





public class Zmije : Zvire
{
    public Zmije(string rasa) : base("Sssssssssss", "Zmije", rasa) { }
}
public class Kapr : Zvire
{
    public Kapr(string rasa) : base("p p", "Kapr", rasa) { }
}

public class Papousek : Zvire
{
    public Papousek(string rasa) : base("Jak se máš?", "Papoušek", rasa) { }
}



public static class VytvorZvire
{

    public static Zvire VytvorPsa(string rasa)
    {
        return new Pes(rasa);
    }

    public static Zvire VytvorKocku(string rasa)
    {
        return new Kocka(rasa);
    }

    public static Zvire VytvorPtaka(string rasa)
    {
        return new Pták(rasa);
    }






   
    public static Zvire VytvorHada(string rasa)
    {
        return new Had(rasa);
    }

   
    public static Zvire VytvorKralika(string rasa)
    {
        return new Kralik(rasa);
    }

    
    public static Zvire VytvorKone(string rasa)
    {
        return new Kun(rasa);
    }






  
    public static Zvire VytvorOsla(string rasa)
    {
        return new Osel(rasa);
    }

    /
    public static Zvire VytvorUzovku(string rasa)
    {
        return new Uzovka(rasa);
    }

   
    public static Zvire VytvorZmiji(string rasa)
    {
        return new Zmije(rasa);
    }






    public static Zvire VytvorKapra(string rasa)
    {
        return new Kapr(rasa);
    }

    public static Zvire VytvorPapouska(string rasa)
    {
        return new Papousek(rasa);
    }





}
