public class Motocicleta : Vehiculo
{
    public Boolean Manubrio {get; set;}
    public int Cilindraje {get; set;}

    //METODOS 

    public void Endo()
    {
        Console.WriteLine("Se picó la moto");
    }

    //crear clase taxi que herede de vehiculo con sus propiedades y metodos particulares
}