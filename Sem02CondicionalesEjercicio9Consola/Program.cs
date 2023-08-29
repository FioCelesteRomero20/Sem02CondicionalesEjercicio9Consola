// See https://aka.ms/new-console-template for more information
double num1, num2, num3;

Console.WriteLine("Ingrese 3 numeros diferentes");

num1 = double.Parse(Console.ReadLine());
num2 = double.Parse(Console.ReadLine());   
num3 = double.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("El numero mayor es: " + num1);
}
else if (num2 > num1 &&  num2 > num3)
{
    Console.WriteLine("El numero mayor es: " + num2);
}
else
{
    Console.WriteLine("El numero mayor es: " + num3);
}