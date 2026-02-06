// See https://aka.ms/new-console-template for more information

//DATOS INGRESADOS 
using System.Timers;

Console.WriteLine("Jelou, ingresa 3 datos");

Console.WriteLine("Ingrese su primer registro: ");
int registro1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese el segundo gasto: ");
int registro2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el ultimo registro: ");
int registro3 = Convert.ToInt16(Console.ReadLine());


//PROCEDIMIENTOS

//Total
int total = registro1 + registro2 + registro3;
Console.WriteLine($"El total de ingresos es de: {total}");

// MAXIMO

if (registro2 < registro1 && registro2 > registro3)
{
    Console.WriteLine($"El maximo de los registros es: {registro1}  y el minimo es: {registro3}");
} 
else if (registro1 > registro3 && registro2 < registro3)
{
    Console.WriteLine($"El registro maximo es {registro1} y el minimo {registro2}");
} 
else if (registro2 > registro1 && registro1 > registro3)
{
    Console.WriteLine($"El registro maximo es: {registro2} y el minimo es: {registro3}");
}
else if (registro2 > registro3 && registro3 < registro1)
{
    Console.WriteLine($"El registro maximo es {registro2} y el registro minimo es {registro1}");
}
else if (registro3 > registro1 && registro1 > registro2)
{
    Console.WriteLine($"EL registro maximo es {registro3} y el minimo es {registro2}");
}
else
{
    Console.WriteLine($"El registro maximo {registro3} y el minimo es {registro1}");
}

// PROMEDIO

double promedio = total /3;

Console.WriteLine($"EL promedio de los registros es: {promedio}");





