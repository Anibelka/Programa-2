using System;
using System.Net.NetworkInformation;

class SumayProducto
{
    static void Main(string[] args)
    {
        int numero1 = Numero("Ingrese el primer número: ");
        int numero2 = Numero("Ingrese el segundo número: ");
        int numero3 = Numero("Ingrese el tercer número: ");
        int numero4 = Numero("Ingrese el cuarto número: ");

        int suma = numero1 + numero2;
        int producto = numero3 * numero4;

        Console.WriteLine("La suma de los dos primeros números es: " + suma);
        Console.WriteLine("El productos del tercer y cuarto número es: " + producto);

        Console.ReadLine();
    }

    static int Numero(string mensaje)
    {
        int num;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out num);

            if (!esValido)
            {
                Console.WriteLine("\n" +"El valor ingresado no es válido." + "\n" + "Por favor, ingrese un número." + "\n");
            }
        } while (!esValido);

        return num;
    }
}