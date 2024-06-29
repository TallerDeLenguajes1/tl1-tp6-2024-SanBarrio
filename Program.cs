// See https://aka.ms/new-console-template for more information
string i;
do{
Console.WriteLine("¿Que operación desea realizar?\n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir\n5)Salir.");
i = Console.ReadLine();
int a,b;
switch (i)
{
    case "1": 
        Console.WriteLine("Ingrese el primer valor: ");
        int.TryParse(Console.ReadLine(),out a);
        Console.WriteLine("Ingrese el segundo valor: ");
        int.TryParse(Console.ReadLine(),out b);
        Console.WriteLine($"La suma de {a} + {b} es: {a+b}");
    break;
      case "2": 
        Console.WriteLine("Ingrese el primer valor: ");
        int.TryParse(Console.ReadLine(),out a);
        Console.WriteLine("Ingrese el segundo valor: ");
       int.TryParse(Console.ReadLine(),out b);
        Console.WriteLine($"La resta de {a} - {b} es: {a-b}");
    break;
      case "3": 
        Console.WriteLine("Ingrese el primer valor: ");
        int.TryParse(Console.ReadLine(),out a);
        Console.WriteLine("Ingrese el segundo valor: ");
        int.TryParse(Console.ReadLine(),out b);
        Console.WriteLine($"La multiplicacion de {a} x {b} es: {a*b}");
    break;
      case "4": 
        Console.WriteLine("Ingrese el primer valor: ");
        int.TryParse(Console.ReadLine(),out a);
        Console.WriteLine("Ingrese el segundo valor, que sea distinto a 0: ");
        int.TryParse(Console.ReadLine(),out b);
        Console.WriteLine($"La division de {a} y {b} es: {a/b}");
    break;
    default: break;
}

}while(i!="5");
