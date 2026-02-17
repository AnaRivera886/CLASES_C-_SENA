Console.WriteLine("Ingrese su nombre: ");
string nombre = Convert.ToString(Console.ReadLine());

Console.WriteLine("¿Es premium? true/false");
bool premium = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("¿Cual fue su total en el carrito?: ");
int carrito = Convert.ToInt32(Console.ReadLine());

if (carrito >= 300000 && premium == true)
{
    int descuento = carrito*25/100;
    int totalDef = carrito - descuento;
    Console.WriteLine($"Hola {nombre}");
    Console.WriteLine($"Premiun: Si");
    Console.WriteLine($"Su subtotal es: {carrito}");
    Console.WriteLine("Categoria -> VIP PREMIUM");
    Console.WriteLine("Obtuvo un 25% de descuento");
    Console.WriteLine($"Su valor total es de: {totalDef}");
}
else if ( carrito >= 300000 && premium != true)
{
    int descuento = carrito*15/100;
    int totalDef = carrito - descuento;
    Console.WriteLine($"Hola {nombre}");
    Console.WriteLine($"Premiun: No");
    Console.WriteLine($"Su subtotal es: {carrito}");
    Console.WriteLine("Categoria -> CLIENTE FRECUENTE");
    Console.WriteLine("Obtuvo un 15% de descuento");
    Console.WriteLine($"Su valor total es de: {totalDef}");
}
else if ( carrito >= 100000 || premium == true)
{
    int descuento = carrito*10/100;
    int totalDef = carrito - descuento;
    Console.WriteLine($"Hola {nombre}");
    Console.WriteLine($"Premiun: Si");
    Console.WriteLine($"Su subtotal es: {carrito}");
    Console.WriteLine("Categoria -> DESCUENTO BASICO");
    Console.WriteLine("Obtuvo un 10% de descuento");
    Console.WriteLine($"Su valor total es de: {totalDef}");
}
else
{
    Console.WriteLine($"Hola {nombre}");
    Console.WriteLine($"Premiun: No");
    Console.WriteLine($"Su subtotal es: {carrito}");
    Console.WriteLine("No aplica descuento");
    Console.WriteLine($"Su total a pagar es {carrito}");
}
