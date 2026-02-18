Console.WriteLine("Hola! Que vas a enviar? Ingresa la siguiente Info: ");

Console.WriteLine("Ingrese el destino de su paquete: ");
string destino = Convert.ToString(Console.ReadLine().ToLower());

Console.WriteLine("Ingrese el peso del paquete: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Es express? true/false");
bool express = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Su paquete es fragil? true/false");
bool fragil = Convert.ToBoolean(Console.ReadLine());

string zonas = "";
int precio = 0;

switch (destino)
{
    case "bogota" or "medellin" or "cali":
        zonas = "ZONA PRINCIPAL";
        precio = 8000;
        break;

    case "barranquilla" or "cartagena" or "bucaramanga":
        zonas = "ZONA INTERMEDIA";
        precio = 12000;
        break;

    default:
        zonas = "ZONA REMOTA";
        precio = 18000;    
        break;
}

int i = 0;
int precio_peso = 0;
int precio_express = 0;
int precio_fragil = 0;

while (i<=2)
{
    if (peso >= 5)
    {
        precio_peso = precio + 5000;
        i+=1;
    }
    else if (peso > 2)
    {  
        precio_peso = precio +2500;
        i+=1;
    }
}

Console.WriteLine(precio_peso);

if (express == true && zonas == "ZONA PRINCIPAL")
    {
        precio_express = precio_peso + 6000;
    }
    else if (express == true && zonas == "ZONA INTERMEDIA")
    {
        precio_express = precio_peso + 6000;
}
else if (express == true)
{
    precio_express = precio_peso;
    Console.WriteLine("SU ENVIO ES ESTANDAR");
}
else
{
    precio_express = 0; 
}

Console.WriteLine(precio_express);

if (fragil == true && express == true)
{
    if (peso > 3)
    {
        precio_fragil = precio_express + 4000;
    }if (peso <= 3)
    {
        precio_fragil = precio_express + 2000;
    }

}else if(fragil == true && express == false)
{
    if (peso > 3)
    {
        precio_fragil = precio_peso + 4000;
    }if (peso <= 3)
    {
        precio_fragil = precio_peso + 2000;
    }
} else if (fragil == false && express == true)
{
    precio_fragil = precio_express;
}
else
{
    precio_fragil = 0;
}

Console.WriteLine(precio_fragil);


Console.WriteLine("\t---------------------------");

if (express == false && fragil == false)
{
    int total = precio_peso;

    Console.WriteLine($"DESTINO: {destino}");
    Console.WriteLine($"PESO: {peso}");
    Console.WriteLine($"TIPO DE ENVIO: {zonas}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO DEL PESO: {precio_peso}");
    Console.WriteLine($"PRECIO EXPRESS: No aplica");
    Console.WriteLine($"PRECIO FRAGIL: No aplica");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO TOTAL: {total}");
}
else if (express == false && fragil == true)
{
    int total = precio_fragil;
    Console.WriteLine($"DESTINO: {destino}");
    Console.WriteLine($"PESO: {peso}");
    Console.WriteLine($"TIPO DE ENVIO: {zonas}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO DEL PESO: {precio_peso}");
    Console.WriteLine($"PRECIO EXPRESS: No aplica");
    Console.WriteLine($"PRECIO FRAGIL: {precio_fragil}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO TOTAL: {total}");
}
else if (express == true && fragil == false)
{
    int total = precio_express;
    Console.WriteLine($"DESTINO: {destino}");
    Console.WriteLine($"PESO: {peso}");
    Console.WriteLine($"TIPO DE ENVIO: {zonas}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO DEL PESO: {precio_peso}");
    Console.WriteLine($"PRECIO EXPRESS: {precio_express}");
    Console.WriteLine($"PRECIO FRAGIL: No aplica");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO TOTAL: {total}");
}else
{
    int total = precio_fragil;

    Console.WriteLine($"DESTINO: {destino}");
    Console.WriteLine($"PESO: {peso}");
    Console.WriteLine($"TIPO DE ENVIO: {zonas}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO DEL PESO: {precio_peso}");
    Console.WriteLine($"PRECIO EXPRESS: {precio_express}");
    Console.WriteLine($"PRECIO FRAGIL: {precio_fragil}");

    Console.WriteLine("\t---------------------------");

    Console.WriteLine($"PRECIO TOTAL: {total}");
}