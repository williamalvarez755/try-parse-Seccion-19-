Console.WriteLine("Ingrese edad");
int edad;

while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0 || edad > 110)
{
    Console.WriteLine("Edad inválida, ingrese un valor entre 0 y 110");
}

Console.WriteLine($"Edad ingresada: {edad}");