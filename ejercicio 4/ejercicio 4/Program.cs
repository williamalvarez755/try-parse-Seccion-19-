Console.WriteLine("ingrese año de nacimiento ");
int fecha;
while (!int.TryParse(Console.ReadLine(),out fecha)||fecha<1950)
{
    Console.WriteLine("año invalido");
}
Console.WriteLine("año valido \n el año es " + fecha);