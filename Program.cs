// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;

a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
*/
//Ejercicio 1
/*
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
*/
static int suma(int a, int b)
{
    return a + b;
}
static int resta(int a, int b)
{
    return a - b;
}
static int multiplicacion(int a, int b)
{
    return a * b;
}
static int division(int a, int b)
{
    if (b != 0)
    {
        return a / b;
    }
    else
    {
        return -9999;
    }
}
string repetir;
int operacion;
do
{
    do
    {
        Console.WriteLine("Seleccion una operacion");
        Console.WriteLine("\t[1] - Suma");
        Console.WriteLine("\t[2] - Resta");
        Console.WriteLine("\t[3] - Multiplicación");
        Console.WriteLine("\t[4] - Division");
        if (!int.TryParse(Console.ReadLine(), out operacion))
        {
            operacion = 0;
        }
    } while (operacion < 1 || operacion > 4);
    int num1, num2;
    do
    {
        Console.WriteLine("Ingrese el primer operando");
    } while (!int.TryParse(Console.ReadLine(), out num1));
    do
    {
        Console.WriteLine("Ingrese el segundo operando");
    } while (!int.TryParse(Console.ReadLine(), out num2));
    int resultado = 0;
    string op = "";
    switch (operacion)
    {
        case 1:
            resultado = suma(num1, num2);
            op = "+";
            break;
        case 2:
            resultado = resta(num1, num2);
            op = "-";
            break;
        case 3:
            resultado = multiplicacion(num1, num2);
            op = "*";
            break;
        case 4:
            resultado = division(num1, num2);
            op = "/";
            break;
    }
    Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, resultado);
    Console.WriteLine("Desea realizar un calculo? Si[S]/No[N]");
    repetir = Console.ReadLine();
} while ((repetir == "s") || (repetir == "S"));