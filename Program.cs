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
float valorAbs(float a)
{
    return (float)Math.Abs(a);
}
float cuadrado(float a)
{
    return a * a;
}
float raiz(float a)
{
    return (float)Math.Sqrt(a);
}
float seno(float a)
{
    return (float)Math.Sin(a);
}
float coseno(float a)
{
    return (float)Math.Cos(a);
}
int parteEntera(float a)
{
    return (int)a;
}
int maximo(int a, int b)
{
    if (a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
int minimo(int a, int b)
{
    if (a <= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
string repetir;
int operacion, num1 = 0, num2 = 0;
float a = 0, resultado;
do
{
    do
    {
        Console.WriteLine("Seleccion una operacion");
        Console.WriteLine("\t[1] - Suma");
        Console.WriteLine("\t[2] - Resta");
        Console.WriteLine("\t[3] - Multiplicación");
        Console.WriteLine("\t[4] - Division");
        Console.WriteLine("\t[5] - Valor Absoluto");
        Console.WriteLine("\t[6] - Cuadrado");
        Console.WriteLine("\t[7] - Raiz cuadrada");
        Console.WriteLine("\t[8] - Seno");
        Console.WriteLine("\t[9] - Coseno");
        Console.WriteLine("\t[10] - Parte entera de un entero");
        Console.WriteLine("\t[11] - Maximo");
        Console.WriteLine("\t[12] - Minimo");
        if (!int.TryParse(Console.ReadLine(), out operacion))
        {
            operacion = 0;
        }
    } while (operacion < 1 || operacion > 12);
    if (operacion >= 5 && operacion <= 10)
    {
        do
        {
            Console.WriteLine("Ingrese el numero");
        } while (!float.TryParse(Console.ReadLine(), out a));
    }
    else
    {
        do
        {
            Console.WriteLine("Ingrese el primer numero");
        } while (!int.TryParse(Console.ReadLine(), out num1));
        do
        {
            Console.WriteLine("Ingrese el segundo numero");
        } while (!int.TryParse(Console.ReadLine(), out num2));
    }
    switch (operacion)
    {
        case 1:
            resultado = suma(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {resultado}");
            break;
        case 2:
            resultado = resta(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {resultado}");
            break;
        case 3:
            resultado = multiplicacion(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {resultado}");
            break;
        case 4:
            resultado = division(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {resultado}");
            break;
        case 5:
            resultado = valorAbs(a);
            Console.WriteLine($"El valor abosluto de {a:F2} es {resultado:F2}");
            break;
        case 6:
            resultado = cuadrado(a);
            Console.WriteLine($"El cuadrado de {a:F2} es {resultado:F2}");
            break;
        case 7:
            resultado = raiz(a);
            Console.WriteLine($"La raiz de {a:F2} es {resultado:F2}");
            break;
        case 8:
            resultado = seno(a);
            Console.WriteLine($"El seno de {a:F2} es {resultado:F2}");
            break;
        case 9:
            resultado = coseno(a);
            Console.WriteLine($"El coseno de {a:F2} es {resultado:F2}");
            break;
        case 10:
            resultado = parteEntera(a); //se castea implicitamente
            Console.WriteLine($"La parte entera de {a:F2} es {resultado}");
            break;
        case 11:
            resultado = maximo(num1, num2);
            Console.WriteLine($"El maximo entre {num1} y {num2} es {resultado}");
            break;
        case 12:
            resultado = minimo(num1, num2);
            Console.WriteLine($"El maximo entre {num1} y {num2} es {resultado}");
            break;
    }
    Console.WriteLine("Desea realizar un calculo? Si[S]/No[N]");
    repetir = Console.ReadLine();
} while ((repetir == "s") || (repetir == "S"));