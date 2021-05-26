using System;
using System.Collections.Generic;
using System.Linq;


namespace Prueba
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Teclee una palabra: ");
            //var linea = Console.ReadLine();
            //var isPalindrome = EsPalindroma(linea) ? "Es palindroma" : "No es palindroma";
            //Console.WriteLine(isPalindrome);
            //Console.ReadKey();

            //VALOR MAXIMO EN UN ARREGLO
            var array = new List<int> { 1, 2, 3, 4 };
            var valorMaximo = array.Max();
            Console.WriteLine(valorMaximo);

            //ENCONTRAR ELEMENTO EN UN ARREGLO
            string[] stringArray = { "value1", "value2", "value3", "value4" };
            var value = "value3";
            var check = Array.Exists(stringArray, x => x.ToUpper() == value.ToUpper());
            if (check)
            {
                Console.WriteLine("{0} Si se encontro en el arreglo", value);
            }
            else
            {
                Console.WriteLine("Valor no encontrado");
            }

            //SEPARAR POR COMA
            var palabra = "hola,jaja,lucio";
            var arreglo = palabra.Split(',');
            foreach (var i in arreglo)
            {
                Console.WriteLine(i);
            }
        }

        //SUMA PARES E IMPARES
        private static void SumaParesImpares()
        {
            byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;
            string linea;
            Console.Write("NÚMERO MÁXIMO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (I = 1; I <= NUM; I += 2)
            {
                SUMP = SUMP + I;
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI = SUMI + I;
            }
            Console.WriteLine("TOTAL EN PARES : " + SUMP);
            Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        //VOCAL CIFRA CONSONANTE
        private static void VocalCifraConstante()
        {
            char tecla;
            string linea;
            Console.Write("DIGITE UNA SOLA TECLA");
            Console.WriteLine();
            linea = Console.ReadLine();
            tecla = char.Parse(linea);
            switch (tecla)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("ES UNA CIFRA NUMERICA");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("ES UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("ES UNA CONSONANTE");
                    break;
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }

        //SERIE FIBONACCI
        private static void Fibonacci()
        {
            int a, b, limite, auxiliar;
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (var i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }

        //PALINDROMO CON FOR
        private static void Palindromo()
        {
            var str = string.Empty;
            Console.WriteLine("_____________! INTRODUCE UNA PALABRA !________________ ");
            var s = Console.ReadLine();
            var i = s.Length;
            for (var j = i - 1; j >= 0; j--)
            {
                str += s[j];
            }
            if (str == s)
            {
                Console.WriteLine(s + " es palindrome");
            }
            else
            {
                Console.WriteLine(s + " no es palindrome");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

        //PALINDROMO
        private static bool EsPalindroma(string cadena)
        {
            Console.WriteLine("Función llamada con: " + cadena);
            if (cadena.Length < 2) return true;
            Console.WriteLine("Vamos a comparar: " + cadena[0]);
            Console.WriteLine("Con: " + cadena[^1]);
            if (cadena[0] == cadena[^1])
                return EsPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }
    }
}
