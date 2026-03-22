double nota;
Console.Write("Ingrese la nota (0-100): ");

while (!double.TryParse(Console.ReadLine(), out nota)
       || nota < 0 || nota > 100)
{
    Console.WriteLine("Error: nota debe estar entre 0 y 100.");
    Console.Write("Ingrese la nota (0-100): ");
}

if (nota > 60) { 
Console.WriteLine($"Nota: {nota} es aprovada");
}
else
{
    Console.WriteLine($"Nota: {nota} es reprovada");
}