// See https://aka.ms/new-console-template for more information
/*
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
*/
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
        Console.WriteLine("\t[1] - Valor Absoluto");
        Console.WriteLine("\t[2] - Cuadrado");
        Console.WriteLine("\t[3] - Raiz cuadrada");
        Console.WriteLine("\t[4] - Seno");
        Console.WriteLine("\t[5] - Coseno");
        Console.WriteLine("\t[6] - Parte entera de un entero");
        Console.WriteLine("\t[7] - Maximo");
        Console.WriteLine("\t[8] - Minimo");
        if (!int.TryParse(Console.ReadLine(), out operacion))
        {
            operacion = 0;
        }
    } while (operacion < 1 || operacion > 8);
    if (operacion >= 1 && operacion <= 6)
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
            resultado = valorAbs(a);
            Console.WriteLine($"El valor abosluto de {a:F2} es {resultado:F2}");
            break;
        case 2:
            resultado = cuadrado(a);
            Console.WriteLine($"El cuadrado de {a:F2} es {resultado:F2}");
            break;
        case 3:
            resultado = raiz(a);
            Console.WriteLine($"La raiz de {a:F2} es {resultado:F2}");
            break;
        case 4:
            resultado = seno(a);
            Console.WriteLine($"El seno de {a:F2} es {resultado:F2}");
            break;
        case 5:
            resultado = coseno(a);
            Console.WriteLine($"El coseno de {a:F2} es {resultado:F2}");
            break;
        case 6:
            resultado = parteEntera(a); //se castea implicitamente
            Console.WriteLine($"La parte entera de {a:F2} es {resultado}");
            break;
        case 7:
            resultado = maximo(num1, num2);
            Console.WriteLine($"El maximo entre {num1} y {num2} es {resultado}");
            break;
        case 8:
            resultado = minimo(num1, num2);
            Console.WriteLine($"El maximo entre {num1} y {num2} es {resultado}");
            break;
    }
    Console.WriteLine("Desea realizar un calculo? Si[S]/No[N]");
    repetir = Console.ReadLine();
} while ((repetir == "s") || (repetir == "S"));