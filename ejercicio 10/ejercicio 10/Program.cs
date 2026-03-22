int cantidad;

Console.Write("Cantidad de productos: ");

while (!int.TryParse(Console.ReadLine(), out cantidad)
       || cantidad <= 0)
{
    Console.WriteLine("Error: ingrese un entero > 0.");
    Console.Write("Cantidad de productos: ");
}

for (int i = 1; i <= cantidad; i++)
{
    Console.Write($"Producto {i}: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Registrado: {nombre}");
}
Console.WriteLine("Compra finalizada.");