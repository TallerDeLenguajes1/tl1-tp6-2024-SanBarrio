// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

int i;
do{
Console.WriteLine("¿Que operación desea realizar?\n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir\n5)Salir.");
i = tomarValor();
int a,b;
switch (i)
{
    case 1: 
        Console.WriteLine("Ingrese el primer valor: ");
         a=tomarValor();
        Console.WriteLine("Ingrese el segundo valor: ");
        b=tomarValor();
        Console.WriteLine($"La suma de {a} + {b} es: {a+b}");
    break;
      case 2: 
        Console.WriteLine("Ingrese el primer valor: ");
        a=tomarValor();
        Console.WriteLine("Ingrese el segundo valor: ");
        b=tomarValor();
        Console.WriteLine($"La resta de {a} - {b} es: {a-b}");
    break;
      case 3: 
        Console.WriteLine("Ingrese el primer valor: ");
        a=tomarValor();
        Console.WriteLine("Ingrese el segundo valor: ");
        b=tomarValor();
        Console.WriteLine($"La multiplicacion de {a} x {b} es: {a*b}");
    break;
      case 4: 
        Console.WriteLine("Ingrese el primer valor: ");
        a=tomarValor();
        Console.WriteLine("Ingrese el segundo valor, que sea distinto a 0: ");
        b=tomarValor();
        Console.WriteLine($"La division de {a} y {b} es: {a/b}");
    break;
    default: break;
}

}while(i!=5);


int tomarValor(){
    int a;
    while(true){
        if(int.TryParse(Console.ReadLine(),out a)){       
       return a;
    }else{
        Console.WriteLine("El valor ingresado no es un número, ingrese nuevamente: ");
    }
    }
    
}