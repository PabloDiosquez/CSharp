using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función de tipo void (porque no va a devolver nada) llamada
            // “positivoNegativoCero” que reciba un número por valor y una variable por
            // referencia. Que analice el número y escriba variable recibida por referencia
            // con:
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            // Hacer un programa main que permita ingresar 10 números y emitir por
            // pantalla cuántos son positivos, cuántos negativos y cuántos cero.

            int num, contPos = 0, contNeg = 0, contCeros = 0;
            int var = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                posNegCero(num, ref var);

                if(var == 1)
                    contPos++;
                else if(var == -1)
                    contNeg++;
                else
                    contCeros++;
            }

            Console.WriteLine("\n# Positivos: " + contPos);
            Console.WriteLine("# Negativos: " + contNeg);
            Console.WriteLine("# Ceros: " + contCeros);

        }

        static void posNegCero(int num1, ref int num2)
        {
            if(num1 > 0)
                num2 = 1;
            else if(num1 < 0)
                num2 = -1;
            else
                num2 = 0;
        }
    }
}
