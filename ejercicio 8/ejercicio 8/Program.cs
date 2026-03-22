
int numero;

Console.Write("Ingrese un número entero >= 0: ");

while (!int.TryParse(Console.ReadLine(), out numero)
       || numero < 0)
{
    Console.WriteLine("Error: ingrese un entero >= 0.");
    Console.Write("Ingrese un número entero >= 0: ");
}

int raiz = 0;

while (raiz * raiz <= numero)
{
    raiz++;
}

raiz--;

Console.WriteLine($"Raíz de {numero} = {raiz}");
Console.WriteLine($"Comprobación: {raiz} x {raiz} = {raiz * raiz}");