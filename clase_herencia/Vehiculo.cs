public class Vehiculo
{
// CLASES 
    public string PLaca { get; set; }
    public string Marca { get; set; }
    public string Linea { get; set; }
    public int Modelo { get; set; }

// METODOS

    public void Prender(){
        Console.WriteLine("El vehiculo esta encendido");
    }

    public void Acelerar()
    {
        Console.WriteLine("EL vehiculo está en movimiento");
    }

    public void Frenar(){
        Console.WriteLine("El vehiculo está frenando");
    }

    public void Apagar()
    {
        Console.WriteLine("El vehiculo se apagó");
    }



}