// // See https://aka.ms/new-console-template for more information
// using System.Reflection.Metadata.Ecma335;

// Console.WriteLine("------------- CALCULADORA V1 ------------\n");
// int valor;
// do{
// Console.WriteLine("¿Que operación desea realizar?\n1)Sumar\n2)Restar\n3)Multiplicar\n4)Dividir\n5)Salir.");
// valor = tomarValor1();
// int a1,b1;
// switch (valor)
// {
//     case 1: 
//         Console.WriteLine("Ingrese el primer valor: ");
//          a1=tomarValor1();
//         Console.WriteLine("Ingrese el segundo valor: ");
//         b1=tomarValor1();
//         Console.WriteLine($"La suma de {a1} + {b1} es: {a1+b1}");
//     break;
//       case 2: 
//         Console.WriteLine("Ingrese el primer valor: ");
//         a1=tomarValor1();
//         Console.WriteLine("Ingrese el segundo valor: ");
//         b1=tomarValor1();
//         Console.WriteLine($"La resta de {a1} - {b1} es: {a1-b1}");
//     break;
//       case 3: 
//         Console.WriteLine("Ingrese el primer valor: ");
//         a1=tomarValor1();
//         Console.WriteLine("Ingrese el segundo valor: ");
//         b1=tomarValor1();
//         Console.WriteLine($"La multiplicacion de {a1} x {b1} es: {a1*b1}");
//     break;
//       case 4: 
//         Console.WriteLine("Ingrese el primer valor: ");
//         a1=tomarValor1();
//         Console.WriteLine("Ingrese el segundo valor, que sea distinto a 0: ");
//         b1=tomarValor1();
//         Console.WriteLine($"La division de {a1} y {b1} es: {a1/b1}");
//     break;
//     default: break;
// }

// }while(valor!=5);


// int tomarValor1(){
//     int a;
//     while(true){
//         if(int.TryParse(Console.ReadLine(),out a)){       
//        return a;
//     }else{
//         Console.WriteLine("El valor ingresado no es un número, ingrese nuevamente: ");
//     }
//     }
    
// }

// Console.WriteLine("\n------------- CALCULADORA V2 ------------\n");


// float i;

// Console.WriteLine("Ingrese un valor:");
// i = tomarValor();
// Console.WriteLine($"Valor Absoluto de {i}: {Math.Abs(i)}");
// Console.WriteLine($"Cuadrado de {i}: {Math.Pow(i,2)}");
// Console.WriteLine($"Raiz cuadrada de {i}: {Math.Sqrt(i)}");
// Console.WriteLine($"Seno de {i}: {Math.Sin(i)}");
// Console.WriteLine($"Coseno de {i}: {Math.Cos(i)}");
// Console.WriteLine($"Parte entera de {i}: {(int)i}");


// float a,b;
// Console.WriteLine("\n-------- Maximo y Minimo -----------\n");
// Console.WriteLine("Ingrese el primer valor: ");
// a = tomarValor();
// Console.WriteLine("Ingrese el segundo valor: ");
// b = tomarValor();

// Console.WriteLine($"El Maximo entre {a} y {b} es: {Math.Max(a,b)}");
// Console.WriteLine($"El Minimo entre {a} y {b} es: {Math.Min(a,b)}");

// float tomarValor(){
//     float a;
//     while(true){
//         if(float.TryParse(Console.ReadLine(),out a)){       
//        return a;
//     }else{
//         Console.WriteLine("El valor ingresado no es un número, ingrese nuevamente: ");
//     }
//     }
    
// }

Console.WriteLine("\n------------- Ejercicio 4 ------------\n");

//Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("Ingrese una cadena de caracteres: ");
string cadena = Console.ReadLine();
Console.WriteLine($"La longitud de la cadena ingresada es: {cadena.Length} ");

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese una segunda cadena de caracteres: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"Cadenas de caracteres concatenadas: {cadena + cadena2}");

//Extraer una subcadena de la cadena ingresada
string cadena3 =  cadena + cadena2;
Console.WriteLine($"La subcadena: {cadena3.Substring(4)}");

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
foreach (char letrita in cadena3) {
    Console.WriteLine(letrita);
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
if (cadena3.Contains("hola")) {
    Console.WriteLine("La palabra 'hola' si está contenida en la cadena de caracteres.");
} else {
    Console.WriteLine("La palabra 'hola' no está contenida en la cadena de caracteres.");
}

//Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine($"La cadena de caracteres en mayúsculas es: {cadena3.ToUpper()}");
Console.WriteLine($"La cadena de caracteres en minúsculas es: {cadena3.ToLower()}");

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
string cadena4 = "hola,como,que,tal,estas?";
string[] cadenaSplit = cadena4.Split(",");
Console.WriteLine($"Cadena de caracteres {cadena4}, usando Split: ");
foreach (string pal in cadenaSplit) {
    Console.WriteLine(pal);
}


//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
Console.WriteLine("Ingrese una cadena de caracteres: ");
string cadena5 = Console.ReadLine();
string[] cadenaSplit2;
int a3 , b3;
if(cadena5.Contains('+')){
    cadenaSplit2=cadena5.Split('+');
    a3=int.Parse(cadenaSplit2[0]); 
    b3=int.Parse(cadenaSplit2[1]); 

    Console.Write($"La suma de {cadenaSplit2[0]} + {cadenaSplit2[1]} es: {a3+b3}");
}else if(cadena5.Contains('-')){
    cadenaSplit2=cadena5.Split('-');
    a3=int.Parse(cadenaSplit2[0]); 
    b3=int.Parse(cadenaSplit2[1]); 

    Console.Write($"La resta de {cadenaSplit2[0]} - {cadenaSplit2[1]} es: {a3-b3}");
}if(cadena5.Contains('x')){
    cadenaSplit2=cadena5.Split('x');
    a3=int.Parse(cadenaSplit2[0]); 
    b3=int.Parse(cadenaSplit2[1]); 

    Console.Write($"La multiplicacion de {cadenaSplit2[0]} x {cadenaSplit2[1]} es: {a3*b3}");
}else if(cadena5.Contains('/')){
    cadenaSplit2=cadena5.Split('/');
    a3=int.Parse(cadenaSplit2[0]); 
    b3=int.Parse(cadenaSplit2[1]); 

    Console.Write($"La division de {cadenaSplit2[0]} / {cadenaSplit2[1]} es: {a3/b3}");
}
