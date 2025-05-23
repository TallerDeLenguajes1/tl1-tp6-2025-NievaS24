// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
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
//Ejercicio 4
// string texto;
// Console.WriteLine("Ingrese un texto");
// texto = Console.ReadLine();
// int longitud = texto.Length;
// Console.WriteLine($"La longitud de {texto} es {longitud}.");
// string texto2;
// Console.WriteLine("Ingrese otro texto");
// texto2 = Console.ReadLine();
// string textoConcatenado = string.Concat(texto, texto2);
// Console.WriteLine($"El texto concatenado queda {textoConcatenado}.");
// string subtexto = textoConcatenado.Substring(0, 3);
// Console.WriteLine($"{subtexto} es una subcadena de {textoConcatenado}");
// foreach (char item in textoConcatenado)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("Ingrese un texto para buscar en el texto concatenado");
// string buscado = Console.ReadLine();
// int posicion = textoConcatenado.IndexOf(buscado);
// if (posicion != -1)
// {
//     Console.WriteLine($"La palabra buscada {buscado} esta en la posicion {posicion}.");
// }
// else
// {
//     Console.WriteLine($"No se encontro {buscado} en {textoConcatenado}");
// }
// Console.WriteLine($"La cadena escrita en mayusculas queda: {textoConcatenado.ToUpper()}");
// Console.WriteLine($"La cadena escrita en minusculas queda: {textoConcatenado.ToLower()}");
// Console.WriteLine("Ingrese un texto largo");
// string textoLargo = Console.ReadLine();
// string[] palabras = textoLargo.Split(" ");
// Console.WriteLine($"Las palabras de {textoLargo} son:");
// foreach (string palabra in palabras)
// {
//     Console.WriteLine(palabra);
// }
Console.WriteLine("Ingrese una operacion (Ej: 24 + 2)");
string expresion = Console.ReadLine();
string[] operandos = expresion.Split(" ");
if (int.TryParse(operandos[0], out int a) && int.TryParse(operandos[2], out int b))
{
    switch (operandos[1])
    {
        case "+":
            Console.WriteLine($"La suma de {a} y {b} es {a + b}");
            break;
        case "-":
            Console.WriteLine($"La diferencia entre {a} y {b} es {a - b}");
            break;
        case "*":
            Console.WriteLine($"El producto de {a} y {b} es {a * b}");
            break;
        case "/":
            if (b != 0)
            {
                Console.WriteLine($"El cociente entre {a} y {b} es {a / b}");
            }
            else
            {
                Console.WriteLine("No se puede dividir sobre cero");
            }
            break;
    }
}