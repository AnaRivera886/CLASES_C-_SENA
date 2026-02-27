public class Taxi : Vehiculo
{
    public string Flota {get; set;}
    public int Banderazo {get; set;}

    public decimal Taximetro (int Banderazo)
    {
        int result = 0;
        int Km = 10;
        result = Banderazo +Km;
        return result;
    }


}