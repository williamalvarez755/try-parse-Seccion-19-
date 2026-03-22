DateTime fecha;
bool correcto;
do
{
    Console.WriteLine("Ingrese fecha: DD/MM/AA");
    correcto = DateTime.TryParse(Console.ReadLine(), out fecha);
    if (!correcto || fecha > DateTime.Now)
    {
        Console.WriteLine("Dato no válido... intente nuevamente");
    }
} while (!correcto || fecha > DateTime.Now);
Console.WriteLine($"La fecha es {fecha}");