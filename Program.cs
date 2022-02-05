double dd = 5.999999;
int drugi = (int)dd;
double ddd = drugi;

List<Osoba> osobe = new();
osobe.Add(new Radnik { _ime = "Neko", _prezime = "Nekic", _plata = 5 });
osobe.Add(new Student { _ime = "Pera", _prezime = "Peric", _smer = "onaj" });
osobe.Add(new Student { _ime = "Trecko", _prezime = "Treckovic", _smer = "neki" });

osobe.ForEach(osoba =>
{
    Console.Write($"{osoba._ime} {osoba._prezime}");
    if (osoba is Student s)
    {
        //Sam radi ovo :)
        //Student st = (Student)osoba;
        Console.Write($" smer:{s._smer}\n");
    }
    else if (osoba is Radnik r)
    {
        //Radnik rr = (Radnik)osoba;
        Console.Write($" plata:{r._plata}\n");
    }
});

public class Osoba
{
    public string _ime = string.Empty;
    public string _prezime = string.Empty;
}

public class Radnik : Osoba
{
    public decimal _plata;
}

public class Student : Osoba
{
    public string _smer;
}