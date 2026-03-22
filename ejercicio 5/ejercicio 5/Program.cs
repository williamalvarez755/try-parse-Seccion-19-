Console.WriteLine("ingrese numero ");
int numero;
while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0) { 
    Console.WriteLine(numero+" invalido");
}
if (numero % 2 == 0)
{
    Console.WriteLine("el numero " + numero +" es par");
}
else
{
    Console.WriteLine("el numero " + numero + " es imparpar");
}
