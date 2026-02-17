
// estructuras de decicion


// simple 

// Console.WriteLine("Ingrese su edad:");
// short edadUsuario = Convert.ToInt16(Console.ReadLine());
// short mayoriaDeEdad = 18;
// if (edadUsuario >= mayoriaDeEdad)
// {
//     Console.WriteLine("Eres mayor de edad.");
// }

// // // compuesto 

// if (edadUsuario >= mayoriaDeEdad)
// {
//     Console.WriteLine("Eres mayor de edad.");
// }
// else
// {
//     Console.WriteLine("Eres menor de edad.");
// }

// anidado en pocas palabras es un if dentro de otro if

// Console.WriteLine("Ingrese su edad:");
// short edadUsuario = Convert.ToInt16(Console.ReadLine());

// Console.WriteLine("Ingrese su estatura en metros:");
// float estatura = Convert.ToSingle(Console.ReadLine());

// Console.WriteLine("¿Eres responsable? (true/false):");
// bool responsable = Convert.ToBoolean(Console.ReadLine());

// Console.WriteLine("Ingrese su estado civil:");
// string estadoCivil = Convert.ToString(Console.ReadLine()) ?? "soltero";

// short mayoriaDeEdad = 18;
// float estaturaMaxima = 1.80f;
// bool esResponsable = true;
// string estadoCivilIdeal = "casado";

// if (edadUsuario >= mayoriaDeEdad)
// {
//     if (estatura <= estaturaMaxima)
//     {
//         if (responsable == esResponsable)
//         {
//             if (estadoCivil != estadoCivilIdeal)
//             {
//                 Console.WriteLine("Hombre ideal");
//             }
//             else
//             {
//                 Console.WriteLine($"No es el hombre ideal porque es casado");
//             }
//         }
//         else
//         {
//             Console.WriteLine("No es el hombre ideal porque no es responsable");
//         }
//     }
//     else
//     {
//         Console.WriteLine("No es el hombre ideal porque es muy alto");
//     }
// }
// else
// {
//     Console.WriteLine("No es el hombre ideal porque es menor de edad");
// }
// // // *********************************



// // // anidado con operadores logicos (&&)**********************

// if (edadUsuario >= mayoriaDeEdad && estatura <= estaturaMaxima && responsable == esResponsable && estadoCivil != estadoCivilIdeal)
// {
//     Console.WriteLine("Hombre ideal");
// }
// else
// {
//     Console.WriteLine("No es el hombre ideal");
// }


// // // anidado con operadores logicos O (||) **************************

// if (edadUsuario >= mayoriaDeEdad || estatura <= estaturaMaxima || responsable == esResponsable || estadoCivil != estadoCivilIdeal)
// {
//     Console.WriteLine("Hombre ideal");
// }
// else
// {
//     Console.WriteLine("No es el hombre ideal");
// }

// /* 
//     && = Y
//     || = O
//     ! = NO
// */


// // anidada para opciones ********************
// // Tipo de producos  Celular, Televisor, computadora

// Console.WriteLine("Ingrese el tipo de producto\n celular\n televisor\n computadora\n");
// string tipoProducto = Console.ReadLine() ?? "";

// int precio = 0;

// switch (tipoProducto.ToLower())
// {
//     case "celular":
//         precio = 1000000;
//         break;
//     case "televisor":
//         precio = 4000000;
//         break;
//     case "computadora":
//         precio = 3700000;
//         break;
//     default:
//         Console.WriteLine("Este producto no está disponible");
//         break;
// }
// Console.WriteLine($"El precio del {tipoProducto} es: {precio}");


//   // anidada con if else para opciones ************************
// // if (tipoProducto == Celular)
// // {
// //     precio = 1000000;

// // }
// // else if (tipoProducto == Televisor)
// // {
// //     precio = 4000000;

// // }
// // else if (tipoProducto == Computador)
// // {
// //     precio = 3700000;

// // }
// // else
// // {
// //     Console.WriteLine("este producto no esta disponible");
// // }
// // Console.WriteLine($"El precio del {tipoProducto} es: {precio}");


// // // if literal signo de interrogacion (condicion ? valor si es verdadero : valor si es falso) *************************
// // Console.WriteLine("Ingrese su edad:");
// // short edad = Convert.ToInt16(Console.ReadLine());

// // string resultado = (edad >= 18) ? "MAYOR DE EDAD" : "MENOR DE EDAD";

// // Console.WriteLine($"Resultado: {resultado}");
