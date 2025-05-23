// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;

a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

//Ejercicio 1
int num, aux = 0;
string input;
do
{
    Console.WriteLine("Ingrese un numero");
    input = Console.ReadLine();
} while (!int.TryParse(input, out num));
if (num > 0)
{
    while (num > 0)
    {
        aux = aux * 10 + num % 10;
        num /= 10;
    }
}
Console.WriteLine(aux);