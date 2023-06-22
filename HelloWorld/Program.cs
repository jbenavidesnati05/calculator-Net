// See https://aka.ms/new-console-template for more information


Double numeroA;
Double numeroB;
Double suma;
Double resta;
Double multi;
Double divi;

Console.WriteLine("************* Calculadora en C# **********");
Console.WriteLine("Ingrese el valor del lado A: ");
numeroA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B: ");
numeroB = Convert.ToDouble(Console.ReadLine());

suma    = numeroA + numeroB;
resta   = numeroA - numeroB;
multi   = numeroA * numeroB;
divi    = numeroA / numeroB;

Console.WriteLine( "El resultado  de la suma  es " + suma);
Console.WriteLine( "El resultado  de la resta es " + resta);
Console.WriteLine( "El resultado  de la multiplicacion es " + multi);
Console.WriteLine( "El resultado  de la division  es " + divi);
Console.WriteLine("************* Fin del programa **********");