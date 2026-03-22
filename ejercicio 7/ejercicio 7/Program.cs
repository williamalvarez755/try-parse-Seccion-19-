decimal salario;

Console.Write("Ingrese el salario: ");

while (!decimal.TryParse(Console.ReadLine(), out salario)
       || salario < 0)
{
    Console.WriteLine("Error: ingrese un decimal >= 0.");
    Console.Write("Ingrese el salario: ");
}

Console.WriteLine($"Salario registrado " + salario);