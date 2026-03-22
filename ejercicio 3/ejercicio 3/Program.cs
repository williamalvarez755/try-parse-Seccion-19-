Console.WriteLine("Ingrese cantidad de estudiantes del curos");
int estudinates=0;
while (!int.TryParse(Console.ReadLine(),out estudinates)||estudinates<0)
{
    Console.WriteLine("numero invalido");
}
Console.WriteLine("Numero de estudiantes es " + estudinates);