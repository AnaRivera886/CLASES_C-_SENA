// // See https://aka.ms/new-console-template for more information
// using System.Security;

// Console.WriteLine("Hello, World!");

// /* DECLARACION DE VARIABLE */

// /* tipo de dato + nombre de variable = valor */
// string nombre = "Ana";
// byte edad = 18;
// sbyte dias = -5;
// short temperatura = -10;
// ushort distancia = 30000;
// int poblacion = 1000000;    
// bool mujer = true;
// DateTime nacimiento = new DateTime(2007, 8, 8);
// double altura = 1.65;
// char inicial = 'A';
// float peso = 55.5f;
// long poblacionMundial = 8000000000;
// decimal saldoCuentaBancaria = 1500.75m;
// object objeto = "Soy un objeto";
// var ciudad = "Medellin";
// dynamic dinamica = 42;
// const double PI = 3.14159;


// //USO DE VARIABLES Y OPERACIONES
// Console.WriteLine("Nombre: " + nombre);
// Console.WriteLine("Edad: " + edad);
// Console.WriteLine("Altura: " + altura);
// Console.WriteLine("fecha de nacimiento: " + nacimiento.ToShortDateString()); /*convierte la fecha en formato corto*/


// //OPERACIONES CON VARIABLES
// int edadEn5Anios = edad + 5;
// Console.WriteLine("Edad en 5 años: " + edadEn5Anios);

// SUMA DE DOS NUMEROS

Console.WriteLine("Ingrese el primer numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());  /* convierte el numero ingreasdo que por defecto es string a entero*/
// int numero2 = int.Parse(Console.ReadLine()); /* otra forma de convertir string a entero*/

Console.WriteLine("Ingrese el segundo numero: ");
int numero2 =Convert.ToInt32(Console.ReadLine());

int suma = numero1 + numero2;
Console.WriteLine("La suma de los datos ingresados es : " + suma);

int resta = numero1 - numero2;
Console.WriteLine("La resta de los numeros ingresados es: " + resta);

int multiplicacion = numero1 * numero2;
Console.WriteLine("La multiplicacion de ambos numeros es: " + multiplicacion);

int division = numero1 / numero2;
Console.WriteLine("La division de los numeros es: " +  division);

/* OTRA FORMA */

string resultado = $"La suma es: {suma}";
Console.WriteLine(resultado);
