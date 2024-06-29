// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

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