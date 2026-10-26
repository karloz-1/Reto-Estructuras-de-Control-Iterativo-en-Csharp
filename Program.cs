// ==================================================================================================
//                  Sección 1
// ==================================================================================================
// =============== ARRAY ===============
using System.Collections;

int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

// =============== REGISTRO DE CALIFICACIONES ===============
System.Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
for (int i = 0; i < calificaciones.Length; i++)
{
    System.Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}
System.Console.WriteLine();

// =============== ORDEN DESCENDENTE ===============
System.Console.WriteLine("=== ORDEN DESCENDENTE ===");
for (int i = calificaciones.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}
System.Console.WriteLine();

// =============== PROMEDIO DEL GRUPO ===============
System.Console.WriteLine("=== PROMEDIO DEL GRUPO ===");
int suma = 0;
foreach (int calificacion in calificaciones)
{
    suma += calificacion;
}
double promedio = (double)suma / calificaciones.Length;
System.Console.WriteLine(@$"Suma total: {suma}
Promedio: {promedio}
");
System.Console.WriteLine();

// =============== POSICIONES PARES ===============
System.Console.WriteLine("=== POSICIONES PARES ===");
for (int i = 0; i < calificaciones.Length; i += 2)
{
    System.Console.WriteLine($"Posición par: {calificaciones[i]}");
}
System.Console.WriteLine();


// ==================================================================================================
//                  Sección 2
// ==================================================================================================
// =============== CONTROL DE ACCESO ===============
System.Console.WriteLine("=== CONTROL DE ACCESO ===");
int intentos = 3;
string clave = "sena2025";
while (intentos > 0)
{
    intentos -= 1;
    System.Console.WriteLine("Ingresa la clave: ");
    string intentoClave = Console.ReadLine();

    if (intentoClave != clave)
    {
        System.Console.WriteLine($"Clave incorrecta. Intentos restantes: {intentos}");
        if (intentos == 0)
        {
            System.Console.WriteLine("Acceso bloqueado");
        }
    }
    else
    {
        System.Console.WriteLine("Acceso concedido.");
        break;
    }
}

// =============== MENÚ PRINCIPAL ===============
string menu = @"1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir";
int opcionElegida = 0;
do
{
    System.Console.WriteLine();
    System.Console.WriteLine(menu);
    opcionElegida = int.Parse(Console.ReadLine());
    System.Console.WriteLine();

    switch (opcionElegida)
    {
        case 1:
            System.Console.WriteLine($"Promedio del grupo: {promedio}");
            break;
        case 2:
            int calificacionMasAlta = 0;
            foreach (int calificacion in calificaciones)
            {
                if (calificacion >= calificacionMasAlta)
                {
                    calificacionMasAlta = calificacion;
                }
            }
            System.Console.WriteLine($"Calificación más alta: {calificacionMasAlta}");
            break;
        case 3:
            System.Console.WriteLine("Hasta luego.");
            break;
        default:
            System.Console.WriteLine("Opción no valida, intenta de nuevo");
            break;
    }
} while (opcionElegida != 3);


// ==================================================================================================
//                  Sección 3
// ==================================================================================================
// =============== PRIMERA CALIFICACIÓN REPROBATORIA ===============
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 60)
    {
        System.Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
        break;
    }

}
System.Console.WriteLine();

// =============== ESTUDIANTES APROBADOS ===============
System.Console.WriteLine("=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
int estudiantesAprobados = 0;
foreach (int calificacion in calificaciones)
{
    if (calificacion < 60)
    {
        continue;
    }
    estudiantesAprobados += 1;
    System.Console.WriteLine($"Aprobado: {calificacion}");
}
System.Console.WriteLine($"Total aprobados: {estudiantesAprobados}");
System.Console.WriteLine();

// =============== FILTRO COMBINADO ===============
System.Console.WriteLine("=== FILTRO COMBINADO ===");
for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 70)
    {
        continue;
    }
    else if (calificaciones[i] >= 95)
    {
        System.Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
        break;
    }
    else
    {
        System.Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
    }
}