Module Module1

    Sub Main(
            
        using System;

namespace CalculoPromedioInfracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingresa el número total de infracciones en el mes (N)
            Console.Write("Ingresa el número total de infracciones en el mes (N): ");
            int totalInfracciones = int.Parse(Console.ReadLine());

            // Calcula los promedios diarios de infracciones en las diferentes jornadas
            double promedioMatutino = 0.2 * totalInfracciones / 30;
            double promedioTarde = 0.35 * totalInfracciones / 30;
            double promedioNocturno = 0.45 * totalInfracciones / 30;

            // Imprime los resultados
            Console.WriteLine($"Promedio diario matutino de infracciones: {promedioMatutino}");
            Console.WriteLine($"Promedio diario en la tarde de infracciones: {promedioTarde}");
            Console.WriteLine($"Promedio diario nocturno de infracciones: {promedioNocturno}");

            // Espera a que el usuario presione Enter para cerrar la aplicación
            Console.ReadLine();
        }
    }
}
)

    End Sub

End Module
