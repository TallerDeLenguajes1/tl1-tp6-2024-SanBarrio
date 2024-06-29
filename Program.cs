// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("------------- CALCULADORA V1 ------------\n");
int valor;
do{
Console.WriteLine("¿Que operación desea realizar?\n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir\n5)Salir.");
valor = tomarValor1();
int a1,b1;
switch (valor)
{
    case 1: 
        Console.WriteLine("Ingrese el primer valor: ");
         a1=tomarValor1();
        Console.WriteLine("Ingrese el segundo valor: ");
        b1=tomarValor1();
        Console.WriteLine($"La suma de {a1} + {b1} es: {a1+b1}");
    break;
      case 2: 
        Console.WriteLine("Ingrese el primer valor: ");
        a1=tomarValor1();
        Console.WriteLine("Ingrese el segundo valor: ");
        b1=tomarValor1();
        Console.WriteLine($"La resta de {a1} - {b1} es: {a1-b1}");
    break;
      case 3: 
        Console.WriteLine("Ingrese el primer valor: ");
        a1=tomarValor1();
        Console.WriteLine("Ingrese el segundo valor: ");
        b1=tomarValor1();
        Console.WriteLine($"La multiplicacion de {a1} x {b1} es: {a1*b1}");
    break;
      case 4: 
        Console.WriteLine("Ingrese el primer valor: ");
        a1=tomarValor1();
        Console.WriteLine("Ingrese el segundo valor, que sea distinto a 0: ");
        b1=tomarValor1();
        Console.WriteLine($"La division de {a1} y {b1} es: {a1/b1}");
    break;
    default: break;
}

}while(valor!=5);


int tomarValor1(){
    int a;
    while(true){
        if(int.TryParse(Console.ReadLine(),out a)){       
       return a;
    }else{
        Console.WriteLine("El valor ingresado no es un número, ingrese nuevamente: ");
    }
    }
    
}

Console.WriteLine("\n------------- CALCULADORA V2 ------------\n");


float i;

Console.WriteLine("Ingrese un valor:");
i = tomarValor();
Console.WriteLine($"Valor Absoluto de {i}: {Math.Abs(i)}");
Console.WriteLine($"Cuadrado de {i}: {Math.Pow(i,2)}");
Console.WriteLine($"Raiz cuadrada de {i}: {Math.Sqrt(i)}");
Console.WriteLine($"Seno de {i}: {Math.Sin(i)}");
Console.WriteLine($"Coseno de {i}: {Math.Cos(i)}");
Console.WriteLine($"Parte entera de {i}: {(int)i}");


float a,b;
Console.WriteLine("\n-------- Maximo y Minimo -----------\n");
Console.WriteLine("Ingrese el primer valor: ");
a = tomarValor();
Console.WriteLine("Ingrese el segundo valor: ");
b = tomarValor();

Console.WriteLine($"El Maximo entre {a} y {b} es: {Math.Max(a,b)}");
Console.WriteLine($"El Minimo entre {a} y {b} es: {Math.Min(a,b)}");

float tomarValor(){
    float a;
    while(true){
        if(float.TryParse(Console.ReadLine(),out a)){       
       return a;
    }else{
        Console.WriteLine("El valor ingresado no es un número, ingrese nuevamente: ");
    }
    }
    
}

