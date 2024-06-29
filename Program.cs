// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese un número mayor a 0");
int numero;
string texto = Console.ReadLine();
if (int.TryParse(texto, out numero) && numero > 0)
{
    char[] cadena = texto.ToCharArray();
    Array.Reverse(cadena);
    Console.WriteLine(cadena);
}
else
{
    Console.WriteLine("Número ingresado inválido");
}
