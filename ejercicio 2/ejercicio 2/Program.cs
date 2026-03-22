double precio = -1;
Console.WriteLine("ingrese precio del producto ");
while (!double.TryParse(Console.ReadLine(), out precio) || precio<0) 
{
    Console.WriteLine("precio invalido");
}
Console.WriteLine("precio es de " + precio );