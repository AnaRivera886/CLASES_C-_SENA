// See https://aka.ms/new-console-template for more information
Console.WriteLine("\t HOLA USUARIO! INGRESA LOS SIGUIENTES DATOS: ");

Console.WriteLine("Nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Edad: ");
int edad = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Plan: premium, familiar, basico o gratis ");
string plan = Console.ReadLine().ToLower();

string [] titulos =
{
    "Stranger Things",
    "Bluey",
    "Deadpool",
    "Encanto",
    "The Witcher"
};

string [] clasificacion =
{
    "T+13",
        "TP",
        "M+18",
        "TP",
        "M+18"
};

int [] edadMinima = {13, 0, 18, 0, 18};

int contenido = 0;
string beneficio = "";

switch (plan)
{
    case "premium":
        contenido = 5;
        beneficio = "Catalogo completo + 4K";
        break;

    case "familiar":
        contenido = 4;
        beneficio = "Catalogo Familiar + HD";
        break;

    case "basico":
        contenido = 3;
        beneficio = "Catalogo Limitado + SD";
        break;
    
    case "gratis":
        contenido = 2;
        beneficio = "Solo contenido gratuito";
        break;
    
    default:
        contenido = 0;
        beneficio = "Plan no reconocido";
        break;
}

Console.WriteLine($"\t Plan: {plan}");
Console.WriteLine($"Beneficio: {beneficio}");
Console.WriteLine("\nContenido disponible:");

int mostrados = 0;

for (int i = 0; i < titulos.Length; i++)
        {
            if (edad >= edadMinima[i] && mostrados < contenido)
            {
                Console.WriteLine("✅ " + titulos[i] +
                                " (" + clasificacion[i] + ")");
                mostrados++;
            }
        }






