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
